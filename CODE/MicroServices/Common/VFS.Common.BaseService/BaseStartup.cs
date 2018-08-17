using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;
using VFS.Common.BaseService.ConnectionFactory;
using VFS.Common.BaseService.Repository;
using VFS.Common.Configuration;
using VFS.Common.Configuration.Models;
using VFS.Common.Configuration.Repository;
using VFS.Common.BaseService.Models;

namespace VFS.Common.BaseService
{
    public class BaseStartup
    {
        public IConfiguration Configuration { get; set; }

        protected Container Container;

        private BaseManager _BaseManager;

        private BaseManager ManagerBase
        {
            get
            {
                if (_BaseManager != null)
                    return _BaseManager;

                var appContextRepository = Container.GetInstance<IAppContextRepository>();
                _BaseManager = new BaseManager(appContextRepository);
                return _BaseManager;
            }
        }

        protected BaseStartup(IHostingEnvironment env, IEnumerable<string> settingsFiles)
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(env.ContentRootPath);
            foreach (var file in settingsFiles)
            {
                builder.AddJsonFile(file, reloadOnChange: true, optional: false);
            }

            Configuration = builder.Build();
            Container = new Container();
        }

        public void ConfigureBaseServices(IServiceCollection services, Info serviceInfo)
        {
            services.AddMvc();

            services.ConfigureSwaggerGen(options =>
            {
                options.CustomSchemaIds(x => x.FullName);
            });

            services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.DefaultApiVersion = new ApiVersion(1, 0);
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(serviceInfo.Version, serviceInfo);
            });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins("*")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            IntegrateSimpleInjector(services);
        }

        public void ConfigureBase(IApplicationBuilder app, IHostingEnvironment env, string swaggerUrl, string swaggerDescription)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.Use(async (context, next) =>
            {
                var requestUrl = context.Request.Path.ToString();
                if (IsApiUrl(requestUrl))
                {
                    var appurl = new AppUrl(requestUrl);
                    context.Items[ServiceBaseConstant.AppContext] = ManagerBase.BuildAppContext(appurl);
                    context.Items[ServiceBaseConstant.AppRedirectionUrl] = appurl;
                }

                await next.Invoke();
            });


            app.UseMvc();

            app.UseSwagger();

            app.UseCors(builder => builder.WithOrigins("*")
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials());

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(swaggerUrl, swaggerDescription);
                c.RoutePrefix = "";

            });

            RegisterServices(app);

            var configurationSettings = new ConfigurationSettings()
            {
                ConfigDbConnectionString = Configuration.GetSection("ConfigurationSettings")["ConfigDBConnectionString"],
                MasterApiBaseUrl = Configuration.GetSection("ConfigurationSettings")["MasterApiBaseUrl"],
                MasterApi = Configuration.GetSection("ConfigurationSettings")["MasterApi"],
                MasterPort = Configuration.GetSection("ConfigurationSettings")["MasterPort"],
                MasterVersion = Configuration.GetSection("ConfigurationSettings")["MasterVersion"],
                //SmsApplicantTemplate = Configuration.GetSection("ConfigurationSettings")["SmsApplicantTemplate"],
                //SmsApplicantResubmissionTemplate = Configuration.GetSection("ConfigurationSettings")["SmsApplicantResubmissionTemplate"]
            };
            Container.RegisterSingleton<ConfigurationSettings>(() => configurationSettings);
        }

        private void IntegrateSimpleInjector(IServiceCollection services)
        {
            //AsyncScopedLifestyle : There will be only one instance of a given service type within a certain (explicitly defined) scope.
            //This scope will automatically flow with the logical flow of control of asynchronous methods
            Container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(Container));
            services.EnableSimpleInjectorCrossWiring(Container);
            services.UseSimpleInjectorAspNetRequestScoping(Container);
        }

        private void RegisterServices(IApplicationBuilder app)
        {
            Container.Register<IAppContextRepository, AppContextRepository>();
            Container.Register<IConnectionFactory, SqlConnectionFactory>();
            Container.Register<IConfigurationManager, ConfigurationManager>();
            Container.Register<IConfigurationRepository, ConfigurationRepository>();

            Container.CrossWire<IHttpContextAccessor>(app);
        }

        static bool IsApiUrl(string requestUrl)
        {
            return requestUrl.StartsWith("/api/v");
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using System;
//using VFS.Enigma.ApplicationManager.Filter;
//using VFS.Enigma.ApplicationManager.Manager;
//using VFS.Enigma.ApplicationManager.Manager.Common;
//using VFS.Enigma.ApplicationManager.Repository;
//using VFS.Enigma.ApplicationManager.Repository.Common;
//using VFS.Enigma.ApplicationManager.Validation;
using VFS.Common.BaseService;
using VFS.Common.BaseService.Utility;
using VFS.MicroServices.Application.Models;
//using VFS.Enigma.Notifications;
//using VFS.Enigma.ApplicationManager.Model;
//using Dapper;
//using System.Collections.Generic;

namespace VFS.MicroServices.Application
{
    public class Startup : BaseStartup
    {
        private static string[] settingsFile = { "appsettings.json" };
        public Startup(IHostingEnvironment env) : base(env, settingsFile)
        {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var swaggerInfo = new Info()
            {
                Title = "Application Service",
                Version = "v1"
            };
            base.ConfigureBaseServices(services, swaggerInfo);
            //Container.Register<IApplicationManager, ApplicationManager>();
            //Container.Register<IApplicationRepository, ApplicationRepository>();
            //Container.Register<IVisaApplicationValidationManager, VisaApplicationValidationManager>();
            //Container.Register<IVisaApplicationValidationRepository, VisaApplicationValidationRepository>();
            //Container.Register<IMasterManager, MasterManager>();
            //Container.Register<IAIdManager, AIDManager>();
            //Container.Register<IAIdRepository, AIdRepository>();
            //Container.Register<IPrinterManager, PrinterManager>();
            //Container.Register<IPrinterRepository, PrinterRepository>();
            //Container.Register<IValidateSaveVisaApplicationManager, ValidateSaveVisaApplicationManager>();
            //Container.Register<IValidateResubmitVisaApplicationManager, ValidateResubmitVisaApplicationManager>();

            //AutoMapperConfig.Configure();
            SqlMapperConfig.Configure();

            //SqlMapper.AddTypeHandler(typeof(GratisDetail), new JsonObjectTypeHandler());
            //SqlMapper.AddTypeHandler(typeof(IList<VasDetail>), new JsonObjectTypeHandler());

            //EmailDependencyResolver.RegisterServices(Container);
            //registered custom exception filter here
            //services.AddMvcCore(p =>
            //{
            //    p.Filters.Add(typeof(ExceptionFilter));
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            try
            {
                var swaggerDescription = string.Format("{0} {1}", "Application Service", "v1");

                base.ConfigureBase(app, env, "/swagger/v1/swagger.json", swaggerDescription);

                var builder = new ConfigurationBuilder();

                builder.SetBasePath(env.ContentRootPath);
                foreach (var file in settingsFile)
                {
                    builder.AddJsonFile(file, reloadOnChange: true, optional: false);
                }
                Configuration = builder.Build();
            }
            catch (Exception ex)
            {
                //When error is outside OWIN pipeline
                app.Run(async context =>
                {
                    ILogger logger = loggerFactory.CreateLogger(Message.ServiceConfigureError);
                    logger.LogError(new EventId(ex.HResult), ex, Message.ServiceConfigureError);

                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    context.Response.ContentType = Message.ResponseJsonContentTypes;
                    if (env.IsDevelopment())
                    {
                        await context.Response.WriteAsync(Convert.ToString(ex.GetBaseException().Message)).ConfigureAwait(false);
                        await context.Response.WriteAsync(ex.StackTrace).ConfigureAwait(false);
                    }
                    else
                        await context.Response.WriteAsync(Error.RequestProcess).ConfigureAwait(false);
                });
            }
        }
    }
}

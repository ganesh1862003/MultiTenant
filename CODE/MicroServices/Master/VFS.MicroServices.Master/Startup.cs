using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using VFS.Common.BaseService;
using VFS.MicroServices.Master.Manager;
using VFS.MicroServices.Master.Repository;

namespace VFS.MicroServices.Master
{
    public class Startup : BaseStartup
    {
        private static readonly string[] settingsFile = { "appsettings.json" };
        public Startup(IHostingEnvironment env) : base(env, settingsFile)
        {

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var swaggerInfo = new Info()
            {
                Title = "Master Service",
                Version = "v1"
            };

            ConfigureBaseServices(services, swaggerInfo);
            Container.Register<IMasterRepository, MasterRepository>();
            Container.Register<IMasterManager, MasterManager>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var swaggerDescription = string.Format("{0} {1}", "Master Service", "v1");

            ConfigureBase(app, env, "/swagger/v1/swagger.json", swaggerDescription);

            var builder = new ConfigurationBuilder();

            builder.SetBasePath(env.ContentRootPath);
            foreach (var file in settingsFile)
            {
                builder.AddJsonFile(file, reloadOnChange: true, optional: false);
            }

            Configuration = builder.Build();
        }
    }
}

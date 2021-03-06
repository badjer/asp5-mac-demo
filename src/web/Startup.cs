using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;

namespace Asp5MacDemo.Web
{
    public class Startup
    {
        public static IConfiguration Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            Configuration = new Configuration().AddJsonFile("config.json")
                .AddEnvironmentVariables();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseMvc(routes => {
                // This is the default route template - a regular
                // convention-based router.
                // NOTE: You can use attribute-based routing alongside
                // this - see GreetController for an example
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new {controller = "Hello", action = "World" });
            });
            app.UseWelcomePage();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Fiver.Mvc.TagHelpers.Custom.Models.Home;

namespace Fiver.Mvc.TagHelpers.Custom
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddScoped<IGreetingService, GreetingService>();
            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

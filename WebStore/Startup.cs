using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrastructure.Conventions;
using WebStore.Infrastructure.Services;
using WebStore.Infrastructure.Services.Interfaces;

namespace WebStore
{
    public record Startup(IConfiguration Configuration)
    {
        //public IConfiguration Configuration { get; }
        //public Startup(IConfiguration Configuration)
        //{
        //    this.Configuration = Configuration;
        //}
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddTransient<IEmployeesData, InMemoryEmployeesData>();

            services
                .AddControllersWithViews( 
                mvc => 
                {
                    //mvc.Conventions.Add(new ActionDescriptionAttribute("123"));
                    mvc.Conventions.Add(new ApplicationConvention());
                })
                .AddRazorRuntimeCompilation();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env/*, IConfiguration config*/)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            //var greetings = Configuration["Greetings"];
            //app.Map()

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Greetings", async context =>
                {
                    await context.Response.WriteAsync(Configuration["Greetings"]);
                });

                //endpoints.MapDefaultControllerRoute();
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

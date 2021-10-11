using coreAdvanceConcepts.Middlewares;
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

namespace coreAdvanceConcepts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.UseCustomMiddleware();

            // Middleware A:
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middlware A (Before) => ");
            //    await next();
            //    await context.Response.WriteAsync("Middlware A (After)");
            //});

            // Middleware B:
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Middlware B (Before) => ");
            //    await next();
            //    await context.Response.WriteAsync("Middlware B (After) => ");
            //});

            // Middleware C:
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Middlware C => ");
            });



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}

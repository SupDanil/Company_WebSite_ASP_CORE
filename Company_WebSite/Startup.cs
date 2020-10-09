using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Company_WebSite
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            // Добовляем поддержку контроллеров и представлений (MVC)
            services.AddControllersWithViews()
            // Выстовляем совместимость с ASP.net CORE 3.0
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();


        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            
            app.UseRouting();

            // Подключаем поддержку статичных файлов
            app.UseStaticFiles();
            // Регестрируем нужные маршруты (EndPoits) 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute("default", "{controller = Home}/{action = Index}/{id?}");
            //});
        }
    }
}

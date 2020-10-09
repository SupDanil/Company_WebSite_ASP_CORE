using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company_WebSite.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Company_WebSite
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            // ��������� ������ �� appsettingconfig.json
            Configuration.Bind("Project", new Config());
            // ��������� ��������� ������������ � ������������� (MVC)
            services.AddControllersWithViews()
            // ���������� ������������� � ASP.net CORE 3.0
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();



        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            
            app.UseRouting();

            // ���������� ��������� ��������� ������
            app.UseStaticFiles();
            // ������������ ������ �������� (EndPoits) 

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

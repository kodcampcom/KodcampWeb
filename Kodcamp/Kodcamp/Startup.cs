using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kodcamp.Hubs;

namespace Kodcamp
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
            // SignalR
            services.AddCors(options => options.AddDefaultPolicy(policy=>
            policy.AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
            .SetIsOriginAllowed(origin => true)
            ));
            services.AddControllersWithViews();
            //services.AddControllersWithViews().AddRazorRuntimeCompilation(); // <PropertyGroup>
            services.AddSignalR();

            //Session
            services.AddSession();

            //Swagger
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gokalp Swagger", Version = "v1" });
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/");
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/Error", "?code={0}"); // Hata durumunda 404 sayfasına yönlendir.

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession(); // Session

            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<MyHub>("/myhub"); // Bu sadece trigger edilen alan. Böyle bir sayfa açma. Buna ulaşıp gidebilirsin. Sadece bunun yolunu vermen gerekli.
                endpoints.MapHub<MyHub>("/myhub/programlama");
                endpoints.MapHub<MyHub>("/myhub/isletimsistemleri");
                endpoints.MapHub<MyHub>("/myhub/donanim");
            });

            // Swagger için Swashbuckle.AspNetCore dll yüklenecek terminal ile
            //app.UseSwagger();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            //});
        }
    }
}

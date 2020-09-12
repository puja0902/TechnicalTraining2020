using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using PatientLibrary;

namespace MVCwithWillis
{
    public class Startup
    {
        public Startup(IConfiguration configuration) // constructor
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime.
        //Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            IdentityModelEventSource.ShowPII = true;
            services.AddCors(o => o.AddPolicy("MyCorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            }));

            services.AddMvc();
            services.AddDbContext<HospitalDbContext>(
                options =>
                {
                    options.UseSqlServer(Configuration["ConnectionStrings"]);
                }
                );

            services.AddSingleton<IPatient, Patient>();
            //services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromSeconds(60);
            //    options.Cookie.HttpOnly = true;
            //    options.Cookie.IsEssential = true;
            //});
            services.AddControllersWithViews();


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer ="Puja",
                    ValidAudience = "Puja",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("PujaSharma123456@0902"))
                };
            });
            services.AddMvc();
        }

        // This method gets called by the runtime. 
        //Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<SecurityCheck>(); //1
            app.UseMiddleware<Logging>(); //2
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
           
            app.UseRouting();
            app.UseCors("MyCorsPolicy");
            app.UseAuthentication();
            app.UseAuthorization();
            
            //app.UseSession();
            app.UseEndpoints(endpoints =>
            {

            // loaded from databases
            // Dynamically from DB
              //endpoints.MapControllerRoute(name: "Home",
              //pattern: "",
              //defaults: new { controller = "Patient", action = "Add" });

              //  endpoints.MapControllerRoute(name: "Patient",
              // pattern: "Patient/New",
              // defaults: new { controller = "Patient", action = "Add" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

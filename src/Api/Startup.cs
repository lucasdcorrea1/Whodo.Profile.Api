using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using Whodo.Profile.Api.Infrastructure.IoC;

namespace Whodo.Autentication.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ServiceProvider ServiceProvider { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            #region Cors
            services.AddCors(options =>
            {
                options.AddPolicy("SiteCorsPolicy", builder => builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true)
                    .AllowCredentials());
            });
            #endregion

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Whodo.Profile",
                        Version = "v 1.0",
                        Description = "Whodo.Profile API",
                        Contact = new OpenApiContact
                        {
                            Name = "Whodo.Profile",
                            Email = "lucas.dcorrea1@gmail.com",
                            Url = new Uri("https://localhost/profile")
                        }
                    });
            });
            #endregion

            services.AddControllers();
            services.Inject();

            ServiceProvider = services.BuildServiceProvider();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("SiteCorsPolicy");

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Whodo.Profile v1.0");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

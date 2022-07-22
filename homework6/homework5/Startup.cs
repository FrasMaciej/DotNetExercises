using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using homework5.Dtos.Car;
using homework5.Infrastructure;
using homework5.Interfaces;
using homework5.Middlewares;
using homework5.Services;
using homework5.Validators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace homework5
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
            services.AddSingleton<ICarService, CarService>();
            services.AddSingleton<IClientService, ClientService>();

            services.AddAutoMapper(x => x.AddProfile<AutoMapperProfile>(),typeof(Startup).Assembly);

            services.AddControllers();

            services.AddTransient<ErrorHandlingMiddleware>();

            services.AddFluentValidation();
            services.AddTransient < IValidator < CreateCarDto >, CreateCarDtoValidator >();
            services.AddTransient<IValidator<UpdateCarDto>, UpdateCarDtoValidator>();

            var origins = Configuration.GetSection("CorsSettings:AllowedOrigins").Get<string[]>();
            var methods = Configuration.GetSection("CorsSettings:AllowedMethods").Get<string[]>();

            services.AddCors(opt => opt.AddPolicy("DefaultCors", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            }));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "KredekWebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MojeWebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseMiddleware<ErrorHandlingMiddleware>();

            app.UseCors("DefaultCors");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            var cultureInfo = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }
    }
}

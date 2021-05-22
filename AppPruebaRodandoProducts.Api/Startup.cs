using AppPruebaRodandoProducts.Api.Application;
using AppPruebaRodandoProducts.Api.ApplicationService;
using AppPruebaRodandoProducts.Api.Domain;
using AppPruebaRodandoProducts.Api.DomainService;
using AppPruebaRodandoProducts.Api.Infrastructure.Entities;
using AppPruebaRodandoProducts.Api.Infrastructure.Repositories.IRepositoriesGeneric;
using AppPruebaRodandoProducts.Api.Infrastructure.Repositories.RepositoriesGeneric;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppPruebaRodandoProducts.Api
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AppPruebaRodandoProducts.Api", Version = "v1" });
            });
            
            services.AddSingleton<IClienteApplication, ClienteApplication>();
            services.AddSingleton<IClienteDomain, ClienteDomain>();
            //services.AddSingleton<IClienteRepository, ClienteRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AppPruebaRodandoProducts.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EverExpTimesheetAPI.DataContext.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using EverExpTimesheetAPI.LoggerConfiguration;
using EverExpTimesheetAPI.ViewModel.ViewModel;
using EverExpTimesheetAPI.ViewModel;
using EverExpTimesheetAPI.ExceptionHandling;

namespace EverExpTimesheetAPI
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
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EverExpTimesheetAPI", Version = "v1" });
            });
            services.AddDbContext<TimesheetContext>(c =>
            c.UseSqlServer(Configuration.GetConnectionString("SqlServerConnectionString"), options => options.EnableRetryOnFailure()));
            DependencyInjection.DependenceInjectionContainer.DBContainer.Injector(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EverExpTimesheetAPI v1"));
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


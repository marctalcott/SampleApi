﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SampleSolution.Data;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.OpenApi.Models;
using SampleSolution.DataAccess;
using SampleSolution.Services;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace SampleSolution.SampleAPI
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
            var dbConnectionString = Configuration["ConnectionStrings:SampleDb"];
            
            
            services.AddDbContext<SampleDbContext>(options =>
                options.UseSqlServer(
                    dbConnectionString));
            
            // You can move this out to another class as it starts to grow, and just call it from here.
            //Setup Dependency Injection
            //Services
            services.AddTransient<IBankBranchService, BankBranchService>();
            services.AddTransient<IBankBranchDataAccess, BankBranchDataAccess>();
            
            
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper(typeof(Startup));
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c => {  c.SwaggerDoc("v1", 
                new OpenApiInfo { Title = "My API", Version = "v1" });});

            //make sure AddCors is last in this function,
            // there is a 2nd part of this in Configure.
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials()
                        .Build());
            });

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("CorsPolicy"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
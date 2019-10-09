using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using InfoClients.Api.Domain.Data;
using Microsoft.EntityFrameworkCore;
using InfoClients.Api.Domain.Services;

namespace InfoClients.Api
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
            services.AddDbContext<InfoClientsContext>(x=> x.UseSqlServer(Configuration.GetConnectionString("InfoClientsDbConnection")));

            services.AddTransient<IInfoClientService, InfoClientService>();
            services.AddTransient<ILocationService, LocationService>();

            services.AddSwaggerGen(c =>
            {
                c.DescribeStringEnumsInCamelCase();
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "InfoClients API",
                    Description = "Endpoints to manage the InfoClients information.",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Hugo Rodríguez",
                        Email = "harf2310@gmail.com"
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "InfoClients API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

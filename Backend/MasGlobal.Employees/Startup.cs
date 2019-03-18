using MasGlobal.Contracts;
using MasGlobal.Factory;
using MasGlobal.Factory.Creator;
using MasGlobal.Model;
using MasGlobal.Service.Layers;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using RestSharp;

namespace MasGlobal.Employees
{
    public class Startup
    {

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOData();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IEmployeeMapper, EmployeeMapper>();
            services.AddTransient<IFacade, Facade>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IApiEmployeeClient, ApiEmployeeClient>();
            services.AddTransient<IRestClient, RestClient>();
            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(builder =>
                   builder.WithOrigins("*")
                       .AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(b =>
            {
                b.MapODataServiceRoute("odata", "odata", GetEdmModel());
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Working on it!");
            });
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Employee>("Employees");
            var employeeSet = builder.EntitySet<Employee>("Employees");
            employeeSet.EntityType.Count().Filter().OrderBy().Expand().Select();

            return builder.GetEdmModel();
        }
    }
}

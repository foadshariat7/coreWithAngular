using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basicAPI.Entities;
using basicAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace basicAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDb2;Integrated Security=True;";
            services.AddDbContext<CompanyContext>(o => o.UseSqlServer(connectionString));
            services.AddScoped<ICompanyRepository, CompanyRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, CompanyContext companyContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            companyContext.EnsureSeedDataForContext();

            app.UseMvc();
        }
    }
}

using System.Text;
using AutoMapper;
using Fasitec.Data;
using Fasitec.Data.Mapping;
using Fasitec.Data.Repositories;
using Fasitec.Data.Unities;
using Fasitec.Api.Config;
using Fasitec.Business.ApplicationServices;
using Fasitec.Business.Entities;
using Fasitec.Business.Repositories;
using Fasitec.Business.Unities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Service.Repositories;

namespace Fasitec.Api
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
            services.AddDbContext<Context>(opt => opt.UseSqlServer(Configuration
             .GetConnectionString("DefaultConnection"),
              i => i.MigrationsAssembly("Fasitec.Api")));
            
            services.AddAutoMapper(typeof(MappingConfig));   
              
            services.ResolveDependencies();

            services.AddControllers();     

            services.AddAuthentication();               
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

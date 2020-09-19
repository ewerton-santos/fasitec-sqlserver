using Fasitec.Business.ApplicationServices;
using Fasitec.Business.Entities;
using Fasitec.Business.Repositories;
using Fasitec.Business.Unities;
using Fasitec.Data;
using Fasitec.Data.Repositories;
using Fasitec.Data.Unities;
using Microsoft.Extensions.DependencyInjection;
using Service.Repositories;

namespace Fasitec.Api.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {            
            services.AddScoped<Context, Context>();                        
            
            //Users
            services.AddScoped<IRepository<User>, Repository<User>>();   
            services.AddScoped<IUserRepository, UserRepository>();            
            services.AddScoped<IUserFacade, UserService>(); 
            
            //Parcela
            services.AddScoped<IRepository<Parcela>, Repository<Parcela>>();
            services.AddScoped<IParcelaRepository, ParcelaRepository>();   
            services.AddScoped<IParcelaFacade, ParcelaService>(); 
            
            //Contrato
            services.AddScoped<IRepository<Contrato>, Repository<Contrato>>();
            services.AddScoped<IContratoRepository, ContratoRepository>();   
            services.AddScoped<IContratoFacade, ContratoService>(); 
            
            
            services.AddScoped<IUnitOfWork, UnitOfWork>(); 

            return services; 
        }
    }
}
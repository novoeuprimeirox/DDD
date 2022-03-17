using Domain.Interfaces.Generics;
using Domain.Interfaces.IServices;
using Domain.Services;
using Infrastructure.Repository.Generics;
using Microsoft.Extensions.DependencyInjection;

namespace HelpConfig
{
    public class HelpStartup
    {
        public static void ConfigureSingleton(IServiceCollection services)
        {
            // INTERFACE E REPOSITORIO
            services.AddScoped<IRepository, RepositoryGenerics>();
           // services.AddScoped<IEmpresaServices, ServiceEmpresa>();

            // SERVIÇO DOMINIO
            //   services.AddSingleton<IRepository, ServiceEmpresa>();

        }
    }
}

using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using PastelAPISolution.Application.Service.Interfaces;
using PastelAPISolution.Application.Service.Services;
using PastelAPISolution.Domain.Interfaces.Data;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Services;
using PastelAPISolution.Infra.Data.Repositories;

namespace PastelAPISolution.Infra.IoC.Register
{
   public class IoCManager
    {


        public static void ConfigureServices(IServiceCollection services)
        {
            //domain
            services.AddScoped<IProdutoDomainService, ProdutoDomainService>();
            services.AddScoped<IPedidoItemDomainService, PedidoItemDomainService>();
            services.AddScoped<IPedidoDomainService, PedidoDomainService>();
            services.AddScoped<IClienteDomainService, ClienteDomainService>();

            //repository
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoItemRepository, PedidoItemRepository>();
            services.AddScoped<IClientRepository, ClienteRepository>();

            //Services
            services.AddScoped<IProdutoApplicationService, ProdutoApplicationService>();
            services.AddScoped<IPedidoApplicationService, PedidoApplicationService>();
            services.AddScoped<IClienteApplicationService, ClienteApplicationService>();
        }
    }
}

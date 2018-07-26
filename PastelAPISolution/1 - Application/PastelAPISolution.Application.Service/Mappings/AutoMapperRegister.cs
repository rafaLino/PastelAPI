

using AutoMapper;
using PastelAPISolution.Application.Service.Inputs;
using PastelAPISolution.Application.Service.ViewModels;
using PastelAPISolution.Domain.Models;

namespace PastelAPISolution.Application.Service.Mappings
{
   public static class AutoMapperRegister
    {
        public static void Register()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteViewModel>();
                cfg.CreateMap<Produto, ProdutoViewModel>();
                cfg.CreateMap<Pedido, PedidoViewModel>();

                cfg.CreateMap<ClienteViewModel, Cliente>();
                cfg.CreateMap<ProdutoViewModel, Produto>();
                cfg.CreateMap<PedidoViewModel, Pedido>();


                cfg.CreateMap<Cliente, ClienteInput>();
                cfg.CreateMap<Produto, ProdutoInput>();
                cfg.CreateMap<Pedido, PedidoInput>();


                cfg.CreateMap<ClienteInput, Cliente>();
                cfg.CreateMap<ProdutoInput, Produto>();
                cfg.CreateMap<PedidoInput, Pedido>();



            });
        }
    }
}

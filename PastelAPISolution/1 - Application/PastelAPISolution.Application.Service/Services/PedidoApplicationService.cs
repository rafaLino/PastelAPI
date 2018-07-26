using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using PastelAPISolution.Application.Service.Inputs;
using PastelAPISolution.Application.Service.Interfaces;
using PastelAPISolution.Application.Service.ViewModels;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Models;


namespace PastelAPISolution.Application.Service.Services
{
    public class PedidoApplicationService : ApplicationServiceBase<Pedido, PedidoViewModel, PedidoInput>, IPedidoApplicationService
    {
        private IPedidoDomainService _pedidoDomainService;

        private IPedidoItemDomainService _pedidoItemDomainService;
        public PedidoApplicationService(IPedidoDomainService domainService, IPedidoItemDomainService pedidoItemDomainService) : base(domainService)
        {
            _pedidoDomainService = domainService;
            _pedidoItemDomainService = pedidoItemDomainService;
        }

        public override async Task<int> AddAsync(PedidoInput input)
        {
            var entity = Mapper.Map<Pedido>(input);
            
            int id = await _pedidoDomainService.AddAsync(entity);

            foreach (var item in input.Pedidos.Itens)
            {
                await _pedidoItemDomainService.AddAsync(new PedidoItem(id, item.ProdutoId));
            }
            return id;
        }

        public async override Task<IEnumerable<PedidoViewModel>> GetAsync()
        {
            var pedidos = await _pedidoDomainService.GetAsync();

            var pedidoViewModelList = Mapper.Map<IEnumerable<PedidoViewModel>>(pedidos);


            foreach (var pedidoViewModel in pedidoViewModelList)
            {
                var pedidoItens = await _pedidoItemDomainService.GetByPedidos(pedidoViewModel.Id);

                pedidoViewModel.Pedidos = Mapper.Map<IEnumerable<PedidoItemViewModel>>(pedidoItens);
            }

            return pedidoViewModelList;

        }

        public async override Task<PedidoViewModel> GetAsync(int id)
        {
            var entityViewModel = await base.GetAsync(id);
            var pedidoItens = await _pedidoItemDomainService.GetByPedidos(entityViewModel.Id);

            entityViewModel.Pedidos = Mapper.Map<IEnumerable<PedidoItemViewModel>>(pedidoItens);

            return entityViewModel;
        }

    }
}

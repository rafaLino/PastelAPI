using System.Collections.Generic;
using System.Threading.Tasks;
using PastelAPISolution.Domain.Interfaces.Data;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Models;

namespace PastelAPISolution.Domain.Services
{
    public class PedidoItemDomainService : DomainServiceBase<PedidoItem>, IPedidoItemDomainService
    {
        private IPedidoItemRepository _pedidoItemRepository;
        public PedidoItemDomainService(IPedidoItemRepository repository) : base(repository)
        {
            _pedidoItemRepository = repository;
        }

        public async Task<IEnumerable<PedidoItem>> GetByPedidos(int pedidoId)
        {
           return await _pedidoItemRepository.GetByPedidos(pedidoId);
        }
    }
}

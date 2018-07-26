using PastelAPISolution.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastelAPISolution.Domain.Interfaces.Service
{
    public interface IPedidoItemDomainService : IDomainServiceBase<PedidoItem>
    {
        Task<IEnumerable<PedidoItem>> GetByPedidos(int pedidoId);
    }
}

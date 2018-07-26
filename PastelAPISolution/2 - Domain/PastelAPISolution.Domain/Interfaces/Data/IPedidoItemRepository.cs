using PastelAPISolution.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PastelAPISolution.Domain.Interfaces.Data
{
    public interface IPedidoItemRepository : IRepositoryBase<PedidoItem>
    {

        Task<IEnumerable<PedidoItem>> GetByPedidos(int pedidoId);
    }
}

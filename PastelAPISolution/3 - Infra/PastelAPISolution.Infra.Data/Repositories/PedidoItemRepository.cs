using System.Data.SqlClient;
using System.Threading.Tasks;
using PastelAPISolution.Domain.Interfaces.Data;
using PastelAPISolution.Domain.Models;
using DapperExtensions;
using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace PastelAPISolution.Infra.Data.Repositories
{
   public class PedidoItemRepository : RepositoryBase<PedidoItem>, IPedidoItemRepository
    {
        public async Task<IEnumerable<PedidoItem>> GetByPedidos(int pedidoId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var list = await connection.GetListAsync<PedidoItem>();

                return list.Where(pedidoItem => pedidoItem.PedidoId == pedidoId);

            }
        }

    }
}

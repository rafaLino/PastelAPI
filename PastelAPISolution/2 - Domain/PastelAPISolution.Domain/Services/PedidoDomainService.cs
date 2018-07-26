using System;
using System.Threading.Tasks;
using PastelAPISolution.Domain.Interfaces.Data;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Models;

namespace PastelAPISolution.Domain.Services
{
    public class PedidoDomainService : DomainServiceBase<Pedido>, IPedidoDomainService
    {
        public PedidoDomainService(IPedidoRepository repository) : base(repository)
        {
 
        }

    }
}

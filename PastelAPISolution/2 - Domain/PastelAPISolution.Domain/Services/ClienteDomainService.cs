using PastelAPISolution.Domain.Interfaces.Data;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Models;

namespace PastelAPISolution.Domain.Services
{
    public class ClienteDomainService : DomainServiceBase<Cliente>, IClienteDomainService
    {
        public ClienteDomainService(IClientRepository repository) : base(repository)
        {
        }
    }
}

using PastelAPISolution.Application.Service.Inputs;
using PastelAPISolution.Application.Service.Interfaces;
using PastelAPISolution.Application.Service.ViewModels;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Models;

namespace PastelAPISolution.Application.Service.Services
{
    public class ClienteApplicationService : ApplicationServiceBase<Cliente, ClienteViewModel, ClienteInput>, IClienteApplicationService
    {
        public ClienteApplicationService(IClienteDomainService domainService) : base(domainService)
        {
        }
    }
}

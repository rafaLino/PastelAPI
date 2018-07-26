using PastelAPISolution.Domain.Interfaces.Data;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Models;

namespace PastelAPISolution.Domain.Services
{
    public class ProdutoDomainService : DomainServiceBase<Produto>, IProdutoDomainService
    {
        public ProdutoDomainService(IProdutoRepository repository) : base(repository)
        {
        }
    }
}

using PastelAPISolution.Application.Service.Inputs;
using PastelAPISolution.Application.Service.Interfaces;
using PastelAPISolution.Application.Service.ViewModels;
using PastelAPISolution.Domain.Interfaces.Service;
using PastelAPISolution.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PastelAPISolution.Application.Service.Services
{
    public class ProdutoApplicationService : ApplicationServiceBase<Produto, ProdutoViewModel, ProdutoInput>, IProdutoApplicationService
    {
        public ProdutoApplicationService(IProdutoDomainService domainService) : base(domainService)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PastelAPISolution.Application.Service.ViewModels
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }

        public string Nome { get; private set; }

        public double Valor { get; private set; }
    }
}

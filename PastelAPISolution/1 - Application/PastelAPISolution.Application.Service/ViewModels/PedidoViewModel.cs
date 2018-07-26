using System;
using System.Collections;
using System.Collections.Generic;

namespace PastelAPISolution.Application.Service.ViewModels
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        public int Quantidade { get; set; }

        public DateTime Data { get; set; }

        public IEnumerable<PedidoItemViewModel> Pedidos { get; set; }
    }
}

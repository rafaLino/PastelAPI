using System;
using System.Collections.Generic;

namespace PastelAPISolution.Application.Service.Inputs
{
    public class PedidoInput
    {
        public int ClientId { get; set; }

        public int Quantidade { get; set; }

        public PedidoItemInput Pedidos { get; set; }

        
    }

}

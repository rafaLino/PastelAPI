

using System.Collections.Generic;

namespace PastelAPISolution.Application.Service.Inputs
{
   public class PedidoItemInput
    {
        public List<ChavePedidoItem> Itens { get; set; }


        public PedidoItemInput()
        {
            Itens = new List<ChavePedidoItem>();
        }

    }


    public class ChavePedidoItem
    {


        public int ProdutoId { get; set; }
    }

}

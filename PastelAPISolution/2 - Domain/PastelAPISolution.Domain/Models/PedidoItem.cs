using PastelAPISolution.Domain.Core.Models;

namespace PastelAPISolution.Domain.Models
{
    public  class PedidoItem : Entity
    {
        public int PedidoId { get; private set; }

        public int ProdutoId { get; private set; }

        private PedidoItem()
        {

        }

        public PedidoItem(int pedidoId, int produtoId)
        {
            PedidoId = pedidoId;
            ProdutoId = produtoId;
        }

        
        public void Update(PedidoItem input)
        {
            PedidoId = input.PedidoId;
            ProdutoId = input.ProdutoId;
        }
    }
}

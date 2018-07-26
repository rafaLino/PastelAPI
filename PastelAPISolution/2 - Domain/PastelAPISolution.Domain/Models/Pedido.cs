using PastelAPISolution.Domain.Core.Models;
using System;

namespace PastelAPISolution.Domain.Models
{
    public class Pedido : Entity
    {

        public int ClientId { get; private set; }

        public int Quantidade { get; private set; }

        public DateTime Data { get; private set; }


        private Pedido()
        {

        }

        public Pedido(int clientId, int quantidade)
        {
            ClientId = clientId;
            Quantidade = quantidade;
            Data = DateTime.Now;
        }

        public void Update(Pedido input)
        {
            ClientId = input.ClientId;
            Quantidade = input.Quantidade;
            Data = input.Data;
        }
        
    }
}

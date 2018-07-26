
using PastelAPISolution.Domain.Core.Models;

namespace PastelAPISolution.Domain.Models
{
    public class Cliente : Entity
    {

        public string Nome { get; private set; }


        private Cliente()
        {

        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

      
        public void Update(Cliente input)
        {
            Nome = input.Nome;
        }

        
    }
}


using PastelAPISolution.Domain.Core.Models;

namespace PastelAPISolution.Domain.Models
{
   public class Produto : Entity
    {

        public string Nome { get; private set; }

        public double Valor { get; private set; }




        private Produto()
        {

        }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }


        public void Update(Produto input)
        {
            Nome = input.Nome;
            Valor = input.Valor;
        }
    }
}

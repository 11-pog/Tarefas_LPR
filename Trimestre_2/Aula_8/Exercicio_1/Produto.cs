using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Produto
    {
        public string Nome;
        public float Preco;
        public uint Quantidade;

        public int Codigo { get; private set; }

        public Produto(string nome, float preco, uint quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

            Codigo = Nome.GetHashCode();
        }

        public float GetStockPrice() => Preco * Quantidade;
    }
}

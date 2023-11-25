using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Produto
    {
        public string Nome { get; set; }
        private double _preco;
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this._preco = preco;
        }

        public double Preco
        {
            get => _preco;

            set
            {
                if (value > 0)
                {
                    _preco = value;
                }
            }
        }
    }
}

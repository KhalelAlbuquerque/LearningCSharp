using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Qtd { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int qtd)
        {
            _nome = nome;
            Preco = preco;
            Qtd = qtd;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }



        public double ValorTotalEmEstoque()
        {
            return Preco * Qtd;
        }

        public void AddQtd(int qtdAdd)
        {
            this.Qtd += qtdAdd;
        }

        public void RemQtd(int qtdRem)
        {
            this.Qtd -= qtdRem;
        }

        public override string ToString()
        {
            return _nome + ", $ " + Preco + ", Qtd: " + Qtd + ", Total: $ " + this.ValorTotalEmEstoque();
        }
    }
}

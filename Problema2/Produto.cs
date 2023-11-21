using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public Produto() {
            Qtd = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int qtd) : this(nome, preco)
        {
            int Qtd = qtd;
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
            return Nome + ", $ " + Preco + ", Qtd: " + Qtd + ", Total: $ " + this.ValorTotalEmEstoque();
        }
    }
}

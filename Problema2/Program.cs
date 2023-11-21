using System;
using System.Globalization;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            double preco;
            int qtd;

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            qtd = int.Parse(Console.ReadLine());


            Produto produto = new Produto(nome, preco, qtd);
            Produto p3 = new Produto { Nome = "TV", Preco = 20.0, Qtd = 20, };

            Console.WriteLine("Seu produto: " + produto);

            Console.Write("Digite a quantidade a ser acrescentada: ");
            int qtdAdd = int.Parse(Console.ReadLine());

            produto.AddQtd(qtdAdd);
            Console.WriteLine("Seu produto novo: " + produto);

            Console.Write("Digite a quantidade a ser reduzida: ");
            int qtdRem = int.Parse(Console.ReadLine());

            produto.RemQtd(qtdRem);
            Console.WriteLine("Seu produto novo: " + produto);

        }
    }
}
using System;
using System.Globalization;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {


            Console.Write("Digite o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                Produto produto = new Produto(nome, preco);

                produtos[i] = produto;
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += produtos[i].Preco;
            }

            double avg = sum / n;

            Console.WriteLine("PRECO MEDIO: " + avg.ToString("F2"), CultureInfo.InvariantCulture);



        }
    }
}
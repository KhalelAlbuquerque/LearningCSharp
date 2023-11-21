using System;
using System.Globalization;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 200, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "Kasda";
            Console.WriteLine(p.Nome);

        }
    }
}
using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite os lados do triangulo: ");
            Console.Write("Lado 1: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 2: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado 3: ");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Triangulo triangulo = new Triangulo();
            triangulo.A = n1;
            triangulo.B = n2;
            triangulo.C = n3;

            Console.WriteLine(triangulo.Area());
            Console.WriteLine(triangulo.ToString());
        }
    }
}
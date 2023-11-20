using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite três números:");
            Console.Write("Número 1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Número 3: ");
            int n3 = int.Parse(Console.ReadLine());

            double result = Maior(n1, n2, n3);
            Console.WriteLine(result);
        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if(a>b && a > c)
            {
                m = a;
            }else if(b > a && b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }
    }
}
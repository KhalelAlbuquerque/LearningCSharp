using MontlyInstallments.Entities;
using System.Globalization;

namespace MontlyInstallments
{
    class MontlyInstallments
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");

            Console.WriteLine();
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Date (dd/MM/yyyy): ");
            DateOnly date = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Contract value: ");
            double valorTotal = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contrato = new Contract(number ,date, valorTotal, numberInstallments);

            Console.WriteLine();
            Console.WriteLine("Installments:");
            contrato.GetInstallments();
        }
    }
}
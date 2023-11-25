using CarRentalWithInterface.Entities;
using CarRentalWithInterface.Services;
using System.Globalization;

namespace CarRentalWithInterface
{
    class CarRentalWithInterface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car rental data: ");

            Console.Write("Car model: ");
            string vehicle = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Finish (dd/MM/yyyy hh:mm): ");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Enter price per day: ");
            double hour = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(start, end, new Vehicle(vehicle));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
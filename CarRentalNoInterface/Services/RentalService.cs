using System.Globalization;
using CarRentalNoInterface.Entities;

namespace CarRentalNoInterface.Services
{
    internal class RentalService
    {
        public double PriceHour { get; private set; }
        public double PriceDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double priceHour, double priceDay)
        {
            PriceHour = priceHour;
            PriceDay = priceDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.End.Subtract(carRental.Start);

            double basicPayment = 0;
            if(duration.TotalHours <= 12)
            {
                basicPayment = PriceHour * Math.Ceiling(duration.TotalHours);
            }else
            {
                basicPayment = PriceDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 
        }
    }
}

using System.Globalization;
using CarRentalWithInterface.Entities;

namespace CarRentalWithInterface.Services
{
    internal class RentalService
    {
        public double PriceHour { get; private set; }
        public double PriceDay { get; private set; }

        private ITaxService _taxService;

        public RentalService(double priceHour, double priceDay, ITaxService taxService)
        {
            PriceHour = priceHour;
            PriceDay = priceDay;
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 
        }
    }
}

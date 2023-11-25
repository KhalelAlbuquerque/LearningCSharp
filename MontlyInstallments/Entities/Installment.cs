using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace MontlyInstallments.Entities
{
    class Installment
    {
        public DateOnly _dueDate { get; private set; }
        public double _amount { get; private set; }

        public Installment(DateOnly date, double amount, int number)
        {
            _dueDate = date;
            _amount = ApplyFee(amount, number);
        }

        static double ApplyFee(double amount, int number)
        {
            double montlyFee = amount + (amount * (number / 100.0));
            double fixFee = montlyFee + (montlyFee * (2 / 100.0));
            return fixFee;
        }

        public override string ToString()
        {
            return this._dueDate + " - " + this._amount.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

namespace MontlyInstallments.Entities
{
    class Contract
    {
        public int Number { get; }
        public DateOnly Date { get; }
        public double TotalValue { get; }
        public int InstallmentsNumber { get; }

        public Contract(int number, DateOnly date, double totalvalue, int installmentsNumber)
        {
            Number = number;
            Date = date;
            TotalValue = totalvalue;
            InstallmentsNumber = installmentsNumber;
        }

        public void GetInstallments()
        {
            double simpleInstallment = TotalValue / InstallmentsNumber;

            for(int i = 1; i <= InstallmentsNumber; i++) {
                DateOnly paymentDay = Date.AddMonths(1);
                Installment parcela = new Installment(paymentDay, simpleInstallment, i);
                Console.WriteLine(parcela.ToString());
            }
        }
    }
}

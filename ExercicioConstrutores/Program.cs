using ExercicioConstrutores;
using System; 

namespace ConstructorExercise
{
    class ConstructorExercise
    {
        static void Main(string[] args)
        {
            string accountNumber;
            string accountOwner;
            char optionDeposit;
            double initialValue;

            Console.Write("Digite o número da conta: ");
            accountNumber = Console.ReadLine();

            Console.Write("Digite o titular da conta: ");
            accountOwner = Console.ReadLine();

            Console.Write("Deseja fazer depósito inicil? (s/n): ");
            optionDeposit = char.Parse(Console.ReadLine());


            Console.Write("Digite o valor de depósito: ");
            initialValue = double.Parse(Console.ReadLine());

            BankAccount userAccount = new BankAccount(accountNumber, accountOwner, initialValue);

            Console.Write(userAccount.ToString());

            Console.Write("Digite o valor de saque: ");
            userAccount.removeValue(double.Parse(Console.ReadLine()));

            Console.WriteLine("Novo valor: " + userAccount.Value);

            Console.Write("Digite o valor de deposito: ");
            userAccount.addValue(double.Parse(Console.ReadLine()));

            Console.WriteLine("Novo valor: " + userAccount.Value);

        }
    }
}
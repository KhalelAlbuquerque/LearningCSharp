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
            double initialValue = 0.0;
            BankAccount conta;

            Console.Write("Digite o número da conta: ");
            accountNumber = Console.ReadLine();

            Console.Write("Digite o titular da conta: ");
            accountOwner = Console.ReadLine();

            Console.Write("Deseja fazer depósito inicil? (s/n): ");
            optionDeposit = char.Parse(Console.ReadLine());


            if(optionDeposit == char.Parse("s") | optionDeposit == char.Parse("S"))
            {
                Console.Write("Digite o valor de depósito: ");
                initialValue = double.Parse(Console.ReadLine());
                conta = new BankAccount(accountNumber, accountOwner, initialValue);
            }
            else
            {
                conta = new BankAccount(accountNumber, accountOwner);
            }

            

            Console.WriteLine(conta.ToString());

            Console.Write("Digite o valor de saque: ");
            conta.removeValue(double.Parse(Console.ReadLine()));

            Console.WriteLine("Novo valor: " + conta.Value);

            Console.Write("Digite o valor de deposito: ");
            conta.addValue(double.Parse(Console.ReadLine()));

            Console.WriteLine("Novo valor: " + conta.Value);

            

        }
    }
}
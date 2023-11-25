using ExercicioQuartos;

namespace Quartos
{
    class Quartos
    {
        static void Main(string[] args)
        {
            Aluno[] quartos = new Aluno[10];


            Console.WriteLine("Quantos quartos serao alugados? ");
            int qty = int.Parse(Console.ReadLine());

            for (int i = 0; i < qty; i++)
            {
                Console.WriteLine("Aluguel #"+(i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                Aluno aluno = new Aluno(nome, email, quarto);

                quartos[quarto - 1] = aluno;
            }

            foreach(Aluno aluno in quartos)
            {
                if (aluno != null)
                {
                    Console.WriteLine(aluno.ToString());
                }
            }
        }
    }
}
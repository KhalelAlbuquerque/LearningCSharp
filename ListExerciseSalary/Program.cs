namespace ListExerciseSalary
{
    class ListExerciseSalary
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantas pessoas vao ser cadastradas: ");
            int n = int.Parse(Console.ReadLine());

            List <Employee> employees = new List <Employee> ();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Funcionario #" + (i + 1));

                Console.Write("Digite o ID do funcionario: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do funcionario: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o salario do funcionario: ");
                double salary = double.Parse(Console.ReadLine());

                Employee empregado = new Employee (id, nome, salary);
                employees.Add(empregado);
            }

            Console.WriteLine("");

            Console.Write("Digite o id do funcionario que vai receber aumento: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem do aumento: ");
            double increasePercentage = double.Parse(Console.ReadLine());

            Employee sortudo = employees.Find(emp => emp.Id == idFuncionario);
            sortudo.increaseSalary(increasePercentage);

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionarios: ");

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
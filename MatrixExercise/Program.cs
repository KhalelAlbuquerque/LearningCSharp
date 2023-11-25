namespace MatrixExercise
{
    class MatrixExercise
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");
            int tamanho = int.Parse(Console.ReadLine());

            int innerCounter = 0;
            int[,] mat = new int[tamanho, tamanho];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Digite o numero [" + i + ", " + j + "] da matriz: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num < 0)
                        innerCounter++;
                    mat[i, j] = num;
                }
            }

            List<int> diagonal = new List<int>();


            Console.WriteLine("Diagonal principal: ");
            for (int i = 0;i < mat.GetLength(0); i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine("");
            Console.Write("Numeros negativos: " + innerCounter);



        }
    }
}
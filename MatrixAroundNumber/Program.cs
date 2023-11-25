namespace MatrixAround
{
    class MatrixAround
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro tamanho da matriz: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo tamanho da matriz: ");
            int second = int.Parse(Console.ReadLine());

            int[,] matrix = new int[first, second];

            for(int i=0; i<matrix.GetLength(0); i++)
            {
                for(int j=0; j<matrix.GetLength(1); j++)
                {
                    Console.Write("Digite o numero [" + i + ", " + j + "] da matriz: ");
                    int number = int.Parse(Console.ReadLine());
                    matrix[i,j] = number;
                }
            }

            Console.WriteLine("");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string linha = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    linha += (matrix[i, j] + " ");
                }
                Console.WriteLine(linha);
            }

            void PrintarArredor(int x, int y)
            {
                Console.WriteLine();
                Console.WriteLine("Ponto " + x + ", " + y + ":");

                //Esquerda
                if (y - 1 >= 0)
                    Console.WriteLine("Esquerda: " + matrix[x, y - 1]);
                //Direita
                if (y + 1 < matrix.GetLength(1))
                    Console.WriteLine("Direita: " + matrix[x, y + 1]);
                //Up
                if (x - 1 >= 0)
                    Console.WriteLine("Cima: " + matrix[x - 1, y]);
                //Down
                if (x + 1 < matrix.GetLength(0))
                    Console.WriteLine("Baixo: " + matrix[x + 1, y]);


            }

            Console.WriteLine();
            Console.Write("Digite o numero que quer comparar: ");
            int sorteado = int.Parse(Console.ReadLine());

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == sorteado)
                    {
                        PrintarArredor(i, j);
                    }
                }
            }
        }
    }
}
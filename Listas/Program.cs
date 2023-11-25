

namespace Listas
{
    class Listas
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Khalel");
            list.Add("Adipo");
            list.Add("Souza");
            list.Add("Albuquerque");
            list.Insert(3, "de");

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LIST COUNT: " + list.Count);
            Console.WriteLine("");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("PRIMEIRO NOME COM A: " + s1);
            int i1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("INDICE PRIMEIRO NOME COM A: "+i1);

            Console.WriteLine("");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("ULTIMO NOME COM A: " + s2);
            int i2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("INDICE ULTIMO NOME COM A: " + i2);


            Console.WriteLine("");
            List<string> listaComA = list.FindAll(x=>x[0] == 'A');
            Console.WriteLine("LISTA NOMES COM A: ");
            foreach(string item in listaComA)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("REMOVENDO ITENS");
            list.Remove("de");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            list.RemoveAll(x => x[0] == 'A');
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");

            list.RemoveAt(0);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }


            list.Add("Khalel");
            list.Add("Adipo");
            list.Add("Souza");
            list.Add("Albuquerque");

            list.RemoveRange(2, 2);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
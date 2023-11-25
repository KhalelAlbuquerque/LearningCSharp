namespace ParamModifier
{
    class ParamModifier
    {
        static void Main(string[] args)
        {
            double numero = Calculator.Calc(2, 56, 123, 55);
            Console.WriteLine(numero);


            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);


            int b = 20;
            int resultado;
            Calculator.Quadruple(b, out resultado);
            Console.WriteLine(resultado);

        }
    }
}
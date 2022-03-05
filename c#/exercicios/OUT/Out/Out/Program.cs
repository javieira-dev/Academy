using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple; //como se trata de uma variavel out, não é necessário declarar
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

        }
    }
}

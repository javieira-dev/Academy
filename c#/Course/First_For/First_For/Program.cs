using System;

namespace First_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quandos numeros inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Oi");
            }
        }
    }
}

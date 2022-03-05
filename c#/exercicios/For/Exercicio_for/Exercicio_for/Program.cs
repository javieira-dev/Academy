using System;

namespace Exercicio_for
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Informe o Valor: ");
            int n = int.Parse(Console.ReadLine());
            

            for (int x = 1; x <= n; x ++)
            {
                if(x % 3 == 0)
                {
                    Console.WriteLine(x);

                }
                
            }

        }
    }
}

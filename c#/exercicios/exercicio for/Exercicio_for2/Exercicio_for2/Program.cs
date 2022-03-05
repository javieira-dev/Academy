using System;

namespace Exercicio_for2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de NUmeros informados: ");
            int qtd    = int.Parse(Console.ReadLine());
            int valor  = 0;
            int dentro = 0;
            int fora   = 0;

            for (int x = 1; x <= qtd; x++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20)
                {
                    dentro = dentro + 1;
                }

                else
                {
                    fora = fora + 1;    
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}

using System;
using System.Globalization;

namespace Exercicio_Wile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2001)
            {
                Console.WriteLine("Senha Incorreta, digite novamente");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha Correta");
                

        }
    }
}

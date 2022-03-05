using System;

namespace Condicao_for
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos numeros você vai digitar?");
        int n = int.Parse(Console.ReadLine());
        int soma = 0;
        int v = 0;
            for (int i = 1; i <= n; i++)
                {
                Console.WriteLine("Valor: #{0} " , i);
                v = int.Parse(Console.ReadLine());
                soma = soma + v;
                }
            Console.WriteLine("A soma é: " + soma);
    }
}
}

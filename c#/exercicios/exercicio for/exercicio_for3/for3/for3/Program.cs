using System;
using System.Globalization;

namespace for3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota = 0;
            double media = 0;
            Console.WriteLine("Informe a quantidade: ");
            int qtd = int.Parse(Console.ReadLine());
            
            for (int i = 1;  i <= qtd; i++)
            {
                nota = Console.ReadLine().Split(' ');
                media = (media + nota) / qtd;
            }

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));



        }
    }
}

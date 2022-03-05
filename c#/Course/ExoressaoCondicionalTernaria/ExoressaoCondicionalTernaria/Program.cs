using System;
using System.Globalization;

namespace ExoressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //expressão condicional ternária
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.5;

            Console.WriteLine(desconto);
            //
            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else { desconto = preco * 0.05; }
            //


        }
    }
}

using System;
using System.Globalization;


namespace ExercMembroEstatico
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.ConverterDolar(quantidade, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

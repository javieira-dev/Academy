using System;
using System.Globalization;

namespace Raio
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();


            Console.WriteLine("Entre o valor do Raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            Console.WriteLine("Circungerência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = calc.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}

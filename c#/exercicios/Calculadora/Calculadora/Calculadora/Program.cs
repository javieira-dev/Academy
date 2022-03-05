using System;
using System.Globalization;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calc.Circunferencia(raio);
            double volume = Calc.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

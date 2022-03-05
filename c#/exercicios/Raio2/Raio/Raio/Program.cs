using System;
using System.Globalization;

namespace Raio
{
    class Program
    {

        static void Main(string[] args)
        {
            //**usando public static significa que você não precisa instanciar o objeto e você pode chamar direto no 'program'


            //Calculadora calc = new Calculadora();


            Console.WriteLine("Entre o valor do Raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circungerência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}

using System;
using System.Globalization;

namespace CalcLadoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;     //declarando a variavel


            //instanciar - variáveis que são do tipo de classe devem ser declaradas e instanciadas;
            x = new Triangulo();
            y = new Triangulo();


            double xa, xb, xc, ya, yb, yc;

            //para acessar o atributo  do objeto

            Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areax = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areay = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("area de x = " + areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("area de y = " + areay.ToString("F4", CultureInfo.InvariantCulture));


            if (areax > areay)
            {
                Console.WriteLine("Maior area x");
            }

            else
            {
                Console.WriteLine("Maior area y");
            }

            

        }
    }
}

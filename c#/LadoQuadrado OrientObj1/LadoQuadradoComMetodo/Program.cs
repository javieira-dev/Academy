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


            //para acessar o atributo  do objeto

            Console.WriteLine("Entre com as medidas do triangulo x: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();
            double areay = y.Area();

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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

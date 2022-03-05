﻿using System;
using System.Globalization;

namespace TRiangulo_InicioOrientacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo y: ");
            yA = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));


            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area X " + areaX);
            }
            else
            {
                Console.WriteLine("Maior área Y " + areaY);
            }
        }
    }
}
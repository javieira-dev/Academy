using System;
using System.Collections.Generic;
using System.Text;

namespace ExercMembroEstatico
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ConverterDolar(double qt, double cot)
        {
            //return ((qt * cot) * Iof / 100.0);

            double total =  (cot * qt);
            return total + total * Iof /100.0;
            //return  total * Iof / 100.0;
        }


    }
}

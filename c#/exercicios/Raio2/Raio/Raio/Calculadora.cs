using System;
using System.Collections.Generic;
using System.Text;

namespace Raio
{
    class Calculadora
    {
        //usando public static significa que você não precisa instanciar o objeto e você pode chamar direto no 'program'
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r;
        }


    }
}

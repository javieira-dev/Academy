using System;
using System.Collections.Generic;
using System.Text;

namespace CalcLadoTriangulo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //como essa função ja esta dentro da classe triangulo e os parametros ja estão aqui,
        //não precisa de mais nenhum dado adicional de entrada
        public double Area() 
        {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
            //ou o return pode ser assim:
            //   return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}

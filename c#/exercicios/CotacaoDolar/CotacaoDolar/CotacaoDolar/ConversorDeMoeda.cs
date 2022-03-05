using System;
using System.Collections.Generic;
using System.Text;

namespace CotacaoDolar
{
    class ConversorDeMoeda
    {
        public static double iof = 6;

        public static double CalculaDolar (double cotacao, double valor)
        {
            double total = (valor * cotacao);
            return total + total * iof / 100;
        }

    }
}

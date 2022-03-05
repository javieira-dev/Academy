using System;
using System.Collections.Generic;
using System.Text;

namespace Modif_parametros
{
    class Calculator
    {
       public static int Sum(params int[] numbers) //usando o params não precisa instanciar o vetor
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}

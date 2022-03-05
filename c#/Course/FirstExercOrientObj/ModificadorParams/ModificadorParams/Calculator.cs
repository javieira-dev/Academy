using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorParams
{
    class Calculator
    {
        public static int Sum(params int[] numbers) //o params significa que ele vai receber um número variável de valores
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


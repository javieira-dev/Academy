﻿using System;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum( 2, 3);            int s2 = Calculator.Sum(2, 4, 3);            //como na classe está definido como PARAMS então não precisa instanciar (parte comentada acima)            Console.WriteLine(s1);            Console.WriteLine(s2);
        }
    }
}

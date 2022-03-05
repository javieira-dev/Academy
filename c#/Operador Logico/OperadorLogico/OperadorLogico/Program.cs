using System;

namespace OperadorLogico
{
    class Program
    {
        static void Main(string[] args)

        {
            //precedencia = !   >   &&     > ||
            bool c1 = 5 != 6;   // true
            Console.WriteLine(c1);

            bool c2 = 5 != 6 && 4 > 6 ;   //false
            Console.WriteLine(c2);

            bool c3 = 5 == 4 || 4 > 5;  //true 
            Console.WriteLine(c3);

            bool c4 = ! (5 > 7);
            Console.WriteLine(c4);

            Console.WriteLine("----------------------------------------------------");

            bool c5 = 10 < 5;
            bool c6 = c1 || c3 && c2;
            Console.WriteLine(c6);
        }
    }
}

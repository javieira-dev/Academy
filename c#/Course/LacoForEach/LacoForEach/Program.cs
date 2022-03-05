using System;

namespace LacoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "BOb" };

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("-----------------------------------");

            foreach(string x  in vect)
            {
                Console.WriteLine(x);
            }


        }
    }
}

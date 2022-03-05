using System;
using System.Collections.Generic;
using System.Globalization;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How Many employess will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>(n);

            foreach (string obj in list)
            {
                Console.Write($"Aluguel# {obj} :");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("");
            Console.Write("Enter the employee id that will have salary increase: ");
            int ids = int.Parse(Console.ReadLine());




        }
    }
}

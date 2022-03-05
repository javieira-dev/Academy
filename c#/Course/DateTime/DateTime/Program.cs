using System;
using System.Globalization;

namespace DateTime2 
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;
            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 000);

            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.Parse("2000-08-15");

            DateTime d55 = DateTime.ParseExact("2000-08-15", "yyyy-mm-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d55);




        }
    }
}

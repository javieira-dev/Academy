using System;

namespace SintaxeAlternativaSwithCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1: day = "Sunday";   break;
                case 2: day = "MOnday";   break;
                case 3: day = "Thursday"; break;
                default: day = "Invalid Value"; break;
            }

            Console.WriteLine("Day: " + day);
        }
    }
}

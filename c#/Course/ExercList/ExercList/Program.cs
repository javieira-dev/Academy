using System;
using System.Collections.Generic;


namespace ExercList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employees> list = new List<Employees>();

            Console.Write("How many employees will be registred? ");
            int func = int.Parse(Console.ReadLine());

            for (int i = 1; i <= func; i++)
            {
                Console.Write("Employees #" + i + ": ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary:  ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searcId = int.Parse(Console.ReadLine());

            Employees s = list.FindLast(x => x.ID == searcId);
            if (s != null)
            {
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine());
                s.increasseSalary(perc);
            }
            else { Console.Write("This ID does not exist! "); }

            Console.WriteLine();

            Console.WriteLine("Updated list of employees: ");
            foreach(Employees x in list)
            {
                Console.WriteLine(x);
            }




        }
    }
}

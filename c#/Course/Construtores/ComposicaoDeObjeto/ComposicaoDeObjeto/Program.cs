using System;
using System.Globalization;
using ComposicaoDeObjeto.Entities.Enums;
using ComposicaoDeObjeto.Entities;

namespace ComposicaoDeObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();
            Console.Write("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MedLevel/Senior):  ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salary Base: ");
            double salaryBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(depName);
            Worker worker = new Worker(name, level, salaryBase, dept);

            Console.Write("How Many Contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int x = 0; x <= n; x++)
            {
                Console.Write("Enter "+ x + " Contract Data: ");
                Console.Write("Date (DD/MM/YYYY) ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por Hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours):  ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.addContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY)  ");

            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year  = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department " + worker.Department.Name);

            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
        
             
        }
    }
}

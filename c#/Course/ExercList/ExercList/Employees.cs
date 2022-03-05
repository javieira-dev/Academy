using System;
using System.Collections.Generic;
using System.Text;

namespace ExercList
{
    class Employees
    {
        public string Name { get; set; }
        public int    ID { get; set; }
        public double Salary { get; private set; }


        public Employees(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }



        public void increasseSalary(double percent)
        {
            Salary += Salary * percent / 100;
        }

        public override string ToString()
        {
            return ID + ", " + Name + ", " + Salary;
        }

    }
}

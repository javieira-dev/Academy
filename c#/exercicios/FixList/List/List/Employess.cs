using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Employess
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Id { get; set; }

        public Employess(string name, double salary, int id)
        {
            Name = name;
            Salary = salary;
            Id = id;
        }

        public void Increase(double prc)
        {
            Salary =  Salary * prc / 100;
        }

        public override string ToString()
        {
            return "Updated list of employess:  "
                + Nome
                + " $"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

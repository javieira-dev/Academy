using System.Collections.Generic;
using ComposicaoDeObjeto.Entities.Enums;


namespace ComposicaoDeObjeto.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contrats { get; set; } = new List<HourContract>();
        //como um trabalhador tem vários contratos, ele será uma lista

        //O construtor abaixo não vai ter a List (contracts) pois não é usual passar uma lista instanciada num construtor de um objeto

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract contract)
        {
            Contrats.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contrats.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contrats)
            {
                if (contract.Date.Year == year && contract.Date.Year == year)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }



    }
}

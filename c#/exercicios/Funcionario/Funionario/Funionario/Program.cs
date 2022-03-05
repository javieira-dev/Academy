using System;
using System.Globalization;

namespace Funionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(f);
            Console.WriteLine();
            Console.Write("Digite a porcentegem de aumento do salario: ");
            double perc = double.Parse(Console.ReadLine());
            f.AumentoSalario(perc);
            Console.WriteLine(f);


        }
    }
}

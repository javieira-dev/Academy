using System;
using System.Globalization;

namespace ExercOrientObjFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar
            Funcionario f1, f2;

            //instanciar
            f1 = new Funcionario();
            f2 = new Funcionario();

            double media;

            Console.WriteLine("Dados do primeiro Funcionario: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionario: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.salario + f2.salario) / 2;

            Console.WriteLine("A Média salarial é: " + media.ToString("F2", CultureInfo.InvariantCulture ));

            //Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));



        }
    }
}

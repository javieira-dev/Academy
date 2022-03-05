using System;
using System.Globalization;

namespace ExercAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno nota = new Aluno();


            Console.Write("Nome do Aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite as Três Notas do Aluno: ");
            nota.Nota1 = int.Parse(Console.ReadLine());
            nota.Nota2 = int.Parse(Console.ReadLine());
            nota.Nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final " + nota);

            if (nota.Aprovado())
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado, faltaram: " + nota.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos.");
            }


        }
    }
}

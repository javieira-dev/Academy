using System;

namespace ExercOrientacaoObj1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando
            Pessoa p1, p2;

            //instanciando
            p1 = new Pessoa();
            p2 = new Pessoa();
            

            Console.WriteLine("Dados da Pessoa 1: ");
            Console.Write("Nome ");
            p1.nome = Console.ReadLine();

            Console.Write("Idade");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Pessoa 2: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa Mais velha é: " + p1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa Mais Velha é: " + p2.nome);
            }


        }
    }
}

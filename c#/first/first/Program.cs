using System;
using System.Globalization;
namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            int n2 = 1000;
            int n3 = 2147483647;
            byte n1 = 254;
            long n4 = 2147483648L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Oliveira";
            object obj1 = "Janaina";
            object obj2 = "teste";
            int n8 = int.MaxValue;

            int idade = 32;
            char genero2 = 'F';
            double saldo = 10.35784;
            string nome2 = "maria";

            Console.WriteLine(x);
            n1++;
            Console.WriteLine(n1);


            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n8);


            Console.WriteLine("bom dia");
            Console.Write("Boa tarde");
            Console.Write("boa noite");
            Console.WriteLine("-------------------------");

            Console.WriteLine(genero2);
            Console.WriteLine(idade);
            Console.WriteLine(nome2);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} e saldo igual a {saldo:F2} reais");

            Console.WriteLine(nome + " tem " + idade +  "anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) +  " reais" );
        }
    }
}

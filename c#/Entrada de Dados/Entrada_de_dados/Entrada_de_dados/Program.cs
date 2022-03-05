using System;
using System.Globalization;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou " + frase);
            Console.WriteLine("Você digitou "+ x +" "+ y +" " + z);*/


            // SPLIT

            /*  string s = Console.ReadLine();
              string[] vet = s.Split(' ');*/
              //pode fazer da forma acima ou da forma abaixo:

         /*   string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Palavra 1: " + p1);
            Console.WriteLine("Palavra 2: " + p2);
            Console.WriteLine("palavra 3: " + p3);
        
        */

            //RECUPERANDO DADO INT

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            


            Console.WriteLine("você digitou: " + n1);
            Console.WriteLine("você digitou: " + ch);
            Console.WriteLine("você digitou: " + d.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Nome: " + nome + " sexo: " + sexo + " idade: "+ idade + " altura: " +  altura);

        }
    }
}

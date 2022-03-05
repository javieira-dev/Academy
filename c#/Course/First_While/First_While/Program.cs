using System;
using System.Globalization;

namespace First_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro Numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número Negativo.");
            */

            //EXERCICIOS WHILE

            /*
            int senha = 2002;

            Console.Write("informe a senha: ");
            int x = int.Parse(Console.ReadLine());

            while (x != senha)
            {
                Console.Write("Senha Inválida   ");
                x = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Acesso Permitido");
            */


            /*
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
            */

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if(tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Muito Obrigada!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}

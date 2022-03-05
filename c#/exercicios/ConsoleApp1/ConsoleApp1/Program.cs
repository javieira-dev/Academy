using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Infomre o produto: ");
            int p = int.Parse(Console.ReadLine());
            int somaalcool = 0;
            int somagasolina = 0;
            int somadiesel = 0;

            while (p != 4)
            {
                if( p == 1){
                    somaalcool = somaalcool + 1;
                    Console.WriteLine("Informe o Produto: ");
                    p = int.Parse(Console.ReadLine());
                }

                else if(p == 2)
                {
                    somagasolina = somagasolina + 1;
                    Console.WriteLine("Informe o Produto: ");
                    p = int.Parse(Console.ReadLine());
                }

                else if (p == 3){
                    somadiesel = somadiesel + 1;
                    Console.WriteLine("Informe o Produto: ");
                    p = int.Parse(Console.ReadLine());
                }

                else 
                {
                    Console.WriteLine("Numero invalido, digite novanemte: ");
                    p = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Resultado: ");
            Console.WriteLine("Gasolina: " + somagasolina);
            Console.WriteLine("Diesel: " + somadiesel);
            Console.WriteLine("Alcool: " + somaalcool);

        }
    }
}

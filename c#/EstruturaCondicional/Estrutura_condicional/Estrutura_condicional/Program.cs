using System;

namespace Estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            Console.WriteLine("Bom dia!");
            
            if (x > 5)
            {
                Console.WriteLine("Boa tarde!");
            }
            Console.WriteLine("Boa noite!");


            //CONDIÇÃO SIMPLES

            Console.WriteLine("Entre com o numero inteiro");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }


            //ENCADEAMENTOS

            Console.WriteLine("Qual a hora");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) 
            {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}

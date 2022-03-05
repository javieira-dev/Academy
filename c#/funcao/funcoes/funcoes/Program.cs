using System;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Três numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior =  " + resultado);

          /*  if(n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior: " + n1 );
            }

            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("Maior: " + n2);
            }

            else
            {
                Console.WriteLine("Maior: " + n3);
            }
            */
            
            
        }
        /////////////USANDO FUNÇÃO
        static int Maior(int a, int b, int c)
        {

            int m;

        if (a > b && a > c)
            {
                m = a;
            }

            else if (b > c && b > a)
            {
                m = b; ;
            }

            else
            {
               m = c;
            }

            return m;


        }
    }
}

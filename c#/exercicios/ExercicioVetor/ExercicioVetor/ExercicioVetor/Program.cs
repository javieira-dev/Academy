using System;

namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {

            Hospedagem[] vect = new Hospedagem[10];

            Console.Write("How many rooms will be rented? ");
            int room = int.Parse(Console.ReadLine());

            for (int i = 1; i <= room; i++)
            {
                Console.Write($"Aluguel# {i} :" );
                Console.Write(" Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Hospedagem ( name, email ) ;
            }

            Console.Write("Busy rooms");
            
            for(int i = 0; i <= 10; i++)
            {
                if (vect[i] != null){
                    Console.WriteLine();
                    Console.WriteLine(i +": " + vect[i]);
                }
            }

        }
    }
}

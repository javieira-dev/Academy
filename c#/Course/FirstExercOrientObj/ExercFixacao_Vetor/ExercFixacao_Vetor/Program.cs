using System;

namespace ExercFixacao_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 9;
            Hospedes[] vect = new Hospedes[total];

            Console.Write("How Many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Rent # " + i +" ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Hospedes { Name = name, Email = email };

            }

            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i <= total; i++)
            {
                if (vect[i] != null) {
                    Console.Write(i + ": " + vect[i]);
                }
            }

        }
    }
}

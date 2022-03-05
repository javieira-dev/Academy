using System;

namespace For_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vect = new string[] { "Maria", "Joao" };
            for (int i = 0; i< vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("------------------------------------------------------"); 

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
                //obj = apelido para cada elemento do vetor, pode ser qqr nome

        }
    }
}

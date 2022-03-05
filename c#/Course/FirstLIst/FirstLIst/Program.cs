using System;
using System.Collections.Generic;

namespace FirstLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("BOb");
            list.Add("Anna");
            list.Insert(2, "Marco");


            List<string> list3 = new List<string>();

            list3.Add("Maria");
            list3.Add("Alex");
            list3.Add("BOb");
            list3.Add("Anna");
           

            foreach (string x in list)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("List Count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            //expressão lambda (função anonima)

            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultima ocorrencia que inicia com a letra A: " + s2);


            //encontrar a primeira e ultima posição de elemento da lista
            Console.WriteLine("===================================================================");
            Console.WriteLine("Encontrar a primeira e ultima posição de elemento da lista");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);


            //Find All
            Console.WriteLine("===================================================================");
            Console.WriteLine("Criando uma nova lista somente com nomes com 5 caracteres");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string x in list2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("====================================================================");

            Console.WriteLine("Removendo Alex");
            list.Remove("Alex");
            foreach(string x in list)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Removendo a Letra M");
            list.RemoveAll(x => x[0] == 'M');
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("=====================================================================");
            Console.WriteLine("Removendo determinada posição");
            list.RemoveAt(0);
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.WriteLine("====================================================================");
            Console.WriteLine("Removendo uma faixa de Valores: ");
            foreach(string obj in list3)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("=====");
            list3.RemoveRange(1, 1);
            foreach(string obj in list3)
            {
                Console.WriteLine(obj);
            }

        }

    }
}

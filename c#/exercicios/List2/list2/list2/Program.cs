using System;
using System.Collections.Generic;
namespace list2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            // o Add por padrão insere no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            // o insert vc pode escolher a posição
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //contar a llista
            Console.WriteLine("List Count "+ list.Count);

            //Encontrar na lista função find
            //quero o objeto X tal que x na posição 0 seja igual ao caractere 'A':
            string s1 = list.Find(x => x[0] == 'A'); 
            //está procurando o primeiro nome que aparece na lista com a letra A
            //a expressão acima é uma expressão lambda que é uma função implicita, ela substitui a função comentada abaixo (a static bool)

            Console.WriteLine("First A: " + s1);

            //ultimo localizado que inicia com A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position 'A': "+ pos2);



            //filtrar na lista:
            //nesse caso, é criada uma nova lista que vai receber as variaveis filtradas

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("======================================================");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remover itens da lista
          /*  list.Remove("Alex");
            Console.WriteLine("======================================================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/
            /*
            list.RemoveAt(2);
            Console.WriteLine("======================================================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/

            /*
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("======================================================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }*/

            // Remover elementos de uma faixa


            list.RemoveRange(2,2);
            Console.WriteLine("======================================================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
        //verdadeiro ou falso
        /* static bool test(string s)
         {
             return s[0] == 'A';
         }*/
    }
}

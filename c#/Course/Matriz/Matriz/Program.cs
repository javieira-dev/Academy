using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine(mat.Rank);//quantidade de linhas


            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));//colunas

        }
    }
}

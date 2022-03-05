using System;
using System.Globalization;


namespace FirstEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.setNome("T");

            Console.WriteLine(p.getNome());

        }
    }
}

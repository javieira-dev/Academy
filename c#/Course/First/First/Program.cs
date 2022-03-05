using System;
using System.Globalization;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "COmputador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.60;
            double media = 53.234567;


            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preco é $ {1} " , produto1, preco1);
            Console.WriteLine("{0}, cujo preço é $ {1} ", produto2, preco2);

            Console.WriteLine();

            Console.WriteLine("Registro: {0} anos de idade, código {1} e genero: {2}", idade, codigo, genero);

            Console.WriteLine();

            Console.WriteLine("Media com oito casas decimais: {0:F8}", media);
            Console.WriteLine("Arredondamento (três casas decimais): {0:F3}", media );
            Console.WriteLine("Separador decimal com invariant culture: {0}", media.ToString("F2", CultureInfo.InvariantCulture));



            //Operadores lógicos



            //


             

            

        }
    }
}

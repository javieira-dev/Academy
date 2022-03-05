using System;
using System.Globalization;

namespace This
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe os dados do Produto: ");
            Console.Write("Nome:  ");
            string nome = Console.ReadLine();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //         Console.Write("Quantidade no Estoque: ");
            //         int Quantidade = int.Parse(Console.ReadLine());

            /////////////////////////////////////////////////////
            Produto p = new Produto(nome, preco);
            ////////////////////////////////////////////////////

            Console.WriteLine("Dados do Produto " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a serem adicionados no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();

            Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }

}

using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.WriteLine("Informe os dados do Produto: ");
            Console.Write("Nome:  ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:"  );
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

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

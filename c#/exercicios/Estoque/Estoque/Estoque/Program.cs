using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.WriteLine("Entre os dados do Produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
            int qt = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qt);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            qt = int.Parse(Console.ReadLine());
            p.RemoverProduto(qt);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}

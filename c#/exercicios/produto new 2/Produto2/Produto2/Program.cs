using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //como foi criado um construtor na casse produto é necessário passar os parametros de entrada para iniciar o programa
            //para isso serão criadas variáveis auxiliares que receberão os dados e posteriormente passarão como parametro 
            //para o construtor
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Console.Write("Quantidade no estoque: ");
            // int quantidade = int.Parse(Console.ReadLine());


            //como na classe só foi criado o construtur com dois e três argumentos ele não aceita o construtor padrão que 
            //é o Produto p = new Produto(), sequiser permitir o construtor padrão, é só criar mais um construtor na classe 
            //sem parâmetro  (parte que deixei comentada na classe);
            Produto p = new Produto(nome, preco);

            Console.WriteLine();

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            
        }
    }
}
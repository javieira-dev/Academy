using System;
using System.Globalization;
namespace exerc_fix_cap_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosBancarios dados;

            Console.Write("Entre com o número da Conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Informe o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? S/N: ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados = new DadosBancarios(conta, titular, depositoInicial);
            }
            else
            {
                dados = new DadosBancarios(conta, titular);
            }

            Console.WriteLine();
            Console.Write("Dados da conta: ");
            Console.WriteLine(dados);

            Console.WriteLine();
            Console.Write("Entre com o valor do deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados da Conta: " + dados);

            Console.WriteLine();
            Console.Write("Entre com os dados para Saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Saque(saque);

            Console.WriteLine();
            Console.Write("Dados atualizados da conta: " + dados);
        }
    }
}

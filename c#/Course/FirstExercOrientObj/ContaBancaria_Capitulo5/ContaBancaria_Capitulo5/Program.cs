using System;
using System.Globalization;
namespace ContaBancaria_Capitulo5
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;
            Console.Write("Entre com o número da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá Depósito Inicial?  ");
            char resposta = char.Parse(Console.ReadLine());

            if(resposta == 'S'  || resposta == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoinicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.Write(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para Deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.Write("Dados Atualizados: " + conta);

            Console.WriteLine();
            Console.Write("Entre com os valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Dados da Conta Atualizados: " + conta);


        }
    }
}

using System;
using System.Globalization;
using ContaBancariaExercicioException.Entities;
using ContaBancariaExercicioException.Entities.Exception;

namespace ContaBancariaExercicioException
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number:  ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder:  ");
            string name = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit:  ");
            double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw:  ");
            double withdraw = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Conta conta = new Conta(number, name, balance, withDrawLimit);

            try
            {
              //  conta.Deposit(balance);
                conta.Withdrown(withdraw);

                Console.WriteLine("New Balance: " + conta.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch(CountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }


        }
    }
}

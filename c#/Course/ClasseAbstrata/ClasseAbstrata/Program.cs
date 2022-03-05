using System;
using ClasseAbstrata.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance; //chamada polimorfica
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }


            ////////////Praticidades mesmo sendo uma classe abstrata
            ///A classe abstrata continua sendo uma generalização
            ///Continua tendo atributos e métodos que continuam sendo aproveitados
            ///E é possível criar uma lista da classe abstrata, de modo que dá pra guardar na lista todos os tipos de elememtos possíveis (Saving Account, Business Account)
            ///E pode fazer chamaas polimorficas de operações que vão ser executadas em todos os elementos

        }
    }
}

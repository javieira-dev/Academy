﻿using System;
using ClasseAbstrata.Entities;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Janaina", 500.0);
            Account acc2 = new SavingAccount(1002, "Maria", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}

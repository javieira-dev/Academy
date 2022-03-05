using System;
using SobreposicaoSobrescrita.Entities;

namespace SobreposicaoSobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount acc1 = new Acount(1001, "Janaina", 500.0);
            Acount acc2 = new SavingAcount(1002, "Maria", 500.00,0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingDownCasting.Entities
{
    class Acount
    {   //para limitar o acesso aos metodos de deposito e saque somente para a subclasse e não para as outras classes, 
        //como por exemplo a program, é só utilzar o modificador de acesso Protected

        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Acount()
        {

        }

        public Acount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}

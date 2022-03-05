using System;
using System.Collections.Generic;
using System.Text;

namespace SobreposicaoSobrescrita.Entities
{
    class Acount
    {

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

        //esse metodo pode ser sobrescrito nas subclasses, usar a palavra Virtual
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0; //taxa de 5.0
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}

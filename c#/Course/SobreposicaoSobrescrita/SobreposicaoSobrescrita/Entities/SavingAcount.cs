using System;
using System.Collections.Generic;
using System.Text;

namespace SobreposicaoSobrescrita.Entities
{
    class SavingAcount : Acount
    {
        public double InterestRate { get; set; }

        public SavingAcount()
        {

        }

        public SavingAcount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }





        //sobrescrever a operação para que ele funcione diferente na classe SavingAcount
        //quando vc reimplementa na subclasse a operação que ja existia na superclasse
        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount; 
        //    //nesse caso não vai descontar os 5 reais
        //}

        //OU

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
            //com a palavra base é possivel reaproveitar a operação da superclasse e mesmo assim acrescentar outras coisas
            //nesse caso, será implementada a regra da superclasse Account e depois a implementada a regra particular da SavingAccount


            //nesse caso não vai descontar os 5 reais
        }
    }
}

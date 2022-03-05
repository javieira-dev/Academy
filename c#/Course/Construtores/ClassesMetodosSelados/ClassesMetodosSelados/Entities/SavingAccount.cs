using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetodosSelados.Entities
{
    /*sealed*/ class SavingAccount : Account ///palavra SEALED
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }


        //Só é possivel selar metodos sobrepostos palavra SEALED
        //isso depende da regra de negócio caso você queira proteger algo que não pode ser sobrepostos
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }

    }
}

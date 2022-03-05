using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingDownCasting.Entities
{
    class SavingAcount : Acount 
    {
        public double InterestRate { get; set; }

        public SavingAcount()
        {

        }

        public SavingAcount(int number, string holder, double balance, double interestRate): base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}

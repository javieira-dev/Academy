using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingDownCasting.Entities
{
    class BusinessAcount : Acount
    {
        public double LoanLimit { get; set; }

        public BusinessAcount()
        {

        }

        //construtor da subclasse
        public BusinessAcount (int number,string holder, double balance,double loanLimit) : base(number, holder, balance)
        // Como é uma herança, os três primeiros parametros são da classe Acount
        {
            //Ao inves de repetir todas as atribuioes igual está na classe acount,
            //basta acionar o construtor do acount para ele fazer as atribuições, pois o principio da orientação a objeto 
            //é o reaproveitamento

            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }


        }
    }
}

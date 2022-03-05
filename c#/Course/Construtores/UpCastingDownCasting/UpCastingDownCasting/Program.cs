using System;
using UpCastingDownCasting.Entities;

namespace UpCastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount act = new Acount(1001, "Alex", 0.0);
            BusinessAcount bsa = new BusinessAcount(1002, "Maria",0.0, 500.0);


            //UPDASCING
            //Conversão de subclasse para superclasse
            Acount acc1 = bsa;
            Acount acc2 = new BusinessAcount(1003, "Janaina", 0.0, 200.0);
            Acount acc3 = new SavingAcount(1004, "Jose", 0.0, 0.01);

            
            
            //DOWNDASCING
            //Conversão de superclasse para subclasse

            //Não pode converter implicitamente:
            //BusinessAcount acc4 = acc2;  isso não funciona, entçao tem que fazer um casting para realizar a conversao, casting abaixo

            BusinessAcount acc4 = (BusinessAcount)acc2;
            acc4.Loan(100.0);


            //o downcasting não é muito usual
            //Então, por exemplo, não é possivel atribuir uma variável que não é do tipo 


            // BusinessAcount acc5 = (BusinessAcount)acc3;
            if (acc3 is BusinessAcount)
            {
                //BusinessAcount acc5 = (BusinessAcount)acc3;
                BusinessAcount acc5 = acc3 as BusinessAcount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingAcount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingAcount acc5 = acc3 as SavingAcount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }



        }
    }
}

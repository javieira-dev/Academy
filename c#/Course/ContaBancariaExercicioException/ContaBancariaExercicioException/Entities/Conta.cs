using ContaBancariaExercicioException.Entities.Exception;

namespace ContaBancariaExercicioException.Entities
{
    class Conta
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Conta (int number, string holder, double balance, double withDrawnLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawnLimit;
        }


        public void Deposit(double amount)
        {
            Balance += amount  ;
        } 

        public void Withdrown(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new CountException("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new CountException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}

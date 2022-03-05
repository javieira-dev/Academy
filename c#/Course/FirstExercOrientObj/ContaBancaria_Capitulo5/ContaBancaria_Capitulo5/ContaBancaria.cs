using System.Globalization;

namespace ContaBancaria_Capitulo5
{
    class ContaBancaria
    {
        public int Conta { get; private set; }
        public string Titular { get;  set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular)
        {
            Conta   = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double depositoInicial) : this (conta, titular)
        {
            Deposito(depositoInicial); 
            //ao inves de colocar a atribuição direta, colocar o método deposito, pois se mudar alguma regra de deposito
            //ele ja vai refletir no deposito inicial.
        }

        public void Deposito(double deposito)
        {
             Saldo += deposito;    
        }


        public void Saque(double saque)
        {
            Saldo -= saque;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

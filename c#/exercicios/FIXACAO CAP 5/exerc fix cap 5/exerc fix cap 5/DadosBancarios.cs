using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace exerc_fix_cap_5
{
    class DadosBancarios
    {
        private double deposito;

        //metodos de acesso Propriedades auto implementadas
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
 
        
        //construtor

        public DadosBancarios(int conta, string titular)
        {
            Conta   = conta;
            Titular = titular;
       }

        public DadosBancarios(int conta, string titular, double depositoInicial) : this(conta, titular) 
            //this para aproveitar os valores do construtor anterior
        {
            //Saldo = depositoInicial;   
            Deposito(depositoInicial); //por questões de manutenção dessa forma é melhor 
                                       //pois o ponto de alteração do saldo fica em um único lugar no projeto 
                                       //facilitando futuras manutenções
        }


        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque -5.00;
        }


        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", titular: "
                + Titular
                + ", saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture); //para colocar o ponto no valor
        }


        //Outros métodos da Classe


    }
}

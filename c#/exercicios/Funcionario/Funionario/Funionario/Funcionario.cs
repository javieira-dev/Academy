using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Funionario
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;


        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }


        public void AumentoSalario(double prc)
        {
            Salario = Salario +(Salario * prc / 100);
        }

        public override string ToString()
        {
            return "Funcionario: " 
                + Nome 
                + " $" 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}

using System;

namespace ModificParamsRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //esse ref significa que você está modificando a variável original
            //modificador ref = faz o parâmetro ser uma referência para a variável original
            //o modificador reg exige que a variável seja iniciada

            ////////////////////////////////////////////////////////////out


            int b = 10;
            //int triplo;

            Calculator.Triplo(b, out int triplo);
            Console.WriteLine(triplo);

        }
    }
}

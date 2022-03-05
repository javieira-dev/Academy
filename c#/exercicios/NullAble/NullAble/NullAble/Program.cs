using System;

namespace NullAble
{
    class Program
    {
        static void Main(string[] args)
        {
            //nullable é um recurso para que dados tipo valor (structs) possam receber valor nulo
            //na aula passada vimos que esse tipo de dado não pode receber valor nulo
            //mas existem alguns casos que é necessário colocar um valor nulo
            //por exemplos campos não obrigatórios como data de nascimento etc
            //No C# os campos datas, valores numericos por padrão são struct, tipo valor.

            //double x = null; isso não é permitdo

            Nullable<double> x = null;
            //ou pode ser com a seguinte sintaxe:
            double? y = null;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            //o que o getValueOrDefault faz: 
            //"pega o valor de x OU se o valor não existir pega o valor padrão do tipo da variável "
            //o valor padrão do tipo double é o 0 
            //então como não tem valor definido para variável ele vai imprimir 

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            //o que o hasvalue (propriedade) faz? vai dizer se na variável existe ou não valor

            //Console.WriteLine(x.Value);
            // Console.WriteLine(y.Value);
            //a operação value lança uma exceção se tentar chamar ela a partir de um um objeto nullable que vale nulo

            //nesse caso é possivel usar um if para tratar o erro:

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else Console.WriteLine("x is null");

            if (y.HasValue)
                Console.WriteLine(x.Value);
            else Console.WriteLine(("Y is null"));

            //OPERADOR DE COALESCENCIA NULA 

            double? a = null;
            double? b = 10;

            double c = a ?? 5;
            double d = b ?? 6;
            //O que o operador de coalescencia nula faz?
            //se o valor da variavel que estiver recebendo for nulo ele vai utilizar 
            //o valor definido após o o sinal de coalescencia

            Console.WriteLine(c);
            Console.WriteLine(d);

        }
    }
}

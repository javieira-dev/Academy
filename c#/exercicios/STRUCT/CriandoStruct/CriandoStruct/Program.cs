using System;

namespace CriandoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            //nesse caso não tem necessidade de istanciar (p = new point()) porque é um tipo struct
            //é m tipo valor a simples declaração ja vai criar a caixinha dele do stack da memória
            //embora ele permita instanciar a classe (conforme está abaixo)

            // embora o tipo  seja um tipo struct não pode simplismente imprimir na tela
            //basta iniciar a variável ou instanciar
            p.x = 10;
            p.y = 10;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }
    }
}

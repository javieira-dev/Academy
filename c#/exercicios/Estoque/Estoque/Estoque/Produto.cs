using System;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public double Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        
        public void AdicionarProduto(int quantidade)
            //Variável de entrada de parâmetro de função começa com letra minúscula;
        {
            Quantidade += quantidade;
            //pode usar Quantodade = Quantidade + quantidade
        }

        public void RemoverProduto(int quantidade)
        //Variável de entrada de parâmetro de função começa com letra minúscula;
        {
            Quantidade -= quantidade;
            //pode usar Quantodade = Quantidade + quantidade
        }


        public override string ToString()
        {
            return Nome
                + " ,$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " ,"
                + Quantidade
                + " unidades, total: $: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

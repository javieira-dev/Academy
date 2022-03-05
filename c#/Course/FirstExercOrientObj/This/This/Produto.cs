using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace This
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto()
        {
            Quantidade = 10;
        }


        public Produto(string nome, double preco): this() //ele está aproveitando o construtor acima
        {
            Nome = nome;
            Preco = preco;
        }


        public Produto(string nome, double preco, int quantidade) : this (nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return Nome
            + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }

    }

}

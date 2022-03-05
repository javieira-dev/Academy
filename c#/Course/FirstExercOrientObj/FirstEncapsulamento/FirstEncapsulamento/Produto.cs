using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FirstEncapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        //padrão de nomenclatura de atributos privados

        //implementação manual do encapsulamento         

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string getNome()
        {
            return _nome;
        }

        public double getPreco()
        {
            return _preco;
        }

        public int getQuantidade()
        {
            return _quantidade;
        }


        public void setNome(string nome)
        {
            if(nome != null && nome.Length > 1){
                _nome = nome;
            }
            
        }



        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }


        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome
            + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }

    }

}

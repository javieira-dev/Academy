using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        //atributo private significa que o atributo não pode ser acessado por outra classe, isso é encapsulamento
        //atributos private começam com _ e letra minúscula
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
        }


        //para tornar os atributos acessiveis utilizar os MÉTODOs get e set
        //retornar o valor utilizar get:
        public string GetNome()
        {
            return _nome;
        }

        //PARA ALTERAR O VALOR NECESSÁRIO IMPLEMENTAR O MÉTODO SET
        //utilizar o método void, porque void não retorna nada como saída
        public void SetNome(string nome)
        { 
            //é possível implementar condições para aceitar o que está sendo enviado:
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;

            }
        }


        //caso nao queira de jeito nenhum que os dados sejam alterados, criar somente o método get para eles
        //assim é possível controlar o que acontece dentro da classe de acordo com a regra de negócio
        public double GetPreco()
        {
            return _preco;
        }
        
        public double GetQuantidade()
        {
            return _quantidade;
        }


        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
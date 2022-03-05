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

        //criar uma propriedade "property" 
        public string Nome
        {
            get { return _nome; }
            set
            {
                //como os metodos get e set não têm variáveis o valor que ira receber o conteudo é sempre o "value"
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public double Quantidade
        {
            get { return _quantidade; }
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
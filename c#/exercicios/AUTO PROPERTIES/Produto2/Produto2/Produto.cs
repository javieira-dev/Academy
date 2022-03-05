using System.Globalization;
namespace Course
{
    class Produto
    {
        // 1  ATRIBUTO PRIVATIVO   //
        //como o nome possui uma regra particular que está lá em baixo não da pra implementar o auto properties
        private string _nome;

        //PROPRIEDADES AUTO IMPLEMENTADAS//

        public double Preco { get; private set; }
       //o "private set" indica que o preço não pode ser alterado por outros arquivos, outras classes
       public int Quantidade { get; private set; }



        // 2  CONSTRUTORES   //

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }



        // 3  PROPRIEDADES CUSTOMIZADAS //

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

        //  4 OUTROS MÉTODOS DA CLASSE  //
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
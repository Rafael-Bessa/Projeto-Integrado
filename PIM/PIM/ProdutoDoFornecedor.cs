namespace PIM
{
    class ProdutoDoFornecedor
    {

        private string cnpjDoFornecedor;
        private string nome;
        private int quantidade;
        private double preco;
        private string descricao;

        public ProdutoDoFornecedor(string cnpjDoFornecedor, string nome, int quantidade, double preco, string descricao)
        {
            this.cnpjDoFornecedor = cnpjDoFornecedor;
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
            this.descricao = descricao;
        }

        public string CnpjDoFornecedor { get => cnpjDoFornecedor; }
        public string Nome { get => nome;}
        public int Quantidade { get => quantidade;}
        public double Preco { get => preco;}
        public string Descricao { get => descricao; }
    }
}
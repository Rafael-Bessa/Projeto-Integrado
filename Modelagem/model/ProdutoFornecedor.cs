using PIM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.model
{
    public class ProdutoFornecedor
    {

        private int id_produtoFornecedor;
        private int id_fornecedor_fk;
        private string nome;
        private decimal preco;
        private int quantidade_estoque;
        private string descricao;
        private DateTime data_validade;
        private Status status;

        public int Id_produtoFornecedor { get => id_produtoFornecedor; set => id_produtoFornecedor = value; }
        public int Id_fornecedor_fk { get => id_fornecedor_fk; set => id_fornecedor_fk = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Quantidade_estoque { get => quantidade_estoque; set => quantidade_estoque = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public DateTime Data_validade { get => data_validade; set => data_validade = value; }
        public Status Status { get => status; set => status = value; }
    }
}

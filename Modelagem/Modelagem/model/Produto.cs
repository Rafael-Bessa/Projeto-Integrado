using PIM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.model
{
    public class Produto
    {

        private int id_produto;
        private string nome;  //UK
        private string descricao;
        private decimal preco;
        private Categoria categoria;
        private int quantidade_estoque;
        private DateTime data_validade;
        private Status status;

        public Produto(string nome, string descricao, decimal preco, Categoria categoria, int quantidade_estoque, DateTime data_validade, Status status)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
            this.categoria = categoria;
            this.quantidade_estoque = quantidade_estoque;
            this.data_validade = data_validade;
            this.Status = status;
        }

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public int Quantidade_estoque { get => quantidade_estoque; set => quantidade_estoque = value; }
        public DateTime Data_validade { get => data_validade; set => data_validade = value; }
        public Status Status { get => status; set => status = value; }
    }
}

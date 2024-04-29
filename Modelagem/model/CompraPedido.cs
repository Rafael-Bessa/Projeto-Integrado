using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.model
{
    public class CompraPedido
    {

        private int id_compra_pedido;
        private int id_produtoFornecedor_fk;
        private int id_compra_fk;
        private int quantidade_produto_fornecedor;
        private decimal valorTotalPedido;
        private StatusParaCompra statusPedido;

        public int Id_compra_pedido { get => id_compra_pedido; set => id_compra_pedido = value; }
        public int Id_produtoFornecedor_fk { get => id_produtoFornecedor_fk; set => id_produtoFornecedor_fk = value; }
        public int Id_compra_fk { get => id_compra_fk; set => id_compra_fk = value; }
        public int Quantidade_produto_fornecedor { get => quantidade_produto_fornecedor; set => quantidade_produto_fornecedor = value; }
        public decimal ValorTotalPedido { get => valorTotalPedido; set => valorTotalPedido = value; }
        public StatusParaCompra StatusPedido { get => statusPedido; set => statusPedido = value; }
    }
}

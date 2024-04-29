using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.model
{
    public class PedidoCliente
    {

        private int id_pedido;
        private int id_cliente_fk;
        private int id_produto_fk;
        private int quantidade_pedido;
        private DateTime data_pedido;
        private StatusParaVenda statusParaVenda;


    }
}

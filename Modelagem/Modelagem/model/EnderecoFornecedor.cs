using Modelagem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.model
{
    public class EnderecoFornecedor : Endereco
    {

        private int id_fornecedor_fk;

        public int Id_fornecedor_fk { get => id_fornecedor_fk; set => id_fornecedor_fk = value; }
    }
}

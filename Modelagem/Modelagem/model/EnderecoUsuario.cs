using Modelagem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.model
{
    public class EnderecoUsuario : Endereco
    {

        private int id_usuario_fk;

        public int Id_usuario_fk { get => id_usuario_fk; set => id_usuario_fk = value; }
    }
}

using Modelagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.model
{
    public class Cliente : Usuario
    {

        private int id_cliente;
        private int id_usuario_fk_uk;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_usuario_fk_uk { get => id_usuario_fk_uk; set => id_usuario_fk_uk = value; }
    }
}

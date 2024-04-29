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

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
    }
}

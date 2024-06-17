using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using PIM.dao;
using PIM.model;
using PIM.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.console
{
    public class SistemaCadastro
    {
        private UsuarioService service = new UsuarioService();

        public void iniciarCadastro()
        {

            service.simulacaoCadastroClienteViaConsole();

        }
 
    }

}

using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.service
{
    public class UsuarioService
    {

        private UsuarioDAO usuarioDAO = new UsuarioDAO();


        public int cadastraUsuario(Usuario usuario)
        {
            return usuarioDAO.cadastraNovoUsuarioDoSistema(usuario);

        }

        public Usuario buscaUsuarioPeloLogin(string login)
        {
            return usuarioDAO.getUsuarioByLogin(login);
        }

       
        // OUTROS METODOS DO CRUD IMPLEMENTAR SEMESTRE QUE VEM


    }
}

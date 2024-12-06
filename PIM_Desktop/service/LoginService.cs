using PIM_Desktop.dao;
using PIM_Desktop.model;
using PIM_Desktop.security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_Desktop.service
{
    public class LoginService
    {
        private UsuarioDAO usuariodao = new UsuarioDAO();
        
        public bool ValidaAcessoUsuario(string login, string senha)
        {
            var usuarioBuscado = usuariodao.getUsuarioByLogin(login);

            if (usuarioBuscado != null && usuarioBuscado.Senha.Equals(EncriptadorSenha.Encriptar(senha)))
            {
                return true;
            }
            return false;
        }

        public NivelAcesso nivelAcessoUsuarioBuscado(string login)
        {
            return usuariodao.getNivelAcessoUsuario(login);
        }

        public Status statusUsuarioBuscado(string login)
        {
            return usuariodao.getStatusUsuario(login);
        }
    }
}

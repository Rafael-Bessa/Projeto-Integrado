﻿using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.service
{
    public class LoginService
    {
        private UsuarioDAO usuariodao = new UsuarioDAO();

        public bool ValidaAcessoUsuario(Usuario usuario)
        {
            var usuarioBuscado = usuariodao.getUsuarioByLogin(usuario.Login);

            if (usuario.Equals(usuarioBuscado))
            {
                return true;
            }
            return false;
        }

        public NivelAcesso nivelAcessoUsuarioBuscado(Usuario usuario)
        {
            return usuariodao.getNivelAcessoUsuario(usuario.Login);
        }

    }
}

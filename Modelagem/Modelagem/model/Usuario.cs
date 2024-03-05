using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.Model
{
    public class Usuario
    {
        private string login;
        private string senha;

        public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Usuario outroUsuario = (Usuario)obj;
            return Login == outroUsuario.Login && Senha == outroUsuario.Senha;
        }

        public override int GetHashCode()
        {
            int hash = 31;
            hash = hash * 31 + Login.GetHashCode();
            hash = hash * 31 + Senha.GetHashCode();

            return hash;
        }

    }
}

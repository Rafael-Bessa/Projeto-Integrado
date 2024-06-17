using Modelagem.model;
using PIM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.Model
{
    public class Usuario
    {
        private int usuario_id;
        private string login; //uk
        private string senha;
        private string nome;
        private string sobrenome;
        private string email; //uk
        private string cpf; //uk
        private string telefone; //uk
        private NivelAcesso nivelAcesso;
        private decimal? salario;
        private Status status;
        private int endereco_id_fk;

        public Usuario() { }

        public Usuario(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public Usuario(string login, string senha, NivelAcesso nivelAcesso)
        {
            this.Login = login;
            this.Senha = senha;
            this.NivelAcesso = nivelAcesso;
        }

        public Usuario(string login, string senha, string nome, string sobrenome, string email, string cpf, string telefone, NivelAcesso nivelAcesso, decimal? salario, Status status, int endereco_id_fk)
        {
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.email = email;
            this.cpf = cpf;
            this.telefone = telefone;
            this.nivelAcesso = nivelAcesso;
            this.salario = salario;
            this.status = status;
            this.Endereco_id_fk = endereco_id_fk;
        }

        public Usuario(int usuario_id, string login, string senha, string nome, string sobrenome, string email, string cpf, string telefone, NivelAcesso nivelAcesso, decimal? salario, Status status, int endereco_id_fk)
        {
            this.usuario_id = usuario_id;
            this.login = login;
            this.senha = senha;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.email = email;
            this.cpf = cpf;
            this.telefone = telefone;
            this.nivelAcesso = nivelAcesso;
            this.salario = salario;
            this.status = status;
            this.Endereco_id_fk = endereco_id_fk;
        }

        public int Usuario_id { get => usuario_id; set => usuario_id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public NivelAcesso NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }  
        public Status Status { get => status; set => status = value; }
        public decimal? Salario { get => salario; set => salario = value; }
        public int Endereco_id_fk { get => endereco_id_fk; set => endereco_id_fk = value; }

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

        public override string ToString()
        {
            return $"Usuario ID: {Usuario_id}, Login: {Login}, Nome: {Nome} {Sobrenome}, Email: {Email}, Telefone: {Telefone}, Status: {Status}, Acesso: {NivelAcesso}";
        }

    }
}

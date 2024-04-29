using PIM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.model
{
    public class Fornecedor
    {

        private int id_fornecedor;
        private string cnpj; //uk
        private string razao_social; //uk
        private string email; //uk
        private string telefone; //uk
        private string nome_representante;
        private Status status;

        public Fornecedor(string cnpj, string razao_social, string email, string telefone, string nome_representante, Status status)
        {
            this.cnpj = cnpj;
            this.razao_social = razao_social;
            this.email = email;
            this.telefone = telefone;
            this.nome_representante = nome_representante;
            this.Status = status;
        }

        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Razao_social { get => razao_social; set => razao_social = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Nome_representante { get => nome_representante; set => nome_representante = value; }
        public Status Status { get => status; set => status = value; }
    }
}

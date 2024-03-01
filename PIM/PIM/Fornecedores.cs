using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    class Fornecedores
    {

        private string razaoSocial;
        private string cnpj;
        private string email;
        private string telefone;
        private List<ProdutoDoFornecedor> produtos;

        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        internal List<ProdutoDoFornecedor> Produtos { get => produtos; set => produtos = value; }

    }
}

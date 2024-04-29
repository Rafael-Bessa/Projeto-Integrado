using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.model
{
    public class Endereco
    {

        private int id_endereco;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string cep;

        public int Id_endereco { get => id_endereco; set => id_endereco = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Cep { get => cep; set => cep = value; }

        public bool enderecoValido()
        {
            // Verifique se cada atributo é válido (não nulo, dentro do intervalo correto, etc.)
            if (string.IsNullOrEmpty(this.logradouro) ||
                string.IsNullOrEmpty(this.numero) ||
                string.IsNullOrEmpty(this.bairro) ||
                string.IsNullOrEmpty(this.cidade) ||
                string.IsNullOrEmpty(this.cep))
            {
                return false;
            }
            return true;
        }




    }
}

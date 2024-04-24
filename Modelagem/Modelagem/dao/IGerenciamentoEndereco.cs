using Modelagem.model;
using PIM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.dao
{
    public interface IGerenciamentoEndereco
    {

        public Endereco buscaEnderecoPeloID(int id);

        public List<Endereco> buscaTodosEnderecos();

        public int cadastraEndereco(Endereco endereco);

        public void atualizaEnderecoPeloID(int id);

        public void deletaEnderecoPeloID(int id);


    }
}

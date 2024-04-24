using Modelagem.db;
using Modelagem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.dao
{
    public class EnderecoFornecedorDAO : FabricaConexao, IGerenciamentoEndereco
    {

        void IGerenciamentoEndereco.atualizaEnderecoPeloID(int id)
        {
            throw new NotImplementedException();
        }

        Endereco IGerenciamentoEndereco.buscaEnderecoPeloID(int id)
        {
            throw new NotImplementedException();
        }

        List<Endereco> IGerenciamentoEndereco.buscaTodosEnderecos()
        {
            throw new NotImplementedException();
        }

        int IGerenciamentoEndereco.cadastraEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        void IGerenciamentoEndereco.deletaEnderecoPeloID(int id)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class EnderecoDAO : FabricaConexao
    {
        public int cadastraNovoEndereco(Endereco endereco)
        {
            int enderecoId = -1;
            using (SqlConnection conexao = getConexao())
            {
                SqlTransaction transacao = conexao.BeginTransaction();
                SqlCommand comando = new SqlCommand("INSERT INTO ENDERECO (END_STR_LOGRADOURO, END_STR_NUMERO, END_STR_COMPLEMENTO, END_STR_BAIRRO, END_STR_CIDADE, END_STR_CEP)" +
                    " OUTPUT INSERTED.END_INT_ID VALUES (@Logradouro, @Numero, @Complemento, @Bairro, @Cidade, @Cep);", conexao, transacao);

                try
                {
                    comando.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                    comando.Parameters.AddWithValue("@Numero", endereco.Numero);
                    comando.Parameters.AddWithValue("@Complemento", endereco.Complemento ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    comando.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                    comando.Parameters.AddWithValue("@Cep", endereco.Cep);

                    // ExecuteScalar retorna o valor da primeira coluna da primeira linha no conjunto de resultados
                    enderecoId = (int)comando.ExecuteScalar();
                    transacao.Commit();
                }
                catch (Exception ex)
                {
                    transacao.Rollback();
                    Console.WriteLine("Ocorreu um erro ao cadastrar o endereço: " + ex.Message);
                }
            }
            return enderecoId;

        }
    }
}
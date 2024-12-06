using PIM_Desktop.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_Desktop.dao
{
    public class EnderecoDAO : FabricaDeConexoes
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

        public Endereco getEnderecoById(int enderecoId)
        {
            Endereco endereco = null;
            using (SqlConnection conexao = getConexao())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ENDERECO WHERE END_INT_ID = @Id;", conexao);
                comando.Parameters.AddWithValue("@Id", enderecoId);

                try
                {
                    var leitura = comando.ExecuteReader();
                    if (leitura.HasRows && leitura.Read())
                    {
                        string logradouro = leitura.GetString(leitura.GetOrdinal("END_STR_LOGRADOURO"));
                        string numero = leitura.GetString(leitura.GetOrdinal("END_STR_NUMERO"));
                        string complemento = leitura.IsDBNull(leitura.GetOrdinal("END_STR_COMPLEMENTO")) ? null : leitura.GetString(leitura.GetOrdinal("END_STR_COMPLEMENTO"));
                        string bairro = leitura.GetString(leitura.GetOrdinal("END_STR_BAIRRO"));
                        string cidade = leitura.GetString(leitura.GetOrdinal("END_STR_CIDADE"));
                        string cep = leitura.GetString(leitura.GetOrdinal("END_STR_CEP"));

                        endereco = new Endereco(enderecoId, logradouro, numero, complemento, bairro, cidade, cep);
                    }
                    else
                    {
                        Console.WriteLine("Endereço não encontrado no banco de dados");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao buscar o endereço: " + ex.Message);
                }
            }
            return endereco;
        }

    }


}


using Modelagem.db;
using Modelagem.model;
using PIM.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.dao
{
    public class EnderecoUsuarioDAO : FabricaConexao, IGerenciamentoEndereco
    {

        public void deletaEnderecoPeloID(int id)
        {
            throw new NotImplementedException();
        }

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
          
            var enderecoUsuario = endereco as EnderecoUsuario;
            int enderecoId = 0;

            if (enderecoUsuario != null)
            {
                using (SqlConnection conexao = getConexao())
                {
                    SqlTransaction transacao = conexao.BeginTransaction();
                    SqlCommand comando = new SqlCommand("INSERT INTO endereco_usuario OUTPUT INSERTED.ID_ENDERECO_USUARIO VALUES (@Logradouro, @Numero, @Complemento, @Bairro, @Cidade, @Cep, @Usuario_id);", conexao, transacao);

                    try
                    {
                        comando.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                        comando.Parameters.AddWithValue("@Numero", endereco.Numero);
                        comando.Parameters.AddWithValue("@Complemento", endereco.Complemento ?? (object)DBNull.Value);
                        comando.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                        comando.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                        comando.Parameters.AddWithValue("@Cep", endereco.Cep);
                        comando.Parameters.AddWithValue("@Usuario_id", enderecoUsuario.Id_usuario_fk);

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
            }
            else
            {
                Console.WriteLine("O Endereco fornecido não é do tipo esperado.");
            }

            return enderecoId;
        }

       
    }
}

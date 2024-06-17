using Modelagem.model;
using Modelagem.Model;
using PIM.dao;
using PIM.model;
using PIM.securityUtils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.db
{
    public class UsuarioDAO : FabricaConexao
    {

        private SqlCommand comando;
        
        public Usuario getUsuarioByLogin(string loginUsuario)
        {
            try
            {
            
                comando = new SqlCommand("SELECT * FROM USUARIO WHERE USU_STR_LOGIN = @Login;", getConexao());
                comando.Parameters.AddWithValue("@Login", loginUsuario);
                var leitura = comando.ExecuteReader();

                if (leitura.HasRows && leitura.Read())
                {
                    int id_usuario = leitura.GetInt32(0);
                    string login = leitura.GetString(1);
                    string senha = leitura.GetString(2);
                    string nome = leitura.GetString(3);
                    string sobrenome = leitura.GetString(4);
                    string email = leitura.GetString(5);
                    string cpf = leitura.GetString(6);
                    string telefone = leitura.GetString(7);
                    string nivelAcesso = leitura.GetString(8);
                    

                    decimal? salario = null;
                    if (!leitura.IsDBNull(9))
                    {
                        salario = leitura.GetDecimal(9);
                    }
                    
                    bool statusBit = leitura.GetBoolean(10);

                    Status status;

                    if (statusBit)
                    {
                        status = Status.ATIVO;
                    }
                    else
                    {
                        status = Status.INATIVO;
                    }

                    int enderecoId = leitura.GetInt32(11);

                    NivelAcesso nivel = (NivelAcesso)Enum.Parse(typeof(NivelAcesso), nivelAcesso);
                    

                    return new Usuario(id_usuario,login,senha,nome,sobrenome,email,cpf,telefone, nivel, salario, status, enderecoId);
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado no banco de dados");
                }
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public NivelAcesso getNivelAcessoUsuario(string loginUsuario)
        {
            comando = new SqlCommand("SELECT * FROM USUARIO WHERE USU_STR_LOGIN = @Login;", getConexao());
            comando.Parameters.AddWithValue("@Login", loginUsuario);
            var leitura = comando.ExecuteReader();

            if (leitura.HasRows && leitura.Read())
            {
                string nivelAcesso = leitura.GetString(8);
                return (NivelAcesso)Enum.Parse(typeof(NivelAcesso), nivelAcesso);
            }
            return NivelAcesso.SEM_ACESSO;

        }

        public int cadastraNovoUsuarioDoSistema(Usuario usuario, int enderecoId)
        {
            try
            {
                using (SqlConnection conexao = getConexao())
                {
                    using (SqlTransaction transacao = conexao.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand comando = new SqlCommand("INSERT INTO USUARIO (USU_STR_LOGIN, USU_STR_SENHA, USU_STR_NOME, USU_STR_SOBRENOME, USU_STR_EMAIL, USU_STR_CPF, USU_STR_TELEFONE, USU_STR_NIVEL_ACESSO, USU_DEC_SALARIO,USU_BIT_STATUS, END_INT_ID)" +
                                " VALUES (@Login, @Senha, @Nome, @Sobrenome, @Email, @Cpf, @Telefone, @NivelAcesso, @Salario, @Status, @EnderecoId);", conexao, transacao))
                            {
                                comando.Parameters.AddWithValue("@Login", usuario.Login);
                                comando.Parameters.AddWithValue("@Senha", EncriptadorSenha.Encriptar(usuario.Senha));
                                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                                comando.Parameters.AddWithValue("@Sobrenome", usuario.Sobrenome);
                                comando.Parameters.AddWithValue("@Email", usuario.Email);
                                comando.Parameters.AddWithValue("@Cpf", usuario.Cpf);
                                comando.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                                comando.Parameters.AddWithValue("@NivelAcesso", usuario.NivelAcesso);
                                comando.Parameters.AddWithValue("@Salario", (object)usuario.Salario ?? DBNull.Value);
                                comando.Parameters.AddWithValue("@Status", Status.ATIVO);
                                comando.Parameters.AddWithValue("@EnderecoId", enderecoId);

                                comando.ExecuteNonQuery();
                                transacao.Commit();
                            }
                        }
                        catch (Exception ex)
                        {
                            transacao.Rollback();
                            Console.WriteLine("Ocorreu um erro ao cadastrar o usuário: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao abrir a conexão com o banco de dados: " + ex.Message);
            }
            return -1;
        }


        public Usuario getUsuarioByCpf(string cpfUsuario)
        {
            try
            {

                comando = new SqlCommand("SELECT * FROM USUARIO WHERE USU_STR_CPF = @Cpf;", getConexao());
                comando.Parameters.AddWithValue("@Cpf", cpfUsuario);
                var leitura = comando.ExecuteReader();

                if (leitura.HasRows && leitura.Read())
                {
                    int id_usuario = leitura.GetInt32(0);
                    string login = leitura.GetString(1);
                    string senha = leitura.GetString(2);
                    string nome = leitura.GetString(3);
                    string sobrenome = leitura.GetString(4);
                    string email = leitura.GetString(5);
                    string cpf = leitura.GetString(6);
                    string telefone = leitura.GetString(7);
                    string nivelAcesso = leitura.GetString(8);


                    decimal? salario = null;
                    if (!leitura.IsDBNull(9))
                    {
                        salario = leitura.GetDecimal(9);
                    }

                    bool statusBit = leitura.GetBoolean(10);

                    Status status;

                    if (statusBit)
                    {
                        status = Status.ATIVO;
                    }
                    else
                    {
                        status = Status.INATIVO;
                    }

                    int enderecoId = leitura.GetInt32(11);

                    NivelAcesso nivel = (NivelAcesso)Enum.Parse(typeof(NivelAcesso), nivelAcesso);


                    return new Usuario(id_usuario, login, senha, nome, sobrenome, email, cpf, telefone, nivel, salario, status, enderecoId);
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado no banco de dados");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }











    }
}
using PIM_Desktop.model;
using PIM_Desktop.security;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_Desktop.dao
{
    public class UsuarioDAO : FabricaDeConexoes
    {
        private SqlCommand comando;
        private EnderecoDAO enderecoDAO = new EnderecoDAO();

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
                                comando.Parameters.AddWithValue("@NivelAcesso", usuario.NivelAcesso.ToString());
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

        public List<Usuario> getTodosUsuarios(int pagina, int tamanhoPagina)
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                comando = new SqlCommand("SELECT * FROM USUARIO ORDER BY USU_STR_LOGIN OFFSET @Offset ROWS FETCH NEXT @TamanhoPagina ROWS ONLY;", getConexao());
                comando.Parameters.AddWithValue("@Offset", (pagina - 1) * tamanhoPagina);
                comando.Parameters.AddWithValue("@TamanhoPagina", tamanhoPagina);
                var leitura = comando.ExecuteReader();

                while (leitura.Read())
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
                    Status status = statusBit ? Status.ATIVO : Status.INATIVO;

                    int enderecoId = leitura.GetInt32(11);

                    NivelAcesso nivel = (NivelAcesso)Enum.Parse(typeof(NivelAcesso), nivelAcesso);

                    Usuario usuario = new Usuario(id_usuario, login, senha, nome, sobrenome, email, cpf, telefone, nivel, salario, status, enderecoId);
                    usuarios.Add(usuario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return usuarios;
        }

        public Usuario getUsuarioById(int usuarioId)
        {
            try
            {
                comando = new SqlCommand("SELECT * FROM USUARIO WHERE USU_INT_ID = @Id;", getConexao());
                comando.Parameters.AddWithValue("@Id", usuarioId);
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
                    Status status = statusBit ? Status.ATIVO : Status.INATIVO;

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

        public void desativaUsuario(Usuario usuario)
        {
            try
            {
                comando = new SqlCommand("UPDATE USUARIO SET USU_BIT_STATUS = 0 WHERE USU_INT_ID = @Id", getConexao());
                comando.Parameters.AddWithValue("@Id", usuario.Usuario_id);

                int rowsAffected = comando.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Usuário desativado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Falha ao desativar o usuário.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public void atualizaUsuarioEEndereco(Usuario usuario, Endereco endereco)
        {
            try
            {
                // Atualizando o endereço
                var comando = new SqlCommand(
                    "UPDATE ENDERECO SET " +
                    "END_STR_LOGRADOURO = @Logradouro, " +
                    "END_STR_BAIRRO = @Bairro, " +
                    "END_STR_CEP = @Cep, " +
                    "END_STR_CIDADE = @Cidade, " +
                    "END_STR_COMPLEMENTO = @Complemento, " +
                    "END_STR_NUMERO = @Numero " +
                    "WHERE END_INT_ID = @Id", getConexao()
                );
                comando.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                comando.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                comando.Parameters.AddWithValue("@Cep", endereco.Cep);
                comando.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                comando.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                comando.Parameters.AddWithValue("@Numero", endereco.Numero);
                comando.Parameters.AddWithValue("@Id", endereco.Id_endereco);
                comando.ExecuteNonQuery();

                // Atualizando o usuário
                var comando2 = new SqlCommand(
                    "UPDATE USUARIO SET " +
                    "USU_STR_SENHA = @Senha, " +
                    "USU_STR_NOME = @Nome, " +
                    "USU_STR_SOBRENOME = @Sobrenome, " +
                    "USU_STR_EMAIL = @Email, " +
                    "USU_STR_TELEFONE = @Telefone, " +
                    "USU_DEC_SALARIO = @Salario " +  // Removida a vírgula extra aqui
                    "WHERE USU_INT_ID = @Id", getConexao()
                );
                comando2.Parameters.AddWithValue("@Senha", EncriptadorSenha.Encriptar(usuario.Senha));
                comando2.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando2.Parameters.AddWithValue("@Sobrenome", usuario.Sobrenome);
                comando2.Parameters.AddWithValue("@Email", usuario.Email);
                comando2.Parameters.AddWithValue("@Telefone", usuario.Telefone);
                comando2.Parameters.AddWithValue("@Salario", usuario.Salario.HasValue ? (object)usuario.Salario.Value : DBNull.Value);
                comando2.Parameters.AddWithValue("@Id", usuario.Usuario_id);
                comando2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        public Status getStatusUsuario(string login)
        {
            comando = new SqlCommand("SELECT * FROM USUARIO WHERE USU_STR_LOGIN = @Login;", getConexao());
            comando.Parameters.AddWithValue("@Login", login);
            var leitura = comando.ExecuteReader();
            if (leitura.HasRows && leitura.Read())
            {
                string status = leitura.GetString(10); 
                return (Status)Enum.Parse(typeof(Status), status);
            }
            return Status.INATIVO;  
        }

    }
}


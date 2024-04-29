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
            
                comando = new SqlCommand("SELECT * FROM usuario WHERE login = @Login;", getConexao());
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

                    NivelAcesso nivel = (NivelAcesso)Enum.Parse(typeof(NivelAcesso), nivelAcesso);
                    

                    return new Usuario(id_usuario,login,senha,nome,sobrenome,email,cpf,telefone, nivel, salario, status);
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
            comando = new SqlCommand("SELECT * FROM USUARIO WHERE login = @Login;", getConexao());
            comando.Parameters.AddWithValue("@Login", loginUsuario);
            var leitura = comando.ExecuteReader();

            if (leitura.HasRows && leitura.Read())
            {
                string nivelAcesso = leitura.GetString(8);
                return (NivelAcesso)Enum.Parse(typeof(NivelAcesso), nivelAcesso);
            }
            return NivelAcesso.SEM_ACESSO;

        }


        public int cadastraNovoUsuarioDoSistema(Usuario usuario)
        {
            try
            {
                using (SqlConnection conexao = getConexao())
                {
                    
                    using (SqlTransaction transacao = conexao.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand comando = new SqlCommand("INSERT INTO usuario OUTPUT INSERTED.ID_USUARIO VALUES (@Login, @Senha, @Nome, @Sobrenome, @Email, @Cpf, @Telefone, @NivelAcesso, @Salario, @Status);", conexao, transacao))
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

                                int novoUsuarioID = (int)comando.ExecuteScalar();
                                transacao.Commit();
                                return novoUsuarioID;

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
    }
}
using Modelagem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.db
{
    public class UsuarioDAO : CriaConexao
    {

        SqlCommand comando;

        public Usuario getUsuarioByLogin(string loginUsuario)
        {

            try
            {
                comando = new SqlCommand("SELECT * FROM USUARIO WHERE login = @Login;", getConexao());
                comando.Parameters.AddWithValue("@Login", loginUsuario);
                var leitura = comando.ExecuteReader();

               if (leitura.HasRows && leitura.Read())
                {
                    string login = leitura.GetString(0);
                    string senha = leitura.GetString(1);

                    return new Usuario(login, senha); 
                }
               
                else
                {
                    throw new Exception("Usuário não encontrado no banco de dados");
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            return null;
        }
    }
}

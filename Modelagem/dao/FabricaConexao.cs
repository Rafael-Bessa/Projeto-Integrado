using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelagem.db
{
    public abstract class FabricaConexao
    {

        private static string url = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;

        public SqlConnection getConexao()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(url);
                conexao.Open();
                return conexao;
            }
            catch (SqlException e)
            {
                throw new Exception("Algo deu errado na conexão com o banco de dados", e);
            }
        }




    }
}

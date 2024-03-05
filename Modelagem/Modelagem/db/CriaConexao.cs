using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelagem.db
{
    public abstract class CriaConexao
    {

        private static readonly string url = "Data Source = localhost; Initial Catalog = TESTE; Integrated Security = False; User ID = sa; Password=123456";
        private SqlConnection conexao = new SqlConnection(url);

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
            catch (Exception e)
            {
                throw new Exception("Erro inesperado ao obter conexão", e);
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}

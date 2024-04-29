using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using PIM.model;
using PIM.service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PIM.dao
{
    public class ClienteDAO : FabricaConexao
    {
        public void cadastraCliente(int idUsuario)
        {
            try
            {
                using (SqlConnection conexao = getConexao())
                {
                    using (SqlTransaction transacao = conexao.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand comando = new SqlCommand("INSERT INTO cliente (id_cliente) VALUES (@id_cliente);", conexao, transacao))
                            {
                                comando.Parameters.AddWithValue("@id_cliente", idUsuario);

                                comando.ExecuteNonQuery();
                                transacao.Commit();
                                Console.WriteLine("Cliente cadastrado com sucesso !");
                            }
                        }
                        catch (Exception ex)
                        {
                            transacao.Rollback();
                            Console.WriteLine("Ocorreu um erro ao cadastrar o cliente: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao abrir a conexão com o banco de dados: " + ex.Message);
            }
        }
    }
}

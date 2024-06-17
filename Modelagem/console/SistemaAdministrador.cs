using Modelagem.console;
using Modelagem.dao;
using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using PIM.dao;
using PIM.model;
using PIM.service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.console
{
    public class SistemaAdministrador
    {

        UsuarioService usuarioService = new UsuarioService();
        

        public void GerenciarAdministrador()
        {
            while (true)
            {
                Console.WriteLine("\nSelecione uma das seguintes opções:");
                Console.WriteLine("1. Gerenciar usuários");
                Console.WriteLine("2. Gerenciar fornecedores");
                Console.WriteLine("3. Gerenciar produtos");
                Console.WriteLine("4. Sair");

                Console.Write("\nSua opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        GerenciarUsuarios();
                        break;

                    case "2":                       
                        GerenciarFornecedores();
                        break;

                    case "3":
                        GerenciarProdutos();
                        break;

                    case "4":
                        Console.WriteLine("Saindo do sistema");
                        return;  
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        private  void GerenciarUsuarios()
        {
            while (true)
            {
                Console.WriteLine("\nSelecione uma das seguintes opções:");
                Console.WriteLine("1. Buscar usuário pelo CPF");
                Console.WriteLine("2. Buscar todos os usuários");
                Console.WriteLine("3. Desativar usuário");
                Console.WriteLine("4. Atualizar usuário");
                Console.WriteLine("5. Inserir novo usuário");
                Console.WriteLine("6. Voltar ao menu anterior");

                Console.Write("\nSua opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        usuarioService.recebeCpfViaConsoleEBuscaUsuario();
                        break;

                    case "2":
                        
                        Console.WriteLine("Buscando todos os usuários...");
                        break;

                    case "3":
                        
                        Console.WriteLine("Desativando usuário...");
                        break;

                    case "4":
                        
                        Console.WriteLine("Atualizando usuário...");
                        break;

                    case "5":

                        usuarioService.receberInformacoesViaConsoleECadastrarUsuario();
                        break;
                        

                    case "6":
                        return;  
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        private void GerenciarFornecedores()
        {
            
            Console.WriteLine("Gerenciando fornecedores...");
        }

        private void GerenciarProdutos()
        {
            
            Console.WriteLine("Gerenciando produtos...");
        }

    }
}

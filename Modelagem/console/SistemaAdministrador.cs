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
        EnderecoUsuarioDAO enderecoUsuarioDao = new EnderecoUsuarioDAO();

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
                Console.WriteLine("1. Buscar usuário pelo login");
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
                        Console.WriteLine("Qual o login do usuário ? ");
                        string login = Console.ReadLine();
                        Console.WriteLine("Buscando usuário pelo login...");
                        Thread.Sleep(3000);
                        Usuario usuarioBuscado = usuarioService.buscaUsuarioPeloLogin(login);
                        Console.WriteLine(usuarioBuscado);
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

                        

                        Console.WriteLine("Vamos cadastrar um novo usuário: ");

                        Usuario usuario = new Usuario();

                        Console.Write("Digite o login: ");
                        usuario.Login = Console.ReadLine();

                        Console.Write("Digite a senha: ");
                        usuario.Senha = Console.ReadLine();

                        Console.Write("Digite o nome: ");
                        usuario.Nome = Console.ReadLine();

                        Console.Write("Digite o sobrenome: ");
                        usuario.Sobrenome = Console.ReadLine();

                        Console.Write("Digite o email: ");
                        usuario.Email = Console.ReadLine();

                        Console.Write("Digite o CPF: ");
                        usuario.Cpf = Console.ReadLine();

                        Console.Write("Digite o telefone: ");
                        usuario.Telefone = Console.ReadLine();

                        NivelAcesso nivelAcesso;
                        string nivelAcessoString;
                        bool inputValido = false;
                        decimal? salario = null;

                        while (!inputValido)
                        {
                            Console.Write("Digite o nível de acesso (ADMINISTRADOR, FUNCIONARIO, CLIENTE): ");
                            nivelAcessoString = Console.ReadLine().ToUpper();

                            if (Enum.IsDefined(typeof(NivelAcesso), nivelAcessoString))
                            {
                                inputValido = true;
                                nivelAcesso = (NivelAcesso)Enum.Parse(typeof(NivelAcesso), nivelAcessoString);
                                usuario.NivelAcesso = nivelAcesso;

                                if (nivelAcesso == NivelAcesso.FUNCIONARIO || nivelAcesso == NivelAcesso.ADMINISTRADOR)
                                {
                                    Console.Write("Digite o salário: ");
                                    salario = decimal.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    salario = null;

                                }

                                usuario.Salario = salario;
                                usuario.Status = Status.ATIVO;  
                            }
                            else
                            {
                                Console.WriteLine("Nível de acesso inválido. Tente novamente.");
                            }
                        }

                        
                        int id_endereco_fk = usuarioService.cadastraUsuario(usuario); //cadastra usuario e pega o id dele

                                                                                         
                        Console.WriteLine();
                        Console.WriteLine("Agora precisamos cadastrar o endereço do usuário");


                        EnderecoUsuario endereco = new EnderecoUsuario();

                        Console.Write("Digite o logradouro: ");
                        endereco.Logradouro = Console.ReadLine();

                        Console.Write("Digite o número: ");
                        endereco.Numero = Console.ReadLine();

                        Console.Write("Digite o complemento (ou deixe em branco se não houver): ");
                        endereco.Complemento = Console.ReadLine();

                        Console.Write("Digite o bairro: ");
                        endereco.Bairro = Console.ReadLine();

                        Console.Write("Digite a cidade: ");
                        endereco.Cidade = Console.ReadLine();

                        Console.Write("Digite o CEP: ");
                        endereco.Cep = Console.ReadLine();

                        endereco.Id_usuario_fk = id_endereco_fk;

                        ((IGerenciamentoEndereco)enderecoUsuarioDao).cadastraEndereco(endereco);

                        Console.WriteLine("Usuário cadastrado com sucesso !");

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

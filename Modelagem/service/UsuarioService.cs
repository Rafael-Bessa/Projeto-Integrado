using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using PIM.dao;
using PIM.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.service
{
    public class UsuarioService
    {

        private UsuarioDAO usuarioDAO = new UsuarioDAO();
        private EnderecoDAO enderecoDAO = new EnderecoDAO();
        private ClienteDAO clienteDAO = new ClienteDAO();


        public void receberInformacoesViaConsoleECadastrarUsuario()
        {

            Console.WriteLine("Vamos cadastrar um novo usuário: ");
            Console.WriteLine("Primeiro vamos receber o endereço deste usuário");

            Endereco endereco = new Endereco();

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

            Console.Write("Digite o CEP, apenas os números: ");
            endereco.Cep = Console.ReadLine();

            int idEndereco = enderecoDAO.cadastraNovoEndereco(endereco);

            Usuario usuario = new Usuario();

            Console.WriteLine("Agora vamos receber as informações do usuário");


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

            Console.Write("Digite o CPF apenas os números (11 digitos): ");
            usuario.Cpf = Console.ReadLine();

            Console.Write("Digite o telefone apenas os números com o DDD (11 digitos): ");
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
                }
                else
                {
                    Console.WriteLine("Nível de acesso inválido. Tente novamente.");
                }
            }

            usuario.Status = Status.ATIVO;

            usuarioDAO.cadastraNovoUsuarioDoSistema(usuario, idEndereco);

            Console.WriteLine("********************************");
            Console.WriteLine("Usuário cadastrado com sucesso !");
            Console.WriteLine("********************************");
        }


        public void recebeLoginViaConsoleEBuscaUsuario()
        {

            Console.WriteLine("Qual o login do usuário? ");
            string login = Console.ReadLine();
            Console.WriteLine("Buscando usuário pelo login...");
            Thread.Sleep(2500);

            Usuario usuarioBuscado = usuarioDAO.getUsuarioByLogin(login);
            Console.WriteLine(usuarioBuscado);

        }

        public void recebeCpfViaConsoleEBuscaUsuario()
        {

            Console.WriteLine("Qual o CPF do usuário? ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Buscando usuário pelo CPF...");
            Thread.Sleep(2500);

            Usuario usuarioBuscado = usuarioDAO.getUsuarioByCpf(cpf);
            Console.WriteLine(usuarioBuscado);

        }


        public void simulacaoCadastroClienteViaConsole()
        {

            Console.WriteLine("Vamos cadastrar um novo cliente: ");
            Console.WriteLine("Primeiro vamos precisar saber o endereço do cliente: ");

            Endereco endereco = new Endereco();

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

            Console.Write("Digite o CEP, apenas os números: ");
            endereco.Cep = Console.ReadLine();

            int idEndereco = enderecoDAO.cadastraNovoEndereco(endereco);

            Console.WriteLine("Agora as informações pessoais do cliente ");

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

            Console.Write("Digite o CPF apenas os digitos (11 digitos): ");
            usuario.Cpf = Console.ReadLine();

            Console.Write("Digite o telefone apenas os digitos (11 digitos com o DDD: ");
            usuario.Telefone = Console.ReadLine();

            usuario.NivelAcesso = NivelAcesso.CLIENTE;
            usuario.Salario = null;
            usuario.Status = Status.ATIVO;

            usuarioDAO.cadastraNovoUsuarioDoSistema(usuario, idEndereco);

            var user = usuarioDAO.getUsuarioByLogin(usuario.Login);
            
            clienteDAO.cadastraCliente(user.Usuario_id);
        }




    }
}
using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using PIM.dao;
using PIM.model;
using PIM.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.console
{
    public class SistemaCadastro
    {
        private EnderecoUsuarioDAO enderecoUsuarioDAO = new EnderecoUsuarioDAO();
        private UsuarioService service = new UsuarioService();

        public void iniciarCadastro()
        {
           
            Console.WriteLine("Vamos cadastrar um novo cliente: ");

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

            usuario.NivelAcesso = NivelAcesso.CLIENTE;
            usuario.Salario = null;
            usuario.Status = Status.ATIVO;

            int id_endereco_fk = service.cadastraUsuario(usuario); //cadastra usuario e pega o id dele

            Console.WriteLine();
            Console.WriteLine("Agora precisamos cadastrar o endereço do cliente");
            Console.WriteLine();

            EnderecoUsuario enderecoUsuario = new EnderecoUsuario();

            Console.Write("Digite o logradouro: ");
            enderecoUsuario.Logradouro = Console.ReadLine();

            Console.Write("Digite o número: ");
            enderecoUsuario.Numero = Console.ReadLine();

            Console.Write("Digite o complemento (ou deixe em branco se não houver): ");
            enderecoUsuario.Complemento = Console.ReadLine();

            Console.Write("Digite o bairro: ");
            enderecoUsuario.Bairro = Console.ReadLine();

            Console.Write("Digite a cidade: ");
            enderecoUsuario.Cidade = Console.ReadLine();

            Console.Write("Digite o CEP: ");
            enderecoUsuario.Cep = Console.ReadLine();

            enderecoUsuario.Id_usuario_fk = id_endereco_fk;
            int enderecoCliente = ((IGerenciamentoEndereco)enderecoUsuarioDAO).cadastraEndereco(enderecoUsuario);

            ClienteDAO clienteDAO = new ClienteDAO();
            clienteDAO.cadastraCliente(id_endereco_fk);

        }
 
    }

}

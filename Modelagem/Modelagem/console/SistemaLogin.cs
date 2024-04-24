using Modelagem.model;
using Modelagem.Model;
using Modelagem.service;
using PIM.console;
using PIM.securityUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelagem.console
{
    public class SistemaLogin
    {

        private LoginService loginService = new LoginService();
        SistemaAdministrador sistemaAdministrador = new SistemaAdministrador();
        SistemaFuncionario sistemaFuncionarios = new SistemaFuncionario();
        SistemaCliente sistemaCliente = new SistemaCliente();
        
        public void Iniciar()
        {
            while (true)
            {
                Console.WriteLine("VAMOS SIMULAR A ENTRADA DO USUÁRIO EM UMA TELA DE LOGIN");
                Console.WriteLine("Digite seu login: ");
                string login = Console.ReadLine();

                Console.Write("Digite sua senha: ");
                string senha = "";
                while (true)
                {
                    var tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Enter)
                        break;
                    else if (tecla.Key == ConsoleKey.Backspace)
                    {
                        if (senha.Length > 0)
                        {
                            senha = senha.Remove(senha.Length - 1);
                            Console.Write("\b \b"); // Apaga o último '*' exibido
                        }
                    }
                    else
                    {
                        senha += tecla.KeyChar;
                        Console.Write("*");
                    }
                }

                Console.WriteLine();


                Usuario usuario = new Usuario(login, EncriptadorSenha.Encriptar(senha));

                if (loginService.ValidaAcessoUsuario(usuario))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("USUARIO PODE ENTRAR NO SISTEMA, SUCESSO NO LOGIN");
                    NivelAcesso nivelAcesso = loginService.nivelAcessoUsuarioBuscado(usuario);
                    Console.WriteLine($"ESTE USUARIO É UM {nivelAcesso}");
                    
                    switch (nivelAcesso)
                    {
                        case NivelAcesso.ADMINISTRADOR:
                            
                            sistemaAdministrador.GerenciarAdministrador();

                            break;

                        case NivelAcesso.FUNCIONARIO:
                            
                            sistemaFuncionarios.GerenciarFuncionario();

                            break;

                        case NivelAcesso.CLIENTE:

                            sistemaCliente.GerenciarCliente();

                            break;

                    }

                    break;  
                }
                else
                {
                    Console.WriteLine("Login ou senha inválidos. Tente novamente.");
                }
            }
        }
    }   
}

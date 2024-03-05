using Modelagem.db;
using Modelagem.Model;
using Modelagem.service;

public class Program
{
    private static void Main(string[] args)
    {

        

        /* Usuario Pré definido no banco:
         * login: rafaelbessa
         * senha: abc
         */

        Console.WriteLine("VAMOS SIMULAR A ENTRADA DO USUÁRIO EM UMA TELA DE LOGIN");
        Console.WriteLine("Digite seu login: ");
        string login = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine();

        Usuario usuario = new Usuario(login, senha);


        LoginService loginService = new LoginService();

        if (loginService.existeUsuarioNoBanco(usuario))
        {
            Console.WriteLine("USUARIO PODE ENTRAR NO SISTEMA, SUCESSO NO LOGIN");
        }
       
    }
}
using Modelagem.console;
using Modelagem.db;
using Modelagem.model;
using Modelagem.Model;
using Modelagem.service;
using PIM.console;
using PIM.securityUtils;
using PIM.service;

public class Program
{
    private static void Main(string[] args)
    {

        /* Usuario Pré definido no banco: administrador
         * login: adminrafaelbessa
         * senha: 123
         */

        SistemaLogin sistemaLogin = new SistemaLogin();
        SistemaCadastro sistemaCadastro = new SistemaCadastro();


        
        sistemaLogin.Iniciar();
        

        /*
        sistemaCadastro.iniciarCadastro();
        */
    }
}
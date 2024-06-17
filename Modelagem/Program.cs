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
         * login: admin
         * senha: 123
         */

        SistemaLogin sistemaLogin = new SistemaLogin();
        SistemaCadastro sistemaCadastro = new SistemaCadastro();

        /*
        sistemaLogin.Iniciar();
        */
        
        /*
        sistemaCadastro.iniciarCadastro();
        */


        static int MaiorNumeroDaLista(List<int> lista)
        {
            int numero = lista.IndexOf(0);

            foreach(int n in lista)
            {
                if(n > numero)
                {
                    numero = n;
                }
            }
            return numero;
        }

        List<int> inteiros = new List<int> { -8, 8, 3, 5 };

        Console.WriteLine(MaiorNumeroDaLista(inteiros));


        static double CalcularMedia(List<int> lista)
        {
            double soma = 0;

            foreach(int n in lista)
            {
                soma += n;
            }

            return (soma/lista.Count);
        }

        
        Console.WriteLine(CalcularMedia(inteiros));



    }
}
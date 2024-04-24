using PIM.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.console
{
    public class SistemaFuncionario
    {
        public void GerenciarFuncionario()
        {
            while (true)
            {
                Console.WriteLine("\nSelecione uma das seguintes opções:");
                Console.WriteLine("1. Gerenciar produtos");
                Console.WriteLine("2. Sair");

                Console.Write("\nSua opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        GerenciarProdutos();
                        break;

                    case "2":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }


        private void GerenciarProdutos()
        {
            Console.WriteLine("SERÁ IMPLEMENTADO O CRUD DE PRODUTOS POSTERIORMENTE");
        }

    }
}

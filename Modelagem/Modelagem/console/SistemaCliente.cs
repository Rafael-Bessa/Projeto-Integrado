using Modelagem.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.console
{
    public class SistemaCliente
    {
        public void GerenciarCliente()
        {
            while (true)
            {
                Console.WriteLine("\nSelecione uma das seguintes opções:");
                Console.WriteLine("1. Fazer compras");
                Console.WriteLine("2. Sair");

                Console.Write("\nSua opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        fazerCompra();
                        break;

                    case "2":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        private void fazerCompra() { 
        
            Console.WriteLine("SERÁ IMPLEMENTADO POSTERIORMENTE");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_Pronto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Menu de programas
            

            int opcao;
            bool testemenu;
            
        menu:
            // Apresentação do Programa
            
            do { 
            Console.WriteLine("\n*** MENU DE PROGRAMAS ***\n");

            Console.WriteLine("\nDigite o número do programa que deseja executar: \n");

            Console.WriteLine("[ 1 ] ");
            Console.WriteLine("[ 2 ] ");
            Console.WriteLine("[ 3 ] ");
            Console.WriteLine("[ 4 ] ");
            Console.WriteLine("[ 0 ] Sair");
            Console.WriteLine("-------------------------------------");

            testemenu = int.TryParse(Console.ReadLine(), out opcao);
            if (testemenu == false)
            {
                    Console.Clear();
                    Console.WriteLine("DIGITE UMA OPÇÃO VÁLIDA");
             }
                } while (testemenu == false);

            switch (opcao)
            {

                case 1:

				Console.Clear();
                    
                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);
                    break;

                case 2:

                    Console.Clear();
                    

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);

                    break;

                case 3:

                    Console.Clear();
                    

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);

                    break;

                case 4:

                    Console.Clear();
                    
                    Console.WriteLine("\n\nPressione qualquer tecla para voltar ao menu ou 0 para sair");
                    sair = Console.ReadLine();
                    if (sair == "0")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();
                        goto menu;
                    }

                    Console.ReadKey(true);

                    break;

                case 0:

                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    // Retorna ao menu e informa que o comando dado é inválido.
                    Console.WriteLine("Comando inválido. Tente novamente. \n");
                    goto menu;

            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Gerenciador de Tarefas!");

            // Loop principal do programa
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");

                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Remover Tarefa");
                Console.WriteLine("4. Concluir Tarefa");
                Console.WriteLine("5. Sair");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        TaskService.AdicionarTarefa(); 
                        break;
                    case "2":
                        TaskService.ListarTarefas(); 
                        break;
                    case "3":
                        TaskService.RemoverTarefa();
                        break;
                    case "4":
                        TaskService.MarcarTarefaConcluida();
                        break;
                    case "5":
                        TaskService.Sair();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}

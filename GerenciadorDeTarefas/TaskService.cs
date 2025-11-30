using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas
{
    public class TaskService
    {

        static List<TaskItem> tarefas = new List<TaskItem>();
        static int contadorId = 1;

        // Cadastro da Tarefa;
        public static void AdicionarTarefa()
        {
            Console.WriteLine("Tiulo da tarefa:");
            string titulo = Console.ReadLine();

            Console.WriteLine("Descrição da tarefa:");
            string descricao = Console.ReadLine();

            tarefas.Add(new TaskItem
            {

                Id = contadorId++,
                Titulo = titulo,
                Descricao = descricao,
                Concluida = false
            });


            Console.WriteLine("Tarefa adicionada com sucesso!");
        }



        // Listar Tarefas;

        public static void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }
            Console.WriteLine("Tarefas cadastradas:");
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"ID: {tarefa.Id} | Título: {tarefa.Titulo} | Descrição: {tarefa.Descricao} | Concluída: {tarefa.Concluida}");
            }
        }

        // Remover Tarefas;

        public static void RemoverTarefa()
        {
            Console.WriteLine("Digite o ID da tarefa que deseja remover:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
                if (tarefa != null)
                {
                    tarefas.Remove(tarefa);
                    Console.WriteLine("Tarefa removida com sucesso!");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }

        // Marcar Tarefa como Concluída;

        public static void MarcarTarefaConcluida()
        {
            Console.WriteLine("Digite o ID da tarefa que deseja marcar como concluída:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
                if (tarefa != null)
                {
                    tarefa.Concluida = true;
                    Console.WriteLine("Tarefa marcada como concluída!");
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
        }

        // Sair do Programa;
        public static void Sair()
        {
            Console.WriteLine("Saindo do Gerenciador de Tarefas. Até logo!");
            Environment.Exit(0);
        }
    }
}

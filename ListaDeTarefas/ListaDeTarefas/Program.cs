using ListaDeTarefas.Entities;
using System;

namespace ListaDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user = new User();
            Tasks tasks = new Tasks();
            List<Tasks> listTasks = new List<Tasks>();

            Console.WriteLine("Bem vindo a sua Lista de Tarefas!");
            Console.WriteLine();
            Inicio(users, user);

            void Inicio(List<User> users, User user)
            {

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar usuário");
                Console.WriteLine("2 - Fazer login");
                Console.WriteLine("3 - Listar usuários");
                Console.WriteLine();

                Console.Write("Digite a sua opção: ");
                int validação = int.Parse(Console.ReadLine());

                if (validação == 1)
                {
                    user.CadastrarUsuario(users);
                    Inicio(users, user);
                }
                if (validação == 2)
                {
                    user.FazerLogin(users);
                    MenuLista(listTasks, tasks);
                    
                }
                if (validação == 3)
                {
                    user.ListarUsuários(users);
                    Inicio(users, user);
                }
            }

            void MenuLista(List<Tasks> tasks, Tasks task)
            {
                Console.WriteLine("1 - Adicionar uma tarefa");
                Console.WriteLine("2 - Remover uma tarefa");
                Console.WriteLine("3 - Listar todas as tarefas");
                Console.WriteLine("4 - Deslogar");

                Console.Write("Digite a sua opção: ");
                int validação = int.Parse(Console.ReadLine());

                if (validação == 1)
                {
                    task.AdicionarTarefa(tasks);
                    MenuLista(listTasks, task);
                }
                if (validação == 2)
                {
                    task.RemoverTarefa(tasks);
                    MenuLista(listTasks, task);

                }
                if (validação == 3)
                {
                    task.ListarTarefas(tasks);
                    MenuLista(listTasks, task);
                }
                if (validação == 3)
                {
                    user.ListarUsuários(users);
                    Inicio(users, user);
                }

            }


        }
    }
}

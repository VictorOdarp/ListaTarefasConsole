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

            Console.WriteLine("Bem vindo a sua Lista de Tarefas!");
            Console.WriteLine();
            Inicio(users, user);

            static void Inicio(List<User> users, User user)
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

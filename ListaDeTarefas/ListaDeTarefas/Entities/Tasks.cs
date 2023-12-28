

using System.Reflection;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaDeTarefas.Entities
{
    internal class Tasks
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Tasks()
        {

        }

        public Tasks(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public Tasks(string name)
        {
            Name = name;
        }

        public void MenuLista()
        {
            Console.WriteLine("Bem vindo a sua lista de tarefas!");
            Console.WriteLine();

            Console.WriteLine("1 - Adicionar uma tarefa");
            Console.WriteLine("2 - Remover uma tarefa");
            Console.WriteLine("3 - Listar todas as tarefas");
            Console.WriteLine("4 - Deslogar");
        }

        public void AdicionarTarefa(List<Tasks> tasks)
        {
            Console.Write("Adicionar nova tarefa: ");
            string novaTarefa = Console.ReadLine();
            Console.Write("Digite a data: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Nova tarefa criada!");
            Tasks task = new Tasks(novaTarefa, date);
            tasks.Add(task);
            Console.WriteLine();
        }

        public void RemoverTarefa(List<Tasks> tasks)
        {
            int Count = 1;

            foreach (Tasks task in tasks)
            {
                Console.WriteLine(Count + " - " + task.Name);
                Count++;
            }
            Console.WriteLine();

            Console.Write("Qual o número da tarefa que gostaria de finalizar? ");
            int number = int.Parse(Console.ReadLine());

            tasks.RemoveAt(number - 1);
            Console.WriteLine("Tarefa finalizada com sucesso!");
            Console.WriteLine();

            foreach (Tasks task in tasks)
            {
                Console.WriteLine(Count + " - " + task.Name);
                Count++;
            }
            Console.WriteLine();

        }

        public void ListarTarefas(List<Tasks> tasks)
        {
            int Count = 1;

            foreach (Tasks task in tasks)
            {
                Console.WriteLine(Count + " - " + task.Name + " - " + task.Date.ToString("dd-MM-yyyy"));
                Count++;
            }
            Console.WriteLine();

        }
    }
}

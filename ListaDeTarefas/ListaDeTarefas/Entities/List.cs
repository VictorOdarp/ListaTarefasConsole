

namespace ListaDeTarefas.Entities
{
    internal class List
    {
       public string Name { get; set; }
       public DateTime Date { get; set; }

        public List()
        {

        }

        public List(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public void MenuLista()
        {
            Console.WriteLine("1 - Adicionar uma tarefa");
            Console.WriteLine("2 - Remover uma tarefa");
            Console.WriteLine("3 - Listar todas as tarefas");
            Console.WriteLine("4 - Deslogar");
        }

        public void AdicionarTarefa()
        {

        }

        public void RemoverTarefa()
        {

        }

        public void ListarTarefas()
        {

        }
    }
}

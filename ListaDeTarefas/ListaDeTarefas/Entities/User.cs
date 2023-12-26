

using System.Reflection.Metadata;

namespace ListaDeTarefas.Entities
{
    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<User> Users { get; set; }

        public User()
        {

        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public void CadastrarUsuario(List<User> users)
        {

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            while(!email.Contains("@"))
            {
                Console.WriteLine("Email is not valid!");
                email = Console.ReadLine();
            }
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Write("Confirm your password: ");
            string confirmPassoword = Console.ReadLine();
            while (confirmPassoword != password)
            {
                Console.WriteLine("Passwords don't match!");
                Console.Write("Confirm your password: ");
                confirmPassoword = Console.ReadLine();
            }
            User user = new User(name, email, password);
            users.Add(user);
            Console.WriteLine();
            
        }
        public void FazerLogin(List<User> users)
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
 
            while (!users.Any(x => x.Email == email))
            {
                Console.WriteLine("Email não cadastrado");
                Console.WriteLine();
                
                Console.Write("Email: ");
                email = Console.ReadLine();
            
            }

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            while (!users.Any(x => x.Password == password))
            {
                Console.WriteLine("Senha incorreta");
                Console.WriteLine();

                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Bem vindo a sua lista de tarefas!");
            Console.WriteLine();
       
       
        }

        public void ListarUsuários(List<User> users) 
        {

            foreach (User user in users)
            {
                Console.WriteLine(users.Count() + " - " + user.Name + " - " + user.Email);
            }
            Console.WriteLine();

        }
    }
}

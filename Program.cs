using AdocaoApp;
using AdocaoApp.Screens.CategoryScreens;
using Microsoft.Data.SqlClient;

namespace AdocaoApp
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=AdocaoApp;User ID=sa;Password=1q2w3e4r@#$;Encrypt=True;TrustServerCertificate=True;";
        static void Main(String[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Database.Connection.Close();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer:");
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("1 - Verificar animais disponives");
            Console.WriteLine("2 - Cadastrar novo animal");
            Console.WriteLine("3 - Listar por categoria");
            Console.WriteLine("4 - Busca por raça");
            Console.WriteLine("5 - Criar nova categoria");
            short opition = short.Parse(Console.ReadLine());

            switch (opition)
            {
                case 5:
                    CreateCategoryScreen.Load();
                    break;

                    
                default: Load(); break; 
            }
        }
    }
}
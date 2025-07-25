using AdocaoApp;
using AdocaoApp.Screens.AnimalScreens;
using AdocaoApp.Screens.BreedScreens;
using AdocaoApp.Screens.CategoryScreens;
using AdocaoApp.Screens.DonorScreens;
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
            Console.WriteLine("1 - Gestão de animais");
            Console.WriteLine("2 - Gestão de categorias");
            Console.WriteLine("3 - Gestão de raças de animais");
            Console.WriteLine("4 - Gestão de Doador");
            short opition = short.Parse(Console.ReadLine());

            switch (opition)
            {
                case 1:
                    CreateAnimalScreen.Load();
                    break;
                    
                case 2:
                    MenuCategoryScreen.Load();
                    break;

                case 3:
                    MenuBreedScreen.Load();
                    break;

                case 4:
                    MenuDonorScreen.Load();
                    break;
                    
                default: Load(); break; 
            }
        }
    }
}
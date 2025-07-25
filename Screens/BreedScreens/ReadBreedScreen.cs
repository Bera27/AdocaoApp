using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.BreedScreens
{
    public class ReadBreedScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de raça cadastradas");
            Console.WriteLine();
            ReadBreed();
            Console.ReadKey();
            MenuBreedScreen.Load();
        }

        public static void ReadBreed()
        {
            var repo = new BreedRepository(Database.Connection);

            var breeds = repo.GetCategoryName();

            foreach (var b in breeds)
            {
                Console.WriteLine($"ID: {b.Id} - Nome: {b.Name} | Categoria: {b.Category.Name}");
            }
        }
    }
}
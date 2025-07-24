using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.CategoryScreens
{
    public static class ReadCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Categoria disponiveis:");
            Console.WriteLine();
            ReadCategory();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void ReadCategory()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.GetAll();

            foreach (var c in categories)
            {
                Console.WriteLine($"ID: {c.Id} - {c.Name}");
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
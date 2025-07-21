using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.CategoryScreens
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de nova categoria");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome:");
            string name = Console.ReadLine();

            CreateCategory(new Category
            {
                Name = name
            });
            Console.ReadKey();
            Program.Load();
        }

        public static void CreateCategory(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);

                Console.WriteLine("Categoria criada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel criar!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
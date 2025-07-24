using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.CategoryScreens
{
    public static class UpdateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar categoria:");
            Console.WriteLine();
            Console.WriteLine("Qual o ID da categoria:");
            int id = int.Parse(Console.ReadLine());
            GetCategory(id);
        }

        public static void UpdateCategory(Category category)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Update(category);
                Console.WriteLine("Categoria salva com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel atualizar!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetCategory(int id)
        {
            Console.Clear();
            var repository = new Repository<Category>(Database.Connection);
            var category = repository.Get(id);

            Console.WriteLine($"ID: {category.Id} - Nome: {category.Name}");

            Console.WriteLine();
            Console.WriteLine("Esse é a categoria desejada? S/N");
            string opition = Console.ReadLine().ToUpper().Substring(0, 1);

            if (opition == "N")
            {
                Console.WriteLine("Voltando...");
                Thread.Sleep(3000);
                MenuCategoryScreen.Load();
            }
            else if (opition == "S")
            {
                Console.WriteLine("Nome:");
                string name = Console.ReadLine();

                UpdateCategory(new Category
                {
                    Id = id,
                    Name = name
                });
            }
            else
                Console.WriteLine("Resposta invalida;");

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
    }
}
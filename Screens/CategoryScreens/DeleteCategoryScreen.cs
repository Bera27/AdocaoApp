using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir Categoria");
            Console.WriteLine();
            Console.WriteLine("Informe o ID:");
            int id = int.Parse(Console.ReadLine());

            GetCategory(id);
        }

        public static void DeleteCategory(int id)
        {
            try
            {
                var repositories = new Repository<Category>(Database.Connection);
                repositories.Delete(id);
                Console.WriteLine("Categoria excluida com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir!");
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
                DeleteCategory(id);
            }
            else
                Console.WriteLine("Resposta invalida;");

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }
    }
}
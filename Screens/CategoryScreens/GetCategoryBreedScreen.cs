using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.CategoryScreens
{
    public class GetCategoryBreedScreen
    {
        public static void Load()
        {
            Console.Write("Digite o nome da categoria: ");
            string categoryName = Console.ReadLine()?.Trim() ?? "";

            ShowBreeds(categoryName);

            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        private static void ShowBreeds(string categoryName)
        {
            var repo = new BreedRepository(Database.Connection);
            var breeds = repo.GetByCategoryName(categoryName);

            if (!breeds.Any())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Nenhuma raça encontrada para a categoria '{categoryName}'.");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Raças na categoria '{categoryName}':");
            Console.ResetColor();

            foreach (var b in breeds)
            {
                Console.WriteLine($"  • [{b.Id}] {b.Name}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.BreedScreens
{
    public static class CreateBreedScreen
    {
        public static void Load()
        {
            var categoryRepo = new Repository<Category>(Database.Connection);
            var categories = categoryRepo.GetAll();

            Console.Clear();
            Console.WriteLine("Cadastro de nova raça de animal");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("Nome:");
            string name = Console.ReadLine();


            if (!categories.Any())
            {
                Console.WriteLine("Não há categorias cadastradas. Cadastre uma antes.");
                Console.ReadKey();
                Program.Load();
            }

            Console.WriteLine("Escolha uma categoria:");
            Console.WriteLine("----------------------");

            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
                Console.WriteLine($"-----------------------");
            }
            int categoryId = int.Parse(Console.ReadLine());

            CreateBreend(new Breed
            {
                Name = name,
                CategoryId = categoryId
            });

            Console.ReadKey();
            Program.Load();
        }

        public static void CreateBreend(Breed breed)
        {
            try
            {
                var repositories = new Repository<Breed>(Database.Connection);
                repositories.Create(breed);

                Console.WriteLine("Raça de animal criada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel salvar!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
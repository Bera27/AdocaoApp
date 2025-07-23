using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.AnimalScreens
{
    public static class CreateAnimalScreen
    {
        public static void Load()
        {
            var breedRepo = new Repository<Breed>(Database.Connection);
            var donorRepo = new Repository<Donor>(Database.Connection);
            var breeds = breedRepo.GetAll();
            var donors = donorRepo.GetAll();

            Console.Clear();
            Console.WriteLine("Cadastro de animal");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Mêses de vida");
            int ageMonths = int.Parse(Console.ReadLine());
            Console.Clear();

            if (!donors.Any())
            {
                Console.WriteLine("Cadastre um Doador antes.");
                Program.Load();
            }

            Console.WriteLine("Escolha o ID do doador");
            Console.WriteLine("----------------------");

            foreach (var item in donors)
            {
                Console.WriteLine($"ID: {item.Id} - Nome: {item.Name} | Telefone: {item.Phone}");
                Console.WriteLine("-----------------------------------------------------------");
            }
            int donorId = int.Parse(Console.ReadLine());
            Console.Clear();

            if (!breeds.Any())
            {
                Console.WriteLine("Cadastre a raça antes.");
                Program.Load();
            }

            Console.WriteLine("Escolha o ID da raça");
            Console.WriteLine("----------------------");

            foreach (var item in breeds)
            {
                Console.WriteLine($"ID: {item.Id} - Nome: {item.Name}");
                Console.WriteLine("-----------------------------------------------------------");
            }
            int breedId = int.Parse(Console.ReadLine());

            CreateAnimal(new Animal
            {
                BreedId = breedId,
                DonorId = donorId,
                AgeMonths = ageMonths,
                AdmissionDate = DateTime.Now
            });
            Console.ReadKey();
            Program.Load();
            
        }

        public static void CreateAnimal(Animal animal)
        {
            try
            {
                var repositories = new Repository<Animal>(Database.Connection);
                repositories.Create(animal);
                Console.WriteLine("Animal cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel cadastar animal");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
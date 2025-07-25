using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.AnimalScreens
{
    public static class ReadAnimalScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de animais diponoveis para adoção");
            Console.WriteLine();
            ReadAnimal();
            Console.ReadLine();
            MenuAnimalScreen.Load();
        }

        public static void ReadAnimal()
        {
            var repo = new AnimalRepository(Database.Connection);
            var animais = repo.GetBreedAndDonorName();

            foreach (var a in animais)
            {
                Console.WriteLine($"ID: {a.Id} - Raça: {a.BreedName} | Categoria: {a.CategoryName} | Mêses: {a.AgeMonths} | Data de cadastro: {a.AdmissionDate:d} | Doador: {a.DonorName} | Telefone: {a.DonorPhone}");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
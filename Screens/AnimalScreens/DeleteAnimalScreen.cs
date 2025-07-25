using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.AnimalScreens
{
    public class DeleteAnimalScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir dados de animal");
            Console.WriteLine();
            Console.WriteLine("Informe o ID do animal:");
            int id = int.Parse(Console.ReadLine());
            GetAnimal(id);
        }

        public static void DeleteAniamal(int id)
        {
            try
            {
                var repositories = new Repository<Animal>(Database.Connection);
                repositories.Delete(id);
                Console.WriteLine("Dados do animal excluido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetAnimal(int id)
        {
            Console.Clear();
            var repository = new Repository<Animal>(Database.Connection);
            var animal = repository.Get(id);

            Console.WriteLine($"ID: {animal.Id} - Raça: {animal.BreedName}| Categoria: {animal.CategoryName} | Doador: {animal.DonorName} | Telefone do doador: {animal.DonorPhone}");

            Console.WriteLine();
            Console.WriteLine("Esse é o Animal desejado? S/N");
            string opition = Console.ReadLine().ToUpper().Substring(0, 1);

            if (opition == "N")
            {
                Console.WriteLine("Voltando...");
                Thread.Sleep(3000);
                MenuAnimalScreen.Load();
            }
            else if (opition == "S")
            {
                DeleteAniamal(id);
            }
            else
                Console.WriteLine("Resposta invalida;");

            Console.ReadKey();
            MenuAnimalScreen.Load();
        }
    }
}
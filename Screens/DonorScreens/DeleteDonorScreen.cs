using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.DonorScreens
{
    public static class DeleteDonorScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir doador");
            Console.WriteLine();
            Console.WriteLine("Informe o ID do doador:");
            int id = int.Parse(Console.ReadLine());
            GetDonor(id);
        }

        public static void DeleteDonor(int id)
        {
            try
            {
                var repositories = new Repository<Donor>(Database.Connection);
                repositories.Delete(id);
                Console.WriteLine("Doador excluido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir!");
                Console.WriteLine(ex.Message);
            }
        }

        public static void GetDonor(int id)
        {
            Console.Clear();
            var repository = new Repository<Donor>(Database.Connection);
            var donor = repository.Get(id);

            Console.WriteLine($"ID: {donor.Id} - Nome: {donor.Name} | Telefone: {donor.Phone}");

            Console.WriteLine();
            Console.WriteLine("Esse é o Doador desejado? S/N");
            string opition = Console.ReadLine().ToUpper().Substring(0, 1);

            if (opition == "N")
            {
                Console.WriteLine("Voltando...");
                Thread.Sleep(3000);
                MenuDonorScreen.Load();
            }
            else if (opition == "S")
            {
                DeleteDonor(id);
            }
            else
                Console.WriteLine("Resposta invalida;");

            Console.ReadKey();
            MenuDonorScreen.Load();
        }
    }
}
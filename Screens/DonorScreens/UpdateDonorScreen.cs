using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.DonorScreens
{
    public static class UpdateDonorScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Doador");
            Console.WriteLine();
            Console.WriteLine("Informe o ID do doador:");
            int id = int.Parse(Console.ReadLine());
            GetDonor(id);
        }

        public static void UpdateDonor(Donor donor)
        {
            try
            {
                var repositories = new Repository<Donor>(Database.Connection);
                repositories.Update(donor);
                Console.WriteLine("Doador salvo com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel atualizar!");
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
                Console.WriteLine("Nome:");
                string name = Console.ReadLine();

                Console.WriteLine("Telefone:");
                string phone = Console.ReadLine();

                UpdateDonor(new Donor
                {
                    Id = id,
                    Name = name,
                    Phone = phone
                });
            }
            else
                Console.WriteLine("Resposta invalida;");

            Console.ReadKey();
            MenuDonorScreen.Load();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.DonorScreens
{
    public static class CreateDonorScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de doador:");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Nome");
            string name = Console.ReadLine();

            Console.WriteLine("Telefone");
            string phone = Console.ReadLine();

            CreateDonor(new Donor
            {
                Name = name,
                Phone = phone
            });
            Console.ReadKey();
            Program.Load();
        }

        public static void CreateDonor(Donor donor)
        {
            try
            {
                var repositories = new Repository<Donor>(Database.Connection);
                repositories.Create(donor);
                Console.WriteLine("Doador cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel cadastrar doador");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdocaoApp.Models;
using AdocaoApp.Repositories;

namespace AdocaoApp.Screens.DonorScreens
{
    public static class ReadDonorScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Doadores de animais");
            Console.WriteLine();
            ReadDonor();
            Console.ReadKey();
            MenuDonorScreen.Load();
        }

        public static void ReadDonor()
        {
            var repositories = new Repository<Donor>(Database.Connection);
            var donors = repositories.GetAll();

            foreach (var d in donors)
            {
                Console.WriteLine($"ID: {d.Id} - Nome: {d.Name} | Telefone: {d.Phone}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
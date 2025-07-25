using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdocaoApp.Screens.DonorScreens
{
    public static class MenuDonorScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de doadores:");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar novo doador de animal");
            Console.WriteLine("2 - Listar Doadores disponiveis");
            Console.WriteLine("3 - Atualizar dados de um doador");
            Console.WriteLine("4 - Excluir dados de um doador");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine();
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateDonorScreen.Load();
                    break;

                case 2:
                    ReadDonorScreen.Load();
                    break;

                case 3:
                    UpdateDonorScreen.Load();
                    break;

                case 4:
                    DeleteDonorScreen.Load();
                    break;

                default: Program.Load(); break;
            }
        }
    }
}
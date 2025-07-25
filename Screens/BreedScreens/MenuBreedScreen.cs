using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdocaoApp.Screens.BreedScreens
{
    public class MenuBreedScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Raças de animais:");
            Console.WriteLine("");
            Console.WriteLine("1 - Cadastrar nova raça de animal");
            Console.WriteLine("2 - Listar raças cadastradas");
            Console.WriteLine("4 - Voltar");
            Console.WriteLine();
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateBreedScreen.Load();
                    break;

                case 2:
                    ReadBreedScreen.Load();
                    break;

                default: Program.Load(); break;
            }
        }
    }
}
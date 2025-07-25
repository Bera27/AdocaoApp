using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdocaoApp.Screens.AnimalScreens
{
    public static class MenuAnimalScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de animais");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar novo animal");
            Console.WriteLine("2 - Listar animais disponiveis para adoção");
            Console.WriteLine("3 - Atualizar dados de um animal");
            Console.WriteLine("4 - Excluir dados de um animal");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine();
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateAnimalScreen.Load();
                    break;
                
                case 2:
                    ReadAnimalScreen.Load();
                    break;

                case 3:
                    break;

                case 4:
                    DeleteAnimalScreen.Load();
                    break;

                default: Program.Load(); break;
            }
        }
    }
}
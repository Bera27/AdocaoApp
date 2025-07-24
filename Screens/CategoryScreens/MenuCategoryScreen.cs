using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdocaoApp.Screens.CategoryScreens
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categoria:");
            Console.WriteLine("");
            Console.WriteLine("1 - Criar categoria");
            Console.WriteLine("2 - Listar categorias disponiveis");
            Console.WriteLine("3 - Atualizar categoria");
            Console.WriteLine("4 - Excluir categoria");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine();
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateCategoryScreen.Load();
                    break;

                case 2:
                    ReadCategoryScreen.Load();
                    break;

                case 3:
                    UpdateCategoryScreen.Load();
                    break;

                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                
                default: Program.Load(); break;
            } 
        }
    }
}
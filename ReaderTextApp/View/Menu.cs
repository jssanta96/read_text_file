using System;
using ReaderTextApp.Controller;
using System.Collections.Generic;
using System.Text;

namespace ReaderTextApp.View
{
    class Menu
    {

        public int GetMainMenu()
        { 
            int option ;

            do
            {

                Console.WriteLine("*****************************************");
                Console.WriteLine(@" |1| Sin filtrar");
                Console.WriteLine(@" |2| Palabras que inicien con la letra: t");
                Console.WriteLine(@" |3| Palabras de 5 caracteres");
                Console.WriteLine(@" |4| Palabras palindromas");
                Console.WriteLine(@" |5| Salir");
                Console.WriteLine("*****************************************");


                option = int.Parse(Console.ReadLine());

                MenuController menuController = new MenuController();
                string result = menuController.ViewResult(option);
                Console.WriteLine(result);

            } while (option != 5);
                
           
            return 0;
        }
    }
}

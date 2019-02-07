using ReaderTextApp.View;
using System;

namespace ReaderTextApp
{
    static class Program
    {
        static void Main(string[] args)
        {
           

            Menu menu = new Menu();
            menu.GetMainMenu();
            
            Console.ReadKey();
        }
    }
}

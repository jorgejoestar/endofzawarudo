using System;
using System.Diagnostics;

namespace RandomTest
{
    public class Menu
    {
        private static void MenuEntry(int menuEntry)
        {
            switch (menuEntry)
            {
                    case 1:
                        
                        JojoRPG.Story();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
            }
        }
        public static void MenuScreen()
        {
            Console.WriteLine("***THE LEGACY OF THE LEG-MACHINE: LEGIT LEGENDARY***");
            Console.WriteLine("Start Game [1]");
            Console.WriteLine("Exit [0]");
            MenuEntry(Int32.Parse(Console.ReadLine()));
        }
    }
}
using System;

namespace RandomTest
{
    public class Player
    {
        public static int lvl = 1;
        public static int PlayerExp = 0;
        public static int ExpNeeded = 100 + (lvl * 50);
        public static int att = 10 + lvl;

        public static void LvlUp()
        {
            Random rnd = new Random();
            if (PlayerExp == ExpNeeded)
            {
                Console.WriteLine("Level Up!");
                att += rnd.Next(2, 5);
            }
        }
    }
}
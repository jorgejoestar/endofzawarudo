using System;
namespace RandomTest
{
    public class Enemy
    {
       

        public static Random rnd = new Random();

        public static double health = rnd.Next(100, 250);
        public static bool isAlive = true;
        public static int gold = rnd.Next(100, 300);
        public static int exp = rnd.Next(75, 200);
        public static int def = rnd.Next(7, 10);

        public static void CheckAlive()
        {
            if (health <= 0)
            {
                Console.WriteLine("Der Gegner wurde besiegt!!!");
                Victory.VictoryScreen();
                //Player.PlayerExp = Player.PlayerExp + Enemy.exp;
                isAlive = false;
                
            }
            else
            {
                isAlive = true;
            }
        }


    }
}
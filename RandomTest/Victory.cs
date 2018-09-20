using System;

namespace RandomTest
{
    public class Victory
    {
        public static void VictoryScreen()
        {
            Console.WriteLine("Sie haben gewonnen!");
            Console.WriteLine(" Sie erhalten {0} Gold!", Enemy.gold);
            Console.WriteLine("Sie erhalten {0} EXP!", Enemy.exp);
            Player.PlayerExp = Player.PlayerExp + Enemy.exp;
            Player.LvlUp();
            Console.ReadKey();
            JojoRPG.isBattling = false;
            BitesTheDust.thirdBombCount += 1;
            Scene.Scene3();

        }
    }
}
using System;

namespace RandomTest
{
    public class DamageCalc
    {
        public static void StarF()
        {
            Enemy.health -= (Starfinger.damage * Player.att) / Enemy.def;
        }

        public static void StarFCrit()
        {
            Console.WriteLine("Critical Hit!");
            Enemy.health -= ((Starfinger.damage * Player.att) * Starfinger.crit) / Enemy.def;
        }
        
    }
}
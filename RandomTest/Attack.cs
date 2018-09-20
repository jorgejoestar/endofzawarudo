using System;

namespace RandomTest
{
    public class Attack
    {
        
        public static void StarfingerAtt()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            int rndtext = rnd.Next(1, 4);
            int crit = rnd2.Next(1, 5);
            Console.WriteLine("Star Platinum extends its fingers to blind the enemy.");
            if (crit == 1 || crit == 2)
            {
                DamageCalc.StarFCrit();
                /*Console.WriteLine("Critical Hit!");
                Enemy.health -= Starfinger.damage * Starfinger.crit;*/
            }
            else
            {
                DamageCalc.StarF();
                //Enemy.health -= Starfinger.damage;
            }
            Console.WriteLine("Gegner: {0}", Enemy.health);
        }

        public static void PunchAtt()
        {
            
        }

        public static void StandJudgement()
        {
            
        }
    }
}
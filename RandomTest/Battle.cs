using System;

namespace RandomTest
{
    public class Battle
    {
        public static void BattleScreen()
        {
            JojoRPG.isBattling = true;
            BattleChoice();
        }
        
        public static void BattleChoice()
        {
            //while (isBattling)
            
                Console.WriteLine("[1] Star Finger");
                Console.WriteLine("[2] Punch");
                Console.WriteLine("[3] Stand Judgement");
                Console.WriteLine("[4] Nigerundayo");
                CheckEntry(Int32.Parse(Console.ReadLine()));                                                     
                Enemy.CheckAlive(); 
        }
       
        private static void CheckEntry(int entry)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            int rndtext = rnd.Next(1, 4);
            int crit = rnd2.Next(1, 5);

            switch (entry)
            {
                case 1:
                    /*Console.WriteLine("Star Platinum extends its fingers to blind the enemy.");
                    if (crit == 1 || crit == 2)
                    {
                        Console.WriteLine("Critical Hit!");
                        Enemy.health -= Starfinger.damage * Starfinger.crit;
                    }
                    else
                    {
                        Enemy.health -= Starfinger.damage;
                    }

                    Console.WriteLine("Gegner: {0}", Enemy.health);
                    //Enemy.CheckAlive();*/
                   Attack.StarfingerAtt();
                    
                    break;
                case 2:
                    Attack.PunchAtt();
                    break;
                case 3:
                    Attack.StandJudgement();
                    break;
                case 4:
                    Flee.Nigerundayo();
                    break;
            }
                    
        }

    }
}
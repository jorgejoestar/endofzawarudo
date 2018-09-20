using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RandomTest

{
    public class JojoRPG
    {
        public static bool isBattling = true;
        private static bool isPlaying = true;
        private static bool isAlive = true;
        public static bool inStory = false;

        public void start()
        {
            
                Menu.MenuScreen();
                //BattleChoice();
                
            
        }

        public static void Story()
        {
            /*while (inStory)
            {
                Scene.Scene1();
            }*/
            Scene.Scene3();

        }
        
        public static void Battling()
        {
            while (isBattling)
            {
                Battle.BattleScreen();
            }
        }
        /*public static void BattleChoice()
        {
            while (isBattling)
            {
                Console.WriteLine("[1] Star Finger");
                            Console.WriteLine("[2] Punch");
                            Console.WriteLine("[3] Stand Judgement");
                            Console.WriteLine("[4] Nigerundayo");
                            CheckEntry(Int32.Parse(Console.ReadLine()));                                                     
                            Enemy.CheckAlive();
            }
            
        }*/

        /*private static void CheckEntry(int entry)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            int rndtext = rnd.Next(1, 4);
            int crit = rnd2.Next(1, 5);


                    switch (entry)
                    {
                        case 1:
                            Console.WriteLine("Star Platinum extends its fingers to blind the enemy.");
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
                            //Enemy.CheckAlive();
                            break;
                    }
                    
                }*/


    }

 }



    


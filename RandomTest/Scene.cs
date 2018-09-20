using System;
using System.Diagnostics;

namespace RandomTest
{
    public class Scene
    {
        /*public static Scene Exit()
        {
            Environment.Exit(0);
            return null;
        }*/
        Scene[] scenes = new Scene[]{Scene3(), };
        public static Scene Scene1()
        {
            Console.WriteLine("You are sitting in a jail cell.");
            Console.WriteLine("You were already allowed to leave 4 weeks ago. It was your own decision to stay here.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Because you are a threat to your own self.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You are loafing around, doing nothing. The other prisoners ");
            
            //return Scene.Exit();
            return null;
        }

        public static Scene Scene2()
        {
            return Scene2();
        }

        public static Scene Scene3()
        {
            Console.Clear();
            Console.WriteLine("**JULY 15TH 09:30 AM, MORIOH TOWN, KAWAJIRI'S HOUSE**");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ms. Kawajiri: Hayato! Are you up?");
            switch (BitesTheDust.thirdBombCount)
            {
                case 0:
                    Console.WriteLine("Hayato: *sleepy* Yeah mom!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Hayato: (I need to pay attention to my father. He's acting really strange lately.");
                    Console.ReadLine();
                    Console.Clear();
                    JojoRPG.isBattling = true;
                    JojoRPG.Battling();
                    break;
                                
                case 1:
                    Console.WriteLine("Hayato: Y-yes, mom!");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Hayato: (Something feels odd... Almost like i've lived this moment already through.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Hayato: (Maybe it's just a deja-vu. Anyways, let's get ready for school.)");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 2:
                    break;
            }

            return null;
        }
    }
}
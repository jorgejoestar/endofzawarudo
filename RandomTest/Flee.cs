using System;

namespace RandomTest
{
    public class Flee
    {
        public static void Nigerundayo()
        {
            Random rnd = new Random();
            int rndtxt = rnd.Next(1, 3);
            switch (rndtxt)
            {
                   case 1:
                       Console.WriteLine("You fled cowardly.");
                       Console.ReadLine();
                       Console.Clear();
                       Console.WriteLine("Your self-esteem has been lowered.");
                       Console.ReadLine();
                       Console.Clear();
                       Console.WriteLine("... not, because expressions like 'honor' and 'moral' are strange to you. Also, you don't even own a Self-esteem stat.");
                       break;
                   case 2:
                       Console.WriteLine("You start to run away while yelling 'NIGERUNDAYO, SMOKEY'.");
                       Console.ReadLine();
                       Console.Clear();
                       Console.WriteLine("Then you remember that Smokey has already passed away years ago. You keep on running away sadly.");
                       Console.ReadLine();
                       Console.Clear();
                       
                       break;
            }
            
            JojoRPG.isBattling = false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class AIPlayer : Player
    {
        public AIPlayer()
        {

        }
        
        public override void Gestures()
        {
            string randomGestureString = name + " chooses his gesture at random...\n";
            Console.Clear();
            ScrollingText(randomGestureString);
            System.Threading.Thread.Sleep(1000);
            Random rndGest = new Random();
            int aiChoice = Convert.ToInt32(rndGest.Next(0, 4));
            string aiGesture = name + " chooses " + gestures[aiChoice] + "!";
            ScrollingText(aiGesture);
            choice = Convert.ToString(aiChoice);
            Console.WriteLine("\n\nHit [Enter] to continue... ");
            Console.ReadLine();
        }

        public override void ChooseName()
        {
            Console.Clear();
            Console.WriteLine("Name your opponent (like in Pokemon): ");
            name = Console.ReadLine();
            while (name == "")
            {
                Console.Clear();
                Console.WriteLine("You didn't enter anything. Try again.");
                Console.WriteLine("\nName your opponent (like in Pokemon): ");
                name = Console.ReadLine();
            }
        }
    }
}

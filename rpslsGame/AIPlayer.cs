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
        
        public override void ChooseGesture()
        {

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

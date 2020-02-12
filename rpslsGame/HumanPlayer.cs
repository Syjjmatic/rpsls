using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class HumanPlayer : Player
    {
        public HumanPlayer()
        {

        }
        public override void ChooseGesture()
        {

        }

        public override void ChooseName()
        {
            Console.Clear();
            Console.WriteLine("Enter player name: ");
            name = Console.ReadLine();
            while (name == "")
            {
                Console.Clear();
                Console.WriteLine("You didn't enter anything. Try again.");
                Console.WriteLine("\nEnter player name: ");
                name = Console.ReadLine();
            }

        }
    }
}

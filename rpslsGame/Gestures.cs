using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Gestures
    {
        List<string> gestures;
        public Gestures()
        {
            gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }

        public void Test()
        {
            for(int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(gestures[i]);
            }

        }
    }
}

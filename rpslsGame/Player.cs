using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    abstract class Player
    {
        public string name;
        public int score;
        public string choice;
        public List<string> gestures;
        public string nothingEntered;
        public string playerNameRequest;

        public Player()
        {
            gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            score = 0;
            nothingEntered = "You didn't enter anything. Try again.\n";
        }

        public void ScrollingText(string theString)
        {
            for (int i = 0; i < theString.Length; i++)
            {
                Console.Write(theString[i]);
                System.Threading.Thread.Sleep(30);
            }
        }

        public abstract void ChooseName();

        public abstract void Gestures();

    }
}

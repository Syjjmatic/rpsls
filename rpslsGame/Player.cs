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

        public Player()
        {
            score = 0;
        }

        public abstract void ChooseGesture();

        public abstract void ChooseName();
    }
}

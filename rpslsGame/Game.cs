using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Game
    {
        HumanPlayer humanPlayer = new HumanPlayer();
        AIPlayer aiPlayer = new AIPlayer();
        Gestures gestures = new Gestures();

        public Game()
        {

        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!\nRules: BEST OUT OF 3 WINS.");
            Console.WriteLine("\nIs this game [1] or [2] players?");
            string input = Console.ReadLine();
        }

        public void Initialize()
        {
            StartGame();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Game
    {
        HumanPlayer humanPlayer1;
        HumanPlayer humanPlayer2;
        AIPlayer aiPlayer2;
        Gestures gestures;
        string input;

        public Game()
        {

        }

        public void GameSetUp()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!\nRules: BEST OUT OF 3 WINS.");
            Console.WriteLine("\nOne or two players? [Type '1' or '2']");
            input = Console.ReadLine();
            Console.Clear();

            while (input != "1" && input != "2")
            {
                Console.WriteLine("Your input is incorrect. Please type a '1' or '2'.");
                input = Console.ReadLine();
                Console.Clear();
            }

            if(input == "1")
            {
                humanPlayer1 = new HumanPlayer();
                aiPlayer2 = new AIPlayer();

                Console.WriteLine("Enter player one's name: ");
                humanPlayer1.name = Console.ReadLine();
                Console.WriteLine("\nName your opponent (like in Pokemon): ");
                aiPlayer2.name = Console.ReadLine();

            }
            else if(input == "2")
            {
                humanPlayer1 = new HumanPlayer();
                humanPlayer2 = new HumanPlayer();

                Console.WriteLine("Enter player one's name: ");
                humanPlayer1.name = Console.ReadLine();
                Console.WriteLine("\nEnter player two's name: ");
                humanPlayer2.name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You did not enter '1' or '2'. Please try again.");
            }
        }

        public void Initialize()
        {
            GameSetUp();
        }
    }
}

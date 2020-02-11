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
        string choice1;
        string choice2;
        string aiChoice;

        public Game()
        {
            gestures = new Gestures();
            humanPlayer1 = new HumanPlayer();
            humanPlayer2 = new HumanPlayer();
            aiPlayer2 = new AIPlayer();
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
                Console.WriteLine("Enter player one's name: ");
                humanPlayer1.name = Console.ReadLine();
                while (humanPlayer1.name == "")
                {
                    Console.Clear();
                    Console.WriteLine("You didn't enter anything. Try again.");
                    Console.WriteLine("\nEnter player one's name: ");
                    humanPlayer1.name = Console.ReadLine();
                }
                Console.WriteLine("\nName your opponent (like in Pokemon): ");
                aiPlayer2.name = Console.ReadLine();
                while(aiPlayer2.name == "")
                {
                    Console.Clear();
                    Console.WriteLine("You didn't enter anything. Try again.");
                    Console.WriteLine("\nName your opponent (like in Pokemon): ");
                    aiPlayer2.name = Console.ReadLine();
                }
            }
            else if(input == "2")
            {
                Console.WriteLine("Enter player one's name: ");
                humanPlayer1.name = Console.ReadLine();
                Console.WriteLine("\nEnter player two's name: ");
                humanPlayer2.name = Console.ReadLine();
            }
        }

        public void MakeChoicePlayer1()
        {
            Console.Clear();
            Console.WriteLine("Okay, " + humanPlayer1.name + ", choose your gesture! [Pick by typing the corresponding number on the left.]");
            for (int i = 0; i < gestures.gestures.Count; i++)
            {
                Console.WriteLine(i + ".) " + gestures.gestures[i]);
            }
            string choice1 = Console.ReadLine();
            while (choice1 != "0" && choice1 != "1" && choice1 != "2" && choice1 != "3" && choice1 != "4")
            {
                Console.WriteLine("You did choose a correct option. Try again.");
                choice1 = Console.ReadLine();
            }

        }

        public void MakeChoicePlayer2()
        {
            Console.Clear();
             Console.WriteLine("Okay, " + humanPlayer2.name + ", choose your gesture!");
            for (int i = 0; i < gestures.gestures.Count; i++)
            {
                Console.WriteLine(i + ".) " + gestures.gestures[i]);
            }
            string choice2 = Console.ReadLine();
        }

        public void MakeChoiceAI()
        {
            Console.Clear();
            Console.WriteLine(aiPlayer2.name + " chooses his gesture at random...");
            Random rndGest = new Random();
            int intRndGest = Convert.ToInt32(rndGest.Next(0, 4));
            Console.WriteLine(aiPlayer2.name + " chooses " + gestures.gestures[intRndGest]);
        }

        public void Initialize()
        {
            GameSetUp();
            MakeChoicePlayer1();
            MakeChoicePlayer2();
            MakeChoiceAI();
        }
    }
}

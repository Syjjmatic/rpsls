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
        int aiChoice;
        string intro;
        string rules;

        public Game()
        {
            gestures = new Gestures();
            humanPlayer1 = new HumanPlayer();
            humanPlayer2 = new HumanPlayer();
            aiPlayer2 = new AIPlayer();
        }

        public void ScrollingText(string theString)
        {
            for (int i = 0; i < theString.Length; i++)
            {
                Console.Write(theString[i]);
                System.Threading.Thread.Sleep(50);
            }
        }

        public void Intro()
        {
            intro = "Welcome to Rock, Paper, Scissors, Lizard, Spock!";
            rules = "Rules: BEST OUT OF 3 WINS." +
                "\nROCK beats SCISSORS and LIZARD!" +
                "\nPAPER beats ROCK and SPOCK!" +
                "\nSCISSORS beats PAPER and LIZARD!" +
                "\nLIZARD beats SPOCK and and PAPER!" +
                "\nSPOCK beats SCISSORS and ROCK!\n";
            ScrollingText(intro);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            ScrollingText(rules);
        }

        //public void SelectPlayers()
        //{
        //    string prompt = "\nOne or two players? [Type '1' or '2']";
        //    for ()
        //    {

        //    }
        //}

        public void GameSetUp()
        {
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
                while (humanPlayer1.name == "")
                {
                    Console.Clear();
                    Console.WriteLine("You didn't enter anything. Try again.");
                    Console.WriteLine("\nEnter player one's name: ");
                    humanPlayer1.name = Console.ReadLine();
                }
                Console.WriteLine("\nEnter player two's name: ");
                humanPlayer2.name = Console.ReadLine();
                while (humanPlayer2.name == "")
                {
                    Console.Clear();
                    Console.WriteLine("You didn't enter anything. Try again.");
                    Console.WriteLine("\nEnter player two's name: ");
                    humanPlayer2.name = Console.ReadLine();
                }
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
            choice1 = Console.ReadLine();

            while (choice1 != "0" && choice1 != "1" && choice1 != "2" && choice1 != "3" && choice1 != "4")
            {
                Console.Clear();
                Console.WriteLine("You did choose a correct option. Try again.");
                for (int i = 0; i < gestures.gestures.Count; i++)
                {
                    Console.WriteLine(i + ".) " + gestures.gestures[i]);
                }

                choice1 = Console.ReadLine();
            }

        }

        public void MakeChoicePlayer2()
        {
            Console.Clear();
            Console.WriteLine("Okay, " + humanPlayer2.name + ", choose your gesture! [Pick by typiong the corresponding number on the left.]");
            for (int i = 0; i < gestures.gestures.Count; i++)
            {
                Console.WriteLine(i + ".) " + gestures.gestures[i]);
            }
            choice2 = Console.ReadLine();

            while (choice2 != "0" && choice2 != "1" && choice2 != "2" && choice2 != "3" && choice2 != "4")
            {
                Console.Clear();
                Console.WriteLine("You did choose a correct option. Try again.");
                for (int i = 0; i < gestures.gestures.Count; i++)
                {
                    Console.WriteLine(i + ".) " + gestures.gestures[i]);
                }

                choice2 = Console.ReadLine();
            }
        }

        public void MakeChoiceAI()
        {
            Console.Clear();
            Console.WriteLine(aiPlayer2.name + " chooses his gesture at random...");
            Random rndGest = new Random();
            aiChoice = Convert.ToInt32(rndGest.Next(0, 4));
            Console.WriteLine(aiPlayer2.name + " chooses " + gestures.gestures[aiChoice] + "!");
            choice2 = Convert.ToString(aiChoice);
            Console.WriteLine("\nHit any key to continue... ");
            Console.ReadLine();
        }

        public void CompareChoicesHumanHuman()
        {
            if (choice1 == choice2)
            {
                Console.Clear();
                Console.WriteLine("Tie! Go again!");
            }
            else if (choice1 == "0" && (choice2 == "2" || choice2 == "3"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "1" && (choice2 == "0" || choice2 == "4"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "2" && (choice2 == "1" || choice2 == "3"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "3" && (choice2 == "1" || choice2 == "4"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "4" && (choice2 == "2" || choice2 == "0"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(humanPlayer2.name + " wins the round!");
                humanPlayer2.score++;
            }
            Console.WriteLine("\nHit any key to continue...");
            Console.ReadLine();
        }

        public void CompareCoicesHumanAI()
        {
            if (choice1 == choice2)
            {
                Console.Clear();
                Console.WriteLine("Tie! Go again!");
            }
            else if (choice1 == "0" && (choice2 == "2" || choice2 == "3"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "1" && (choice2 == "0" || choice2 == "4"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "2" && (choice2 == "1" || choice2 == "3"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "3" && (choice2 == "1" || choice2 == "4"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else if (choice1 == "4" && (choice2 == "2" || choice2 == "0"))
            {
                Console.Clear();
                Console.WriteLine(humanPlayer1.name + " wins the round!");
                humanPlayer1.score++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(aiPlayer2.name + " wins the round!");
                aiPlayer2.score++;
            }
            Console.WriteLine("\nHit any key to continue...");
            Console.ReadLine();

        }

        public void Initialize()
        {
            Intro();
            GameSetUp();
            if (input == "1")
            {
                while (humanPlayer1.score < 2 && aiPlayer2.score < 2)
                {
                    MakeChoicePlayer1();
                    MakeChoiceAI();
                    CompareCoicesHumanAI();
                }
                if (humanPlayer1.score > aiPlayer2.score)
                {
                    Console.Clear();
                    Console.WriteLine(humanPlayer1.name + " WINS THE GAME!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(aiPlayer2 + " WINS THE GAME!!");
                }
            }
            else if (input == "2")
            {
                while (humanPlayer1.score < 2 && humanPlayer2.score < 2)
                {
                    MakeChoicePlayer1();
                    MakeChoicePlayer2();
                    CompareChoicesHumanHuman();
                   
                }
                if (humanPlayer1.score > humanPlayer2.score)
                {
                    Console.Clear();
                    Console.WriteLine(humanPlayer1.name + " WINS THE GAME!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(humanPlayer2.name + " WINS THE GAME!!");

                }

            }
        }
    }
}

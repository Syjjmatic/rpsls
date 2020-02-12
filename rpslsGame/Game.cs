using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Game
    {
        string intro;
        string rules;
        Player player1;
        Player player2;

        public Game()
        {

        }

        public void ScrollingText(string theString)
        {
            for (int i = 0; i < theString.Length; i++)
            {
                Console.Write(theString[i]);
                System.Threading.Thread.Sleep(30);
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
                "\nSPOCK beats SCISSORS and ROCK!";
            ScrollingText(intro);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            ScrollingText(rules);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\n\nPress [Enter] to continue...");
            Console.ReadLine();
        }

        public string SelectPlayers()
        {
            Console.Clear();
            string prompt = "One or two players? [Type '1' or '2']\n";
            string errorInput = "Your input is incorrect. Please type a '1' or '2'.\n";
            ScrollingText(prompt);
            string playerNumInput = Console.ReadLine();
            while (playerNumInput != "1" && playerNumInput != "2")
            {
                Console.Clear();
                ScrollingText(errorInput);
                playerNumInput = Console.ReadLine();
            }
            return playerNumInput;
        }

        public void SetPlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                player1 = new HumanPlayer();
                player2 = new AIPlayer();
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new HumanPlayer();
                player2 = new HumanPlayer();
            }
        }

        public void GetNames()
        {
            player1.ChooseName();
            player2.ChooseName();
        }

        public void CompareChoices()
        {
            string tie = "Tie! Go again!";
            string player1Round = player1.name + " wins the round!";
            string player2Round = player2.name + " wins the round!";
            

            if (player1.choice == player2.choice)
            {
                Console.Clear();
                ScrollingText(tie);
            }
            else if (player1.choice == "0" && (player2.choice == "2" || player2.choice == "3"))
            {
                Console.Clear();
                ScrollingText(player1Round);
                player1.score++;
            }
            else if (player1.choice == "1" && (player2.choice == "0" || player2.choice == "4"))
            {
                Console.Clear();
                ScrollingText(player1Round);
                player1.score++;
            }
            else if (player1.choice == "2" && (player2.choice == "1" || player2.choice == "3"))
            {
                Console.Clear();
                ScrollingText(player1Round);
                player1.score++;
            }
            else if (player1.choice == "3" && (player2.choice == "1" || player2.choice == "4"))
            {
                Console.Clear();
                ScrollingText(player1Round);
                player1.score++;
            }
            else if (player1.choice == "4" && (player2.choice == "2" || player2.choice == "0"))
            {
                Console.Clear();
                ScrollingText(player1Round);
                player1.score++;
            }
            else
            {
                Console.Clear();
                ScrollingText(player2Round);
                player2.score++;
            }
            string playersScoreReport = "\n" + player1.name + "'s score is " + player1.score + " and " + player2.name + "'s score is " + player2.score + ".";
            ScrollingText(playersScoreReport);
            Console.WriteLine("\n\nHit [Enter] to continue...");
            Console.ReadLine();
        }

        public void DisplayWinner()
        {
            if(player1.score > player2.score)
            {
                Console.Clear();
                string playerOneWins = player1.name + " WINS THE GAME!!";
                ScrollingText(playerOneWins);
            }
            else
            {
                Console.Clear();
                string playerTwoWins = player2.name = " WINS THE GAME!!";
                ScrollingText(playerTwoWins);
            }
        }

        public void Initialize()
        {
            Intro();
            SetPlayers(SelectPlayers());
            GetNames();
            while(player1.score < 2 && player2.score <2)
            {
                player1.Gestures();
                player2.Gestures();
                CompareChoices();
            }
            DisplayWinner();
        }
    }
}

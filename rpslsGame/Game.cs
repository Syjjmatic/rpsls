﻿using System;
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


        //public void GameSetUp()
        //{
        //    Console.WriteLine("\nOne or two players? [Type '1' or '2']");
        //    input = Console.ReadLine();
        //    Console.Clear();

        //    while (input != "1" && input != "2")
        //    {
        //        Console.WriteLine("Your input is incorrect. Please type a '1' or '2'.");
        //        input = Console.ReadLine();
        //        Console.Clear();
        //    }

        //    if(input == "1")
        //    {
        //        Console.WriteLine("Enter player one's name: ");
        //        humanPlayer1.name = Console.ReadLine();
        //        while (humanPlayer1.name == "")
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You didn't enter anything. Try again.");
        //            Console.WriteLine("\nEnter player one's name: ");
        //            humanPlayer1.name = Console.ReadLine();
        //        }
        //        Console.WriteLine("\nName your opponent (like in Pokemon): ");
        //        aiPlayer2.name = Console.ReadLine();
        //        while(aiPlayer2.name == "")
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You didn't enter anything. Try again.");
        //            Console.WriteLine("\nName your opponent (like in Pokemon): ");
        //            aiPlayer2.name = Console.ReadLine();
        //        }
        //    }
        //    else if(input == "2")
        //    {
        //        Console.WriteLine("Enter player one's name: ");
        //        humanPlayer1.name = Console.ReadLine();
        //        while (humanPlayer1.name == "")
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You didn't enter anything. Try again.");
        //            Console.WriteLine("\nEnter player one's name: ");
        //            humanPlayer1.name = Console.ReadLine();
        //        }
        //        Console.WriteLine("\nEnter player two's name: ");
        //        humanPlayer2.name = Console.ReadLine();
        //        while (humanPlayer2.name == "")
        //        {
        //            Console.Clear();
        //            Console.WriteLine("You didn't enter anything. Try again.");
        //            Console.WriteLine("\nEnter player two's name: ");
        //            humanPlayer2.name = Console.ReadLine();
        //        }
        //    }
        //}

        //public void MakeChoicePlayer1()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Okay, " + humanPlayer1.name + ", choose your gesture! [Pick by typing the corresponding number on the left.]");
        //    for (int i = 0; i < gestures.gestures.Count; i++)
        //    {
        //        Console.WriteLine(i + ".) " + gestures.gestures[i]);
        //    }
        //    choice1 = Console.ReadLine();

        //    while (choice1 != "0" && choice1 != "1" && choice1 != "2" && choice1 != "3" && choice1 != "4")
        //    {
        //        Console.Clear();
        //        Console.WriteLine("You did choose a correct option. Try again.");
        //        for (int i = 0; i < gestures.gestures.Count; i++)
        //        {
        //            Console.WriteLine(i + ".) " + gestures.gestures[i]);
        //        }

        //        choice1 = Console.ReadLine();
        //    }

        //}

        //public void MakeChoicePlayer2()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Okay, " + humanPlayer2.name + ", choose your gesture! [Pick by typiong the corresponding number on the left.]");
        //    for (int i = 0; i < gestures.gestures.Count; i++)
        //    {
        //        Console.WriteLine(i + ".) " + gestures.gestures[i]);
        //    }
        //    choice2 = Console.ReadLine();

        //    while (choice2 != "0" && choice2 != "1" && choice2 != "2" && choice2 != "3" && choice2 != "4")
        //    {
        //        Console.Clear();
        //        Console.WriteLine("You did choose a correct option. Try again.");
        //        for (int i = 0; i < gestures.gestures.Count; i++)
        //        {
        //            Console.WriteLine(i + ".) " + gestures.gestures[i]);
        //        }

        //        choice2 = Console.ReadLine();
        //    }
        //}

        //public void MakeChoiceAI()
        //{
        //    Console.Clear();
        //    Console.WriteLine(aiPlayer2.name + " chooses his gesture at random...");
        //    Random rndGest = new Random();
        //    aiChoice = Convert.ToInt32(rndGest.Next(0, 4));
        //    Console.WriteLine(aiPlayer2.name + " chooses " + gestures.gestures[aiChoice] + "!");
        //    choice2 = Convert.ToString(aiChoice);
        //    Console.WriteLine("\nHit any key to continue... ");
        //    Console.ReadLine();
        //}

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
            if (player1.score > player2.score)
            {

            }
            

            //SetPlayers(SelectPlayers());
            //SelectPlayers();
            //GameSetUp();
            //if (input == "1")
            //{
            //    while (humanPlayer1.score < 2 && aiPlayer2.score < 2)
            //    {
            //        MakeChoicePlayer1();
            //        MakeChoiceAI();
            //        CompareCoicesHumanAI();
            //    }
            //    if (humanPlayer1.score > aiPlayer2.score)
            //    {
            //        Console.Clear();
            //        Console.WriteLine(humanPlayer1.name + " WINS THE GAME!!");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine(aiPlayer2 + " WINS THE GAME!!");
            //    }
            //}
            //else if (input == "2")
            //{
            //    while (humanPlayer1.score < 2 && humanPlayer2.score < 2)
            //    {
            //        MakeChoicePlayer1();
            //        MakeChoicePlayer2();
            //        CompareChoicesHumanHuman();
                   
            //    }
            //    if (humanPlayer1.score > humanPlayer2.score)
            //    {
            //        Console.Clear();
            //        Console.WriteLine(humanPlayer1.name + " WINS THE GAME!!");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine(humanPlayer2.name + " WINS THE GAME!!");

            //    }

            //}
        }
    }
}

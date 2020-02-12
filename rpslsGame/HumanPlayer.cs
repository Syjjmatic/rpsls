﻿using System;
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

        public override void ChooseName()
        {
            playerNameRequest = "Enter player name: ";
            Console.Clear();
            ScrollingText(playerNameRequest);
            name = Console.ReadLine();
            while (name == "")
            {
                Console.Clear();
                ScrollingText(nothingEntered);
                ScrollingText(playerNameRequest);
                name = Console.ReadLine();
            }

        }
        public override void Gestures()
        {
            Console.Clear();
            string chooseGestureString = "Okay, " + name + ", choose your gesture! [Pick by typing the corresponding number on the left.]\n";
            ScrollingText(chooseGestureString);
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(i + ".) " + gestures[i]);
            }
            choice = Console.ReadLine();
            while (choice != "0" && choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                Console.Clear();
                Console.WriteLine("You did choose a correct option. Try again.");
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine(i + ".) " + gestures[i]);
                }
                choice = Console.ReadLine();
            }
            

        }
    }
}

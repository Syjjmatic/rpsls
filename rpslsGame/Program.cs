﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpslsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.Initialize();
            Console.ReadLine();
        }
    }
}

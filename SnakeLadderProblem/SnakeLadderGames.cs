﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class SnakeLadderGame
    {
        public void SnakeLadder()
        {
            int position1 = 0;
            int Num_of_Players = 1;

            Console.WriteLine("Enter s to Start to play ");
            string start = Console.ReadLine();

            Console.WriteLine("Number of Players : " + Num_of_Players);
            Console.WriteLine("Player 1 at position : " + position1);

        }
    }
}

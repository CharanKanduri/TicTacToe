﻿using System;

namespace TicTacToe
{
   public class Program
    {
        static void Main(string[] args)
        {      
            char[] board = TicTacToeGame.StartGame();
            string playerInput = TicTacToeGame.GetPlayerInput();
            String ComputerInput = TicTacToeGame.GetComputerInput(playerInput);

        }
    }
}

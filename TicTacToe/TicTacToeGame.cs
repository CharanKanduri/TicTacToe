using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public static char[] StartGame()
        {   
            char[] boardArr = new char[10];

            for (int i=1; i<boardArr.Length; i++)
            {
                boardArr[i] = ' ';
            }
            return boardArr;
        }

        public static string GetPlayerInput()
        {   
            string playerInput;
            Console.WriteLine("/nEnter Player Input");
            playerInput = Console.ReadLine();
            return playerInput;
        }
        public static string GetComputerInput(string playerInput)
        {
            string computerInput;
            if (playerInput == "X")
            {
                computerInput = "O";
            }
            else
            {
                computerInput = "X";
            }

            return computerInput;
        }


    }
}

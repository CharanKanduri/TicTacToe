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
                boardArr[i] = '0';
            }
            return boardArr;
        }

        public static string GetPlayerInput()
        {   
            string playerInput;
            Console.WriteLine("\nEnter Player Input");
            playerInput = Console.ReadLine();
            return playerInput;
        }
        public static string GetComputerInput(string playerInput)
        {
            string computerInput =" ";

            if (playerInput == "X" || playerInput == "x")
            {
                computerInput = "O";
            }
            else if (playerInput == "O" || playerInput == "o")
            {
                computerInput = "X";
            }
            else
            {
                Console.WriteLine("\nEnter correct chioce");
            }

            return computerInput;
        }

        public static void Display(char[] boardArr)
        {
            int i = 1;
            for (i = 1; i <boardArr.Length; i=i+3)
            {
                Console.WriteLine($"{boardArr[i]}         |{boardArr[i+2]}          |{boardArr[i+3]}");
                Console.WriteLine("\n");
              
            }
            
        }


    }
}

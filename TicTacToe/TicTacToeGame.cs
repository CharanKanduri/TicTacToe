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
    }
}

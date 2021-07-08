using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeProblem
{
    
    class TicTacToeGame
    {
        //Ignore the 0 th index.
        char[] boardArray = new char[10];

        public char[] CreateBoard()
        {
            for(int i = 1; i < boardArray.Length; i++)
            {
                boardArray[i] = '0';
            }
            return boardArray;

        }
        public char[] ChooseXorO()
        {
            char[] playerLetter = new char[2];
            Console.WriteLine("Player 1 enter the character which you want to play X or O ");
            char playerHold = Convert.ToChar(Console.ReadLine());
          
            if (playerHold == 'X' || playerHold == 'O')
            {
                if (playerHold == 'X')
                {
                    playerLetter[0] = playerHold;
                    playerLetter[1] = 'O';
                }
                else
                {
                    playerLetter[0] = playerHold;
                    playerLetter[1] = 'X';
                    
                }
            }
            else
            {
                Console.WriteLine("Please enter X or Y");
            }
            return playerLetter;
        }

    }
}

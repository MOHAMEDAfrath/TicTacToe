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
                boardArray[i] = ' ';
            }
            return boardArray;

        }
        public char[] ChooseXorO()
        {
            char[] playerLetter = new char[2];
            Console.WriteLine("Player 1 enter the character which you want to play X or O ");
            string playerHold = Console.ReadLine();
          
            if (playerHold.ToLower() == "x" || playerHold.ToLower() == "o")
            {
                if (playerHold.ToLower() == "x")
                {
                    playerLetter[0] = Convert.ToChar(playerHold);
                    playerLetter[1] = 'O';
                }
                else
                {
                    playerLetter[0] = Convert.ToChar(playerHold);
                    playerLetter[1] = 'X';
                    
                }
            }
            else
            {
                Console.WriteLine("Please enter X or Y");
            }
            Console.WriteLine("The players letter is: {0}",playerLetter[0]);
            Console.WriteLine("The computer letter is: {0}", playerLetter[1]);
            return playerLetter;
        }
        public void SelectPosition(int player,char[] board)
        {
            Console.WriteLine("Enter the postion:");
            int position = Convert.ToInt32(Console.ReadLine());
            if (position <= 9 && position >= 1) {
                if (board[position] != 'X' && board[position] != 'O'){
                    if (player == 0)
                    {
                        Console.WriteLine("Player Plays");
                        board[position] = 'X';
                        ShowBoard(board);
                    } else if (player == 1)
                    {
                        Console.WriteLine("Computer Plays");
                        board[position] = 'O';
                        ShowBoard(board);
                    }
                }
                else
                {
                    Console.WriteLine("The position is already taken");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid integer between 1 and 9");
            }

        }
        public void ShowBoard(char[] board)
        {
            Console.WriteLine("*******The Current Board*******");
            Console.WriteLine(boardArray[1]+" | "+boardArray[2]+" | "+boardArray[3]);
            Console.WriteLine("------------");
            Console.WriteLine(boardArray[4] + " | " + boardArray[5] + " | " + boardArray[6]);
            Console.WriteLine("------------");
            Console.WriteLine(boardArray[7] + " | " + boardArray[8] + " | " + boardArray[9]);
            
        }

    }
}

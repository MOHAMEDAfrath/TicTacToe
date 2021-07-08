using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Problem");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            char[] board = ticTacToeGame.CreateBoard();
            char[] playerLetter = ticTacToeGame.ChooseXorO();
            ticTacToeGame.DisplayBoard(board);
        }
    }
}

﻿using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Problem");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.createBoard();
        }
    }
}

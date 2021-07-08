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

        public void CreateBoard()
        {
            for(int i = 0; i < 10; i++)
            {
                boardArray[i] = '0';
            }
            Console.WriteLine( boardArray[1] +" | "+boardArray[2]+ " | "+boardArray[3]);
            Console.WriteLine("-----------");
            Console.WriteLine(boardArray[4] + " | " + boardArray[5] + " | " + boardArray[6]);
            Console.WriteLine("-----------");
            Console.WriteLine(boardArray[8] + " | " + boardArray[7] + " | " + boardArray[9]);

        }

    }
}

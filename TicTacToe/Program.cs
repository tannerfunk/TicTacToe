using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sup User!");

            string[] boardPosition = new string[9];

            for (int i = 0; i < 9; i++)
            {
                boardPosition[i] = " ";
            }

            int playerMove = 0;
            bool player1Turn = true;

            bool noWinner = true;


            Console.WriteLine("0 is the top left position, 9 is the bottom right position.");

            while (noWinner)
            {
                if (player1Turn)
                {
                    Console.WriteLine("Enter the position for player 1: ");
                    playerMove = Convert.ToInt32(Console.ReadLine());
                    while (boardPosition[playerMove] != " ")
                    {
                        Console.WriteLine("Position already taken, enter the position for player 1: ");
                        playerMove = Convert.ToInt32(Console.ReadLine());
                    }
                    boardPosition[playerMove] = "X";
                    player1Turn = false;
                }
                else
                {
                    Console.WriteLine("Enter your position for player 2: ");
                    playerMove = Convert.ToInt32(Console.ReadLine());
                    while (boardPosition[playerMove] != " ")
                    {
                        Console.WriteLine("Position already taken, enter the position for player 2: ");
                        playerMove = Convert.ToInt32(Console.ReadLine());
                    }
                    boardPosition[playerMove] = "O";
                    player1Turn = true;
                }

                for (int i = 0; i < boardPosition.Length; i++)
                {
                    Console.WriteLine(boardPosition[i]);
                }
                //call method in supporting class to print the board
                // call method in supporting class to see if there is a winner


            }
            Console.WriteLine("Congrats player something");

        }
    }
}

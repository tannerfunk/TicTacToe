using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sup User!");

            PrintBoard printBoard = new PrintBoard();

            string[] boardPosition = new string[9];

            for (int i = 0; i < 9; i++)
            {
                boardPosition[i] = Convert.ToString(i);
            }

            int playerMove = 0;
            bool player1Turn = true;

            string noWinner = "N";

            printBoard.Print(boardPosition);

            Console.WriteLine("0 is the top left position, 8 is the bottom right position.");

            while (noWinner == "N")
            {
                if (player1Turn)
                {
                    Console.WriteLine("Enter the position for player 1: ");
                    playerMove = Convert.ToInt32(Console.ReadLine());
                    while (boardPosition[playerMove] == "X" || boardPosition[playerMove] == "O")
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
                    while (boardPosition[playerMove] == "X" || boardPosition[playerMove] == "O")
                    {
                        Console.WriteLine("Position already taken, enter the position for player 2: ");
                        playerMove = Convert.ToInt32(Console.ReadLine());
                    }
                    boardPosition[playerMove] = "O";
                    player1Turn = true;
                    
                }

                printBoard.Print(boardPosition);
                noWinner = PrintBoard.Victory(boardPosition);


            }

            if (noWinner == "D")
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("Congrats player " + noWinner + "! You are the winner!");
            }
            

        }
    }
}

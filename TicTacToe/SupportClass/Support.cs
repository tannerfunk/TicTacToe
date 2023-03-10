// Receive the "board array from the driver class
//Method that prints the board based on the information passed in 
using System;

class PrintBoard
{
    public void Print(string[] myboard)
    {
        //print out each poisition of the board in a specific format in groups of three
        Console.WriteLine("\n   {0}    |   {1}    |  {2} ", myboard[0], myboard[1], myboard[2]);
        Console.WriteLine("  ______|________|______");
        Console.WriteLine("        |        |      ");
        Console.WriteLine("   {0}    |   {1}    |  {2} ", myboard[3], myboard[4], myboard[5]);
        Console.WriteLine("  ______|________|______");
        Console.WriteLine("        |        |      ");
        Console.WriteLine("   {0}    |   {1}    |  {2} ", myboard[6], myboard[7], myboard[8]);
        Console.WriteLine("        |        |      \n");
    }

    // Method that receives the game board array as input and returns if there is a winner and who it was


    public static string Victory(string[] myboard)
    {
        // Horizontal Victory

        if (myboard[0] == myboard[1] && myboard[1] == myboard[2])
        {
            return myboard[0]; //Return if it's a victory, and the character of the victor
        }

        else if (myboard[3] == myboard[4] && myboard[4] == myboard[5])
        {
            return myboard[3]; //Return if it's a victory, and the character of the victor
        }

        else if (myboard[6] == myboard[7] && myboard[7] == myboard[8])
        {
            return myboard[6]; //Return if it's a victory, and the character of the victor
        }


        // Vertical Victory
        else if (myboard[0] == myboard[3] && myboard[3] == myboard[6])
        {
            return myboard[0]; //Return if it's a victory, and the character of the victor
        }

        else if (myboard[1] == myboard[4] && myboard[4] == myboard[7])
        {
            return myboard[1]; //Return if it's a victory, and the character of the victor
        }

        else if (myboard[2] == myboard[5] && myboard[5] == myboard[8])
        {
            return myboard[2]; //Return if it's a victory, and the character of the victor
        }


        // Diagonal Victory
        else if (myboard[0] == myboard[4] && myboard[4] == myboard[8])
        {
            return myboard[0]; //Return if it's a victory, and the character of the victor
        }
        else if (myboard[2] == myboard[4] && myboard[4] == myboard[6])
        {
            return myboard[2]; //Return if it's a victory, and the character of the victor
        }
        // Draw
        else if (myboard[0] != "0" && myboard[1] != "1" && myboard[2] != "2" && myboard[3] != "3" && myboard[4] != "4" && myboard[5] != "5" && myboard[6] != "6" && myboard[7] != "7" && myboard[8] != "8")
        {
            return "D"; //Returns a 'D' for draw
        }
        else
        {
            return "N"; // Nothin happens
        }

    }
}
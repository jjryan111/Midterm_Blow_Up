using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowUp
{
    class Board
    {
        private Random n = new Random();
        public Board()
        {

        }

        public int[,] AddMines(int[,] board, int numMines)
        {// Takes in a board of x, y dimensions
         // Puts bombs in
         /* The actual gameboard is 2 columns and 2 rows bigger than the user sees
          * so that when it comes time to choose a play square
          * the user can never choose something outside the array
         */
            int x = board.GetLength(0) - 1;
            int y = board.GetLength(1) - 1;
            while (numMines != 0) //While there are mines left to place
            {// go to a random spot on the board
                int index1 = n.Next(2, x);
                int index2 = n.Next(2, y);
                if (board[index1, index2] == 0)
                {/* and put a mine there. Because of the way the random numbers are generated
                 * you will never put a mine in an edge or a corner of the back end board
                 * Since the user only sees the interior of the board that means none
                 * of the things we do next will run over an edge or a corner
                 */
                    board[index1, index2] = 100;
                    numMines--;
                }
            }
            return board;
        }
        public int[,] GameBoard(int[,] board)
        {// in every index of the board, including the ones the user never sees
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if ((board[i, j] >= 100))
                    {// if you find a mine add 1 to the 8 squares around it
                     // Don't worry if you add 1 to a mine; the program knows anything 100 or more
                     // is a mine
                     // Since we made sure that mines can't be placed on an edge in the AddMines
                     // we don't have to worry about this running out of bounds
                        board[(i - 1), (j - 1)]++;
                        board[(i - 1), j]++;
                        board[(i - 1), (j + 1)]++;
                        board[i, (j - 1)]++;
                        board[i, (j + 1)]++;
                        board[(i + 1), (j - 1)]++;
                        board[(i + 1), j]++;
                        board[(i + 1), (j + 1)]++;

                    }
                }
            }
            return board;
        }
        

        public string BoardCases(int[,] board, int i, int j)
        { //Looks at where the chosen square is in relation to the edges and corners of the board
            string whereAt = "dunno";


            if (((i - 1) >= 0) && ((i + 1) < board.GetLength(0)))
            {
                //Middle of the board case
                if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
                {
                    whereAt = "m";
                }

                //Top edge case
                else if ((j - 1) >= 0)
                {
                    whereAt = "t";
                }

                //Bottom edge case
                else if ((j + 1) < board.GetLength(1))
                {
                    whereAt = "b";
                }
            }

            else if ((i - 1) >= 0)
            {
                // Right edge case
                if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
                {
                    whereAt = "r";
                }
                //Top Right Corner case
                else if ((j - 1) >= 0)
                {
                    whereAt = "trc";
                }
                //Top right corner case
                else if ((j + 1) < board.GetLength(1))
                {
                    whereAt = "brc";
                }
            }
            else if ((i + 1) < board.GetLength(0))

            {// Left edge case
                if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
                {
                    whereAt = "l";
                }
                else if ((j + 1) < board.GetLength(1))
                {// Bottom left corner case
                    whereAt = "blc";
                }
                //Top left corner case
                else if ((j - 1) >= 0)
                {
                    whereAt = "tlc";
                }
            }

            return whereAt;
        }
        public void PrintBoard(int[,] board)
        { // Prints the back end board
            int x = board.GetLength(0);
            int y = board.GetLength(1);
            x--;
            y--;

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    
                        Console.Write(board[i, j] + "\t");
                    
                }
                Console.WriteLine();
            }
        }

        public int[,] RevealZero(int[,] board, List<int> zeroLists)
        {// When done this will automatically reveal any squares with nothing in them
         // surrounding the user choice

            bool done = false;
            
            //if (zeroLists.Count == 0)
            //{
            //    done = true;

            //}
            //else
            //{
            while (!done)
            {// Take the fist 2 numbers off the top of the list of squares with 0s in them
             // These are the numbers we will check
                int i = zeroLists[0];
                int j = zeroLists[1];
                zeroLists.Remove(i);
                zeroLists.Remove(j);
                // If we're near an edge we're off the player board and don't have to worry about it.
                string whereAt = BoardCases(board, i, j);

                //if (board[i, j] > 100)
                //{
                //    done = true;
                //}
                if (board[i, j] < 10)
                {
                    board[i, j] += 10;
                    //Anything 10 and over but less than 100 is a revealed square on the player board
                    // What we're checking here is if the spot has already been revealed
                }
                if (whereAt == "m")
                {// if we aren't on an edge or a corner look for 0's in the 8 squares surrounding 
                 // the chosen square
                    if ((board[(i - 1), (j - 1)] == 0)) // one the top left
                    {
                        zeroLists.Add((i - 1));
                        zeroLists.Add((j - 1));
                    }
                    if ((board[(i - 1), j] == 0)) //on the top middle
                    {
                        zeroLists.Add((i - 1));
                        zeroLists.Add(j);
                    }
                    if (board[(i - 1), (j + 1)] == 0) //on the top right
                    {
                        zeroLists.Add((i - 1));
                        zeroLists.Add((j + 1));
                    }
                    if (board[i, (j - 1)] == 0) //on the left
                    {
                        zeroLists.Add(i);
                        zeroLists.Add((j - 1));
                    }
                    if (board[i, (j + 1)] == 0) //on the right
                    {
                        zeroLists.Add(i);
                        zeroLists.Add(j + 1);
                    }
                    if (board[(i + 1), (j - 1)] == 0) //on the bottom left
                    {
                        zeroLists.Add((i + 1));
                        zeroLists.Add((j - 1));
                    }
                    if (board[(i + 1), j] == 0) //on the bottom middle
                    {
                        zeroLists.Add((i + 1));
                        zeroLists.Add(j);
                    }
                    if (board[(i + 1), (j + 1)] == 0) //on the bottom right
                    {
                        zeroLists.Add((i + 1));
                        zeroLists.Add((j + 1));
                    }
                }
                else
                {// at the top we found out if the square we were looking at was on an edge
                 //this tells the method to ignore those
                    zeroLists.Remove(i);
                    zeroLists.Remove(j);
                }
                if (zeroLists.Count == 0)
                {
                    done = true;
                }
            }
            //}
            return board;
        }
    }
}


 
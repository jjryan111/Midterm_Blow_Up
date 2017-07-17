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
         /* The actual gameboard is 3 column and 3 rows bigger than the user sees
          * so that when it comes time to choose a play square
          * the user can never choose something outside the array
         */
            int x = board.GetLength(0) - 1;
            int y = board.GetLength(1) - 1;
            while (numMines != 0)
            {// 
                int index1 = n.Next(2, x);
                int index2 = n.Next(2, y);
                if (board[index1, index2] == 0)
                {
                    board[index1, index2] = 100;
                    numMines--;
                }
            }
            // PrintBoard(board);
            return board;
        }
        public int[,] GameBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if ((board[i, j] >= 100))
                    {
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

        public int[,] RevealZero(int[,] board, List<int> zeroLists)
        {

            bool done = false;
            if (zeroLists.Count == 0)
            {
                done = true;

            }
            else
            {
                while (!done)
                {
                    int i = zeroLists[0];
                    int j = zeroLists[1];
                    zeroLists.Remove(i);
                    zeroLists.Remove(j);
                    string whereAt = BoardCases(board, i, j);

                    //if (board[i, j] > 100)
                    //{
                    //    done = true;
                    //}
                    if (board[i, j] < 10)
                    {
                        board[i, j] += 10;
                    }
                    if (whereAt == "m")
                    {
                        if ((board[(i - 1), (j - 1)] == 0))
                        {
                            zeroLists.Add((i - 1));
                            zeroLists.Add((j - 1));
                        }
                        if ((board[(i - 1), j] == 0))
                        {
                            zeroLists.Add((i - 1));
                            zeroLists.Add(j);
                        }
                        if (board[(i - 1), (j + 1)] == 0)
                        {
                            zeroLists.Add((i - 1));
                            zeroLists.Add((j + 1));
                        }
                        if (board[i, (j - 1)] == 0)
                        {
                            zeroLists.Add(i);
                            zeroLists.Add((j - 1));
                        }
                        if (board[i, (j - 1)] == 0)
                        {
                            zeroLists.Add(i);
                            zeroLists.Add(j - 1);
                        }
                        if (board[i, (j + 1)] == 0)
                        {
                            zeroLists.Add(i);
                            zeroLists.Add((j + 1));
                        }
                        if (board[(i + 1), (j - 1)] == 0)
                        {
                            zeroLists.Add((i + 1));
                            zeroLists.Add((j - 1));
                        }
                        if (board[(i + 1), j] == 0)
                        {
                            zeroLists.Add((i - 1));
                            zeroLists.Add(j);
                        }
                        if (board[(i + 1), (j + 1)] == 0)
                        {
                            zeroLists.Add((i + 1));
                            zeroLists.Add((j + 1));
                        }
                    }
                    else
                    {
                        zeroLists.Remove(i);
                        zeroLists.Remove(j);
                    }
                    if (zeroLists.Count == 0)
                    {
                        done = true;
                    }
                }
            }
            return board;
        }





        public string BoardCases(int[,] board, int i, int j)
        {
            string whereAt = "dunno";
            if (board[i, j] <= 100)
            {
                //                        Console.WriteLine("I = "+i+" J = "+j);
                // I = Column, J = Row
                if (((i - 1) >= 0) && ((i + 1) < board.GetLength(0)))
                {
                    //                Console.WriteLine("I=" + i + " J+" + j);
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

                //Working

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
                    // Working
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
            }
            return whereAt;
        }


        public void PrintBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if ((board[i, j]) < 10)
                    {
                        Console.Write(board[i, j] + "   ");
                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}


 
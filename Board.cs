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

        public int[,] AddMines(int[,] board, int numMi)
        {
            while (numMi != 0)
            {
                for (int x = 0; x < 100000; x++) { }
                int index1 = n.Next(0, board.GetLength(0));
                for (int x = 0; x < 1000; x++) { }
                int index2 = n.Next(0, board.GetLength(1));
                if (board[index1, index2] == 0)
                {
                    int isMine = n.Next(1, numMi);
                    if (isMine == 1)
                    {
                        board[index1, index2] = 100;
                        numMi--;
                    }
                }
            }

            //PrintBoard(board);
            //Console.WriteLine();
            //    Console.WriteLine();

            PrintBoard(board);
            Console.WriteLine();
            Console.WriteLine();


            return board;
        }
        public int [,] GameBoard (int [,] board)
        {
            PrintBoard(board);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                   
                    if(board[i,j] >= 100)
                    {
                        if ((i - 1) >= 0 && ((i + 1) < board.GetLength(0)))
                        {
                            //Middle of the board case
                            if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
                            {
                                board[(i - 1), (j - 1)] ++;
                                board[(i - 1), j] ++;
                                board[(i - 1), (j + 1)]++;
                                board[i, (j - 1)]++;
                                board[i, (j + 1)]++;
                                board[(i + 1), (j - 1)]++;
                                board[(i + 1), j]++;
                                board[(i + 1), (j + 1)]++;

                            }
                        
                        //    //Left edge case
                        //    else if ((j - 1) >= 0)
                        //    {
                        //        board[(i - 1), (j - 1)]++;
                        //        board[(i - 1), j]++;
                        //        // board[(i - 1), (j + 1)]++;
                        //        board[i, (j - 1)]++;
                        //        // board[i, (j + 1)]++;
                        //        board[(i + 1), (j - 1)]++;
                        //        board[(i + 1), j]++;
                        //        // board[(i + 1), (j + 1)]++;
                        //    }
                        //    //Right edge case
                        //    else if ((j + 1) < board.GetLength(1))
                        //    {
                        //        //board[(i - 1), (j - 1)]++*/;
                        //        board[(i - 1), j]++;
                        //        board[(i - 1), (j + 1)]++;
                        //        //board[i, (j - 1)]++;
                        //        board[i, (j + 1)]++;
                        //        //board[(i + 1), (j - 1)]++;
                        //        board[(i + 1), j]++;
                        //        board[(i + 1), (j + 1)]++;
                        //    }
                        //}
                        //else if (((i - 1) <= 0))
                        //{
                        //    //Top edge case
                        //    if (((j - 1) >= 0) && ((j + 1) < board.GetLength(1)))
                        //    {
                        //        board[(i - 1), (j - 1)]++;
                        //        board[(i - 1), j]++;
                        //        board[(i - 1), (j + 1)]++;
                        //        board[i, (j - 1)]++;
                        //        board[i, (j + 1)]++;
                        //        //board[(i + 1), (j - 1)]++;
                        //        //board[(i + 1), j]++;
                        //        //board[(i + 1), (j + 1)]++;
                        //    }
                        
                            //else if ((j - 1) >= 0)
                            //{//Top Left Corner case
                            //    //board[(i - 1), (j - 1)]++;
                            //    //board[(i - 1), j]++;
                            //    //board[(i - 1), (j + 1)]++;
                            //    //board[i, (j - 1)]++;
                            //    //board[i, (j + 1)]++;
                            //    //board[(i + 1), (j - 1)]++;
                            //    //board[(i + 1), j]++;
                            //    //board[(i + 1), (j + 1)]++;
                            //}
                            //    else if ((j + 1) < board.GetLength(1))
                            //    {//Top right corner case

                            //        // board[(i - 1), (j - 1)]++;
                            //        //board[(i - 1), j]++;
                            //        //board[(i - 1), (j + 1)]++;
                            //        //board[i, (j - 1)]++;
                            //        board[i, (j + 1)]++;
                            //        //board[(i + 1), (j - 1)]++;
                            //        board[(i + 1), j]++;
                            //        board[(i + 1), (j + 1)]++;
                            //    }
                            //}
                            //else if ((i + 1) < board.GetLength(0))
                            //{//bottom left corner case
                            //    if ((j - 1) >= 0)
                            //    {
                            //        //board[(i - 1), (j - 1)]++;
                            //        //board[(i - 1), j]++;
                            //        //board[(i - 1), (j + 1)]++;
                            //        //board[i, (j - 1)]++;
                            //        board[i, (j + 1)]++;
                            //        //board[(i + 1), (j - 1)]++;
                            //        board[(i + 1), j]++;
                            //        board[(i + 1), (j + 1)]++;
                            //    }
                            //    else if ((j + 1) < board.GetLength(1))
                            //    {//bottom right corner case

                            //        //board[(i - 1), (j - 1)]++;
                            //        board[(i - 1), j]++;
                            //        board[(i - 1), (j + 1)]++;
                            //        //board[i, (j - 1)]++;
                            //        board[i, (j + 1)]++;
                            //        //board[(i + 1), (j - 1)]++;
                            //        //board[(i + 1), j]++;
                            //        //board[(i + 1), (j + 1)]++;
                            //    }
                            //}
                            

                        }
                    }
                }
            }
            PrintBoard(board);
            return board;
        }
        public void PrintBoard(int[,] board)
        {
            for (int m = 0; m < board.GetLength(0); m++)
            {
                for (int l = 0; l < board.GetLength(1); l++)
                {
                    if ((board[l, m]) != 100)
                    {
                        Console.Write(board[1, m] + "   ");
                    }
                    else
                    {
                        Console.Write(board[l, m] + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}

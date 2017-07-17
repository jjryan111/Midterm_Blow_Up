using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowUp
{
    class guh
    {
        public guh() { }
        public int[,] RevealZero(int[,] board, List <int> zeroLists)
        {
           
            string whereAt = "";
            bool done = false;
            //if(zeroLists is empty) {done=true;}
            //else{
            int i = zeroLists[0];
            int j = zeroLists[1];
            zeroLists.Remove(i);
            zeroLists.Remove(j);
            //}
            while (!done)
            {
                whereAt = BoardCases(board, i, j);
                switch (whereAt)
                {
                    case "m":
                        if (board[i,j] < 10)
                        {
                           
                            board[i, j] += 10;
                        }
                        if (board[(i - 1),(j - 1)] < 10)
                        {
                            if (board[(i-1),( j-1)] == 0)
                            {
                                zeroLists.Add((i-1));
                                zeroLists.Add((j-1));
                            }
                            board[(i - 1), (j - 1)] += 10;
                        }
                        if (board[(i - 1), j] < 10)
                        {
                            if (board[(i - 1), j] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add(j);
                            }
                            board[(i - 1), j] += 10;
                        }
                        if (board[(i - 1), (j+1)] < 10)
                        {
                            if (board[(i - 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i - 1), (j + 1)] += 10;
                        }
                        if( board[i,(j-1)] < 10)
                        {
                            if (board[(i - 1), (j - 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j - 1));
                            }
                            board[i, (j - 1)] += 10;
                        }
                        if (board[i, (j + 1)] < 10)
                        {
                            if (board[i, (j + 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j + 1));
                            }
                            board[i, (j + 1)] += 10;
                        }
                        if (board[(i+1), (j-1)] < 10)
                        {
                            if (board[(i + 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i + 1), (j - 1)] += 10;
                        }
                        if (board[(i + 1), j] < 10)
                        {
                            if (board[(i + 1), j] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add(j);
                            }
                            board[(i + 1), j] += 10;
                        }
                        if(board[(i + 1), (j + 1)] < 10)
                        {
                            if (board[(i + 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i + 1), (j + 1)] += 10;
                        }
                        if ((board[i, j] >= 10) && (board[(i - 1), (j - 1)] >= 10) && (board[(i - 1), j] >= 10) && (board[(i - 1), (j + 1)] >= 10) && (board[i, (j - 1)] >= 10) && (board[(i + 1), (j - 1)] >= 10) && (board[(i + 1), j] >= 10) && (board[(i + 1), (j + 1)] >= 10) && (board[i, (j + 1)] < 10))
                        {
                            done = true;
                        }
                            break;
                    case "t":
                             if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        if (board[(i - 1), (j - 1)] < 10)
                        {
                            if (board[(i - 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i - 1), (j - 1)] += 10;
                        }
                        if (board[(i - 1), j] < 10)
                        {
                            if (board[(i - 1), j] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add(j);
                            }
                            board[(i - 1), j] += 10;
                        }
                        //if (board[(i - 1), (j + 1)] < 10)
                        //{
                        //    board[(i - 1), (j + 1)] += 10;
                        //}
                        if (board[i, (j - 1)] < 10)
                        {
                            if (board[i, (j - 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j - 1));
                            }
                            board[i, (j - 1)] += 10;
                        }
                        //if (board[i, (j + 1)] < 10)
                        //{
                        //    board[i, (j + 1)] += 10;
                        //}
                        if (board[(i + 1), (j - 1)] < 10)
                        {
                            if (board[(i + 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i + 1), (j - 1)] += 10;
                        }
                        if (board[(i + 1), j] < 10)
                        {
                            if (board[(i + 1), j] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add(j);
                            }
                            board[(i + 1), j] += 10;
                        }
                        //if (board[(i + 1), (j + 1)] < 10)
                        //{
                        //    board[(i + 1), (j + 1)] += 10;
                        //}
                        if ((board[i, j] >= 10) && (board[(i - 1), (j - 1)] >= 10) && (board[(i - 1), j] >= 10)  && (board[i, (j - 1)] >= 10) && (board[(i + 1), (j - 1)] >= 10) && (board[(i + 1), j] >= 10))
                        {
                            done = true;
                        }
                        break;
                    case "b":// i+-1, j+1
                        if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        //if (board[(i - 1), (j - 1)] < 10)
                        //{
                        //    board[(i - 1), (j - 1)] += 10;
                        //}
                        if (board[(i - 1), j] < 10)
                        {
                            if (board[(i - 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i - 1), j] += 10;
                        }
                        if (board[(i - 1), (j + 1)] < 10)
                        {
                            if (board[(i - 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i - 1), (j + 1)] += 10;
                        }
                        //if (board[i, (j - 1)] < 10)
                        //{
                        //    board[i, (j - 1)] += 10;
                        //}
                        if (board[i, (j + 1)] < 10)
                        {
                            if (board[i, (j + 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j + 1));
                            }
                            board[i, (j + 1)] += 10;
                        }
                        //if (board[(i + 1), (j - 1)] < 10)
                        //{
                        //    board[(i + 1), (j - 1)] += 10;
                        //}
                        if (board[(i + 1), j] < 10)
                        {
                            if (board[(i + 1), j] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add(j);
                            }
                            board[(i + 1), j] += 10;
                        }
                        if (board[(i + 1), (j + 1)] < 10)
                        {
                            if (board[(i + 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i + 1), (j + 1)] += 10;
                        }
                        if ((board[i, j] >= 10) && (board[(i - 1), j] >= 10) && (board[(i - 1), (j + 1)] >= 10) && (board[(i + 1), j] >= 10) && (board[(i + 1), (j + 1)] >= 10) && (board[i, (j + 1)] < 10))
                        {
                            done = true;
                        }
                        break;
                    case "r": // i-1 j+- 1
                        if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        if (board[(i - 1), (j - 1)] < 10)
                        {
                            if (board[(i - 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i - 1), (j - 1)] += 10;
                        }
                        if (board[(i - 1), j] < 10)
                        {
                            if (board[(i - 1), j] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add(j);
                            }
                            board[(i - 1), j] += 10;
                        }
                        if (board[(i - 1), (j + 1)] < 10)
                        {
                            if (board[(i - 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i - 1), (j + 1)] += 10;
                        }
                        if (board[i, (j - 1)] < 10)
                        {
                            if (board[i, (j - 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j - 1));
                            }
                            board[i, (j - 1)] += 10;
                        }
                        if (board[i, (j + 1)] < 10)
                        {
                            if (board[i, (j + 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j + 1));
                            }
                            board[i, (j + 1)] += 10;
                        }
                        //if (board[(i + 1), (j - 1)] < 10)
                        //{
                        //    board[(i + 1), (j - 1)] += 10;
                        //}
                        //if (board[(i + 1), j] < 10)
                        //{
                        //    board[(i + 1), j] += 10;
                        //}
                        //if (board[(i + 1), (j + 1)] < 10)
                        //{
                        //    board[(i + 1), (j + 1)] += 10;
                        //}
                        if ((board[i, j] >= 10) && (board[(i - 1), (j - 1)] >= 10) && (board[(i - 1), j] >= 10) && (board[(i - 1), (j + 1)] >= 10) && (board[i, (j - 1)] >= 10) && (board[i, (j + 1)] < 10))
                        {
                            done = true;
                        }
                        break;
                    case "l": //i+1, j+-1
                        if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        //if (board[(i - 1), (j - 1)] < 10)
                        //{
                        //    board[(i - 1), (j - 1)] += 10;
                        //}
                        //if (board[(i - 1), j] < 10)
                        //{
                        //    board[(i - 1), j] += 10;
                        //}
                        //if (board[(i - 1), (j + 1)] < 10)
                        //{
                        //    board[(i - 1), (j + 1)] += 10;
                        //}
                        if (board[i, (j - 1)] < 10)
                        {
                            if (board[i, (j - 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j - 1));
                            }
                            board[i, (j - 1)] += 10;
                        }
                        if (board[i, (j + 1)] < 10)
                        {
                            if (board[i, (j + 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j + 1));
                            }
                            board[i, (j + 1)] += 10;
                        }
                        if (board[(i + 1), (j - 1)] < 10)
                        {
                            if (board[(i + 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i + 1), (j - 1)] += 10;
                        }
                        if (board[(i + 1), j] < 10)
                        {
                            if (board[(i + 1), j] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add(j);
                            }
                            board[(i + 1), j] += 10;
                        }
                        if (board[(i + 1), (j + 1)] < 10)
                        {
                            if (board[(i + 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i + 1), (j + 1)] += 10;
                        }
                        if ((board[i, j] >= 10) && (board[i, (j - 1)] >= 10) && (board[(i + 1), (j - 1)] >= 10) && (board[(i + 1), j] >= 10) && (board[(i + 1), (j + 1)] >= 10) && (board[i, (j + 1)] < 10))
                        {
                            done = true;
                        }
                        break;
                    case "tlc": // i+1, j-1
                        if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        //if (board[(i - 1), (j - 1)] < 10)
                        //{
                        //    board[(i - 1), (j - 1)] += 10;
                        //}
                        //if (board[(i - 1), j] < 10)
                        //{
                        //    board[(i - 1), j] += 10;
                        //}
                        //if (board[(i - 1), (j + 1)] < 10)
                        //{
                        //    board[(i - 1), (j + 1)] += 10;
                        //}
                        if (board[i, (j - 1)] < 10)
                        {
                            if (board[i, (j - 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j - 1));
                            }
                            board[i, (j - 1)] += 10;
                        }
                        //if (board[i, (j + 1)] < 10)
                        //{
                        //    board[i, (j + 1)] += 10;
                        //}
                        if (board[(i + 1), (j - 1)] < 10)
                        {
                            if (board[(i + 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i + 1), (j - 1)] += 10;
                        }
                        if (board[(i + 1), j] < 10)
                        {
                            if (board[(i + 1), j] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add(j);
                            }
                            board[(i + 1), j] += 10;
                        }
                        //if (board[(i + 1), (j + 1)] < 10)
                        //{
                        //    board[(i + 1), (j + 1)] += 10;
                        //}
                        if ((board[i, j] >= 10) && (board[i, (j - 1)] >= 10) && (board[(i + 1), (j - 1)] >= 10) && (board[(i + 1), j] >= 10))
                        {
                            done = true;
                        }
                        break;
                    case "blc":// i+1 j+1
                        if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        //if (board[(i - 1), (j - 1)] < 10)
                        //{
                        //    board[(i - 1), (j - 1)] += 10;
                        //}
                        //if (board[(i - 1), j] < 10)
                        //{
                        //    board[(i - 1), j] += 10;
                        //}
                        //if (board[(i - 1), (j + 1)] < 10)
                        //{
                        //    board[(i - 1), (j + 1)] += 10;
                        //}
                        //if (board[i, (j - 1)] < 10)
                        //{
                        //    board[i, (j - 1)] += 10;
                        //}
                        if (board[i, (j + 1)] < 10)
                        {
                            if (board[i, (j + 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j + 1));
                            }
                            board[i, (j + 1)] += 10;
                        }
                        //if (board[(i + 1), (j - 1)] < 10)
                        //{
                        //    board[(i + 1), (j - 1)] += 10;
                        //}
                        if (board[(i + 1), j] < 10)
                        {
                            if (board[(i + 1), j] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add(j);
                            }
                            board[(i + 1), j] += 10;
                        }
                        if (board[(i + 1), (j + 1)] < 10)
                        {
                            if (board[(i + 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i + 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i + 1), (j + 1)] += 10;
                        }
                        if ((board[i, j] >= 10) && (board[(i + 1), j] >= 10) && (board[(i + 1), (j + 1)] >= 10) && (board[i, (j + 1)] < 10))
                        {
                            done = true;
                        }
                        break;
                    case "trc": //i-1 j-1
                        if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        if (board[(i - 1), (j - 1)] < 10)
                        {
                            if (board[(i - 1), (j - 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j - 1));
                            }
                            board[(i - 1), (j - 1)] += 10;
                        }
                        if (board[(i - 1), j] < 10)
                        {
                            if (board[(i - 1), j] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add(j);
                            }
                            board[(i - 1), j] += 10;
                        }
                        //if (board[(i - 1), (j + 1)] < 10)
                        //{
                        //    board[(i - 1), (j + 1)] += 10;
                        //}
                        if (board[i, (j - 1)] < 10)
                        {
                            if (board[i, (j - 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j - 1));
                            }
                            board[i, (j - 1)] += 10;
                        }
                        //if (board[i, (j + 1)] < 10)
                        //{
                        //    board[i, (j + 1)] += 10;
                        //}
                        //if (board[(i + 1), (j - 1)] < 10)
                        //{
                        //    board[(i + 1), (j - 1)] += 10;
                        //}
                        //if (board[(i + 1), j] < 10)
                        //{
                        //    board[(i + 1), j] += 10;
                        //}
                        //if (board[(i + 1), (j + 1)] < 10)
                        //{
                        //    board[(i + 1), (j + 1)] += 10;
                        //}
                        if ((board[i, j] >= 10) && (board[(i - 1), (j - 1)] >= 10) && (board[(i - 1), j] >= 10) && (board[i, (j - 1)] >= 10))
                        {
                            done = true;
                        }
                        break;
                    case "brc": //i-1 j+1
                        if (board[i, j] < 10)
                        {
                            board[i, j] += 10;
                        }
                        //if (board[(i - 1), (j - 1)] < 10)
                        //{
                        //    board[(i - 1), (j - 1)] += 10;
                        //}
                        if (board[(i - 1), j] < 10)
                        {
                            if (board[(i - 1), j] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add(j);
                            }
                            board[(i - 1), j] += 10;
                        }
                        if (board[(i - 1), (j + 1)] < 10)
                        {
                            if (board[(i - 1), (j + 1)] == 0)
                            {
                                zeroLists.Add((i - 1));
                                zeroLists.Add((j + 1));
                            }
                            board[(i - 1), (j + 1)] += 10;
                        }
                        //if (board[i, (j - 1)] < 10)
                        //{
                        //    board[i, (j - 1)] += 10;
                        //}
                        if (board[i, (j + 1)] < 10)
                        {
                            if (board[i, (j + 1)] == 0)
                            {
                                zeroLists.Add(i);
                                zeroLists.Add((j + 1));
                            }
                            board[i, (j + 1)] += 10;
                        }
                        //if (board[(i + 1), (j - 1)] < 10)
                        //{
                        //    board[(i + 1), (j - 1)] += 10;
                        //}
                        //if (board[(i + 1), j] < 10)
                        //{
                        //    board[(i + 1), j] += 10;
                        //}
                        //if (board[(i + 1), (j + 1)] < 10)
                        //{
                        //    board[(i + 1), (j + 1)] += 10;
                        //}
                        if ((board[i, j] >= 10) && (board[(i - 1), j] >= 10) && (board[(i - 1), (j + 1)] >= 10) && (board[i, (j + 1)] < 10))
                        {
                            done = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        
            return board;
        }
        public string  BoardCases (int[,] board, int i, int j)
        {
            string whereAt = "dunno";
            if (board[i, j] >= 100)
            {
                //                        Console.WriteLine("I = "+i+" J = "+j);
                // I = Column, J = Row
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
    }
}


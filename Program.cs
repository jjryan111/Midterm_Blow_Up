using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] guh = new int[15, 15];
            for(int i = 0; i < guh.GetLength(0); i++)
            {
                for (int j = 0; j < guh.GetLength(1); j++)
                {
                    guh[i, j] = 0;
                }
            }
            Board f = new Board();
             guh = f.AddMines(guh,10);
            guh = f.GameBoard(guh);
        }
    }
}

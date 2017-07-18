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
            guh g = new guh();
            int[,] thing = new int[15, 15];
            for(int i = 0; i < thing.GetLength(0); i++)
            {
                for (int j = 0; j < thing.GetLength(1); j++)
                {
                    thing[i, j] = 0;
                }
            }
            
            Board2 f = new Board2();
             thing = f.AddMines(thing,50);
            
            thing = f.GameBoard(thing);

            f.PrintBoard(thing);
            while (true)
            {
                List<int> choices = new List<int>();
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                choices.Add(a);
                choices.Add(b);
                f.RevealZero(thing, choices);
                if (choices.Count != 0)
                {
                    choices.Remove(a);
                    choices.Remove(b);
                }
                f.PrintBoard(thing);
            }
        }
    }
}

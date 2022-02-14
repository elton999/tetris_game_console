using System;
using tetris.interfaces;

namespace tetris
{
    public abstract class Cell : IPrintCell
    {
        public void PrintCell(char characther, int xLocation, int yLocation, Grid grid)
        {
            if (xLocation < grid.SizeX && yLocation < grid.SizeY)
            {
                if(grid.Cells[xLocation, yLocation] == '-')
                {
                    Console.SetCursorPosition(xLocation + grid.X, yLocation + grid.X);
                    Console.Write(characther);
                }
            }
        }
    }
}
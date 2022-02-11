using System;

namespace tetris
{
    public class Transformation
    {
        public static char[,] Rotation(char[,] cells, int sizeX, int sizeY)
        {
            char[,] cellsRotated = new char[sizeX, sizeY];
            for(int column = 0; column < sizeX; column++)
            {
                for(int line = 0; line < sizeY; line++)
                {
                    cellsRotated[column, line] = cells[sizeX - 1 - line, column];
                }
            }
            return cellsRotated;
        }        
    }
}
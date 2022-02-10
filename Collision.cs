using System;
using tetris.interfaces;

namespace tetris
{
    public sealed class Collision
    {
        public static bool IsColliding(IObjectForm piece, Grid grid, int x, int y)
        {
            for(int column = 0; column < 6; column++)
            {
                for(int line = 0; line < 6; line++)
                {
                    if(IsCollidingOnBorders(piece.FormObject, grid, column, line, x, y))
                        return true;

                    if(IsCollidingOnOtherPiece(piece.FormObject, grid, column, line, x, y)) 
                        return true;
                }
            }

            return false;
        }

        public static bool IsCollidingOnBorders(char[,] cells, Grid grid, int column, int line, int x, int y)
        {
            bool verticalCheck = x + column < 0 || x + column > grid.SizeX - 1;
            bool horizontalCheck = y + line > grid.SizeY - 1;

            return (verticalCheck || horizontalCheck) && !IsCellFree(cells, column, line);
        }

        public static bool IsCollidingOnOtherPiece(char[,] cells, Grid grid, int column, int line, int x, int y)
        {
            int line1 = Math.Clamp(column + y, 0, grid.SizeY - 1);
            int column1 = Math.Clamp(line + x, 0, grid.SizeX - 1);

            return !IsCellFree(grid.Cells, column1, line1) && !IsCellFree(cells, column, line);
        }

        public static bool IsCellFree(char[,] cells, int column, int line)
        {
            return cells[column, line] == '-';
        }
    }
}
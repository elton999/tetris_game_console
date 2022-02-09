using System;
using tetris.interfaces;

namespace tetris
{
    public class Collision
    {
        public static bool IsOutOfGrid(IObjectForm piece, Grid grid, int x, int y)
        {
            for(int column = 0; column < 6; column++)
            {
                for(int line = 0; line < 6; line++)
                {
                    bool verticalCheck = x + column < 0 || x + column > grid.X;
                    bool horizontalCheck = y + line > grid.Y - 1;

                    if(piece.FormObject[column, line] != '-' && (verticalCheck || horizontalCheck))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
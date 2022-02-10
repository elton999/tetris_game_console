using System;
using tetris.interfaces;

namespace tetris
{
    public class Grid : IPrint, ILocations
    {
        private int _x = 0;
        private int _y = 0;
        public int X {get => _x; set => _x = value;}
        public int Y {get => _y; set => _y = value;}
        public char[,] Cells;

        public Grid(int x, int y)
        {
            this.X = x;
            this.Y = y;

            Cells = new char[X, Y];
            for(int column = 0; column < X; column++)
            {
                for(int line = 0; line < Y; line++)
                {
                    Cells[column,line] = '-';
                }
            }
        }

        public void SetPieceOnGrid(Piece piece)
        {
            for(int column = 0; column < 6; column++)
            {
                for(int line = 0; line < 6; line++)
                {
                    if(Cells[column, line] == '-' &&  piece.FormObject[column, line] != '-')
                    {
                        Cells[column + piece.X, line + piece.Y] = piece.FormObject[column, line];
                    }
                }
            }
        }

        public void ClearLastGridLine(int yPiecePosition)
        {
        }

        public void Print()
        {
            for(int line = 0; line < Y; line++)
            {
                for(int column = 0; column < X; column++)
                {
                    Console.SetCursorPosition(column, line);
                    Console.Write(Cells[column, line]);
                }
            }
        }
    }
}
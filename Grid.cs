using System;
using tetris.interfaces;

namespace tetris
{
    public class Grid : IPrint, ISize, ILocations, IClearCells
    {
        private int _sizeX = 0;
        private int _sizeY = 0;

        public int SizeX {get => _sizeX; set => _sizeX = value;}
        public int SizeY {get => _sizeY; set => _sizeY = value;}
        public int X {get; set;}
        public int Y {get; set;}

        public char[,] Cells;

        public Lines Lines;

        public Grid(int x, int y)
        {
            SizeX = x;
            SizeY = y;
            X = 1;
            Y = 1;

            Cells = new char[SizeX, SizeY];
            for(int column = 0; column < SizeX; column++)
            {
                for(int line = 0; line < SizeY; line++)
                {
                    Cells[column,line] = '-';
                }
            }
            Lines = new Lines(this);
        }

        public void PushCellsFromLine(int fromLine)
        {
            for(int line = fromLine; line >= 0; line--)
            {
                for(int column = 0; column < SizeX; column++ )
                {
                    if(line == 0) Cells[column, line] = '-';
                    else Cells[column, line] = Cells[column, line - 1];
                }
            }
        }

        public void SetPieceOnGrid(Piece piece)
        {
            for(int line = 0; line < 6; line++)
            {
                for(int column = 0; column < 6; column++)
                {
                    int x = Math.Clamp(column + piece.X, 0, SizeX - 1);
                    int y = Math.Clamp(line + piece.Y, 0, SizeY - 1);
                    if (Cells[x, y] == '-' &&  piece.FormObject[line, column] != '-')
                    {
                        Cells[x, y] = piece.FormObject[line, column];
                    }
                }
            }
        }

        public void Print()
        {
            for(int line = 0; line < SizeY; line++)
            {
                for(int column = 0; column < SizeX; column++)
                {
                    Console.SetCursorPosition(column + X, line + Y);
                    Console.Write(Cells[column, line]);
                }
            }
        }

        public void Clear()
        {
            for (int line = 0; line < SizeY; line++)
            {
                for(int column = 0; column < SizeX; column++)
                {
                    Cells[column, line] = '-';
                }
            }
        }
    }
}
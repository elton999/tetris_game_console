using System.Collections.Generic;
using System;
using tetris.interfaces;

namespace tetris
{
    public class Grid : IPrint
    {
        private int _sizeX = 0;
        private int _sizeY = 0;

        public int SizeX {get => _sizeX; set => _sizeX = value;}
        public int SizeY {get => _sizeY; set => _sizeY = value;}
        public int X = 0;
        public int Y = 0;

        public char[,] Cells;
        public List<int> LinesComplete = new List<int>();

        public Grid(int x, int y)
        {
            this.SizeX = x;
            this.SizeY = y;

            Cells = new char[SizeX, SizeY];
            for(int column = 0; column < SizeX; column++)
            {
                for(int line = 0; line < SizeY; line++)
                {
                    Cells[column,line] = '-';
                }
            }
        }

        public void CheckLinesComplete()
        {
            List<int> lines = new List<int>();

            for(int line = 0; line < SizeY; line++)
            {
                int numberOfCells = 0;
                for(int column = 0; column < SizeX; column++)
                {
                    if(!Collision.IsCellFree(Cells, column, line)) numberOfCells++;
                }
                if(numberOfCells == SizeX) lines.Add(line);
            }
            LinesComplete = lines;
        }

        public void ClearCompletedLines()
        {
            //TODO: Create a new class for lines processes
            foreach (int lineComplete in LinesComplete)
            {
                ClearLine(lineComplete);
                PushCellsFromLine(lineComplete);
            }
            LinesComplete = new List<int>();
        }

        public void ClearLine(int line)
        {
            for(int column = 0; column < SizeX; column++)
            {
                Cells[column, line] = '-';
            }
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
                    if(Cells[Math.Clamp(column + piece.X, 0, SizeX - 1), Math.Clamp(line + piece.Y, 0, SizeY - 1)] == '-' &&  piece.FormObject[line, column] != '-')
                    {
                        Cells[Math.Clamp(column + piece.X, 0, SizeX - 1), Math.Clamp(line + piece.Y, 0, SizeY - 1)] = piece.FormObject[line, column];
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    public class Lines
    {
        private Grid _Grid;
        public List<int> LinesComplete = new List<int>();

        public Lines(Grid grid)
        {
            _Grid = grid;
        }

        public void CheckLinesComplete()
        {
            List<int> lines = new List<int>();

            for (int line = 0; line < _Grid.SizeY; line++)
            {
                int numberOfCells = 0;
                for (int column = 0; column < _Grid.SizeX; column++)
                {
                    if (!Collision.IsCellFree(_Grid.Cells, column, line)) numberOfCells++;
                }
                if (numberOfCells == _Grid.SizeX) lines.Add(line);
            }
            LinesComplete = lines;
        }

        public void ClearCompletedLines()
        {
            foreach (int lineComplete in LinesComplete)
            {
                ClearLine(lineComplete);
                PushCellsFromLine(lineComplete);
            }
            LinesComplete = new List<int>();
        }

        public void ClearLine(int line)
        {
            for (int column = 0; column < _Grid.SizeX; column++)
            {
                _Grid.Cells[column, line] = '-';
            }
        }

        public void PushCellsFromLine(int fromLine)
        {
            for (int line = fromLine; line >= 0; line--)
            {
                for (int column = 0; column < _Grid.SizeX; column++)
                {
                    if (line == 0) _Grid.Cells[column, line] = '-';
                    else _Grid.Cells[column, line] = _Grid.Cells[column, line - 1];
                }
            }
        }
    }
}

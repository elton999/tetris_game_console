using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tetris
{
    public class GridEfx
    {
        private int _Blinks = 8;
        public Grid Grid;
        public Queue<char> SequenceCharBlink = new Queue<char>();
        
        public GridEfx(Grid grid)
        {
            Grid = grid;
            SequenceCharBlink.Enqueue('X');
            SequenceCharBlink.Enqueue('+');
        }

        public void Update()
        {
            if(_Blinks > 0) return;
            Grid.ClearCompletedLines();
            _Blinks = 8;
        }

        public void Print()
        {
            if(Grid.LinesComplete.Count == 0) return;
            if(_Blinks <= 0) return;

            _Blinks--;

            char effectBlink = SequenceCharBlink.Dequeue();
            
            foreach(int line in Grid.LinesComplete)
            {
                for(int column = 0; column < Grid.SizeX; column++)
                {
                    Grid.Cells[column, line] = effectBlink;
                }
            }

            SequenceCharBlink.Enqueue(effectBlink);
        }
    }
}
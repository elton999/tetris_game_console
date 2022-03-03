using System.Collections.Generic;
using tetris.interfaces;

namespace tetris
{
    public class GridEfx : IUpdateObject, IPrint
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
            Grid.Lines.ClearCompletedLines();
            _Blinks = 8;
        }

        public void Print()
        {
            if(Grid.Lines.LinesComplete.Count == 0) return;
            if(_Blinks <= 0) return;

            _Blinks--;

            char effectBlink = SequenceCharBlink.Dequeue();
            
            foreach(int line in Grid.Lines.LinesComplete)
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
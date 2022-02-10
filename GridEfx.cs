using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tetris
{
    public class GridEfx
    {
        public Grid Grid;
        public Queue<char> EffectBlink = new Queue<char>();
        
        public GridEfx(Grid grid)
        {
            Grid = grid;
            EffectBlink.Enqueue('X');
            EffectBlink.Enqueue('+');
        }

        public void Print()
        {
            if(Grid.LinesComplete.Count == 0) return;
            char effectBlink = EffectBlink.Dequeue();
            
            foreach(int line in Grid.LinesComplete)
            {
                for(int column = 0; column < Grid.SizeX; column++)
                {
                    Grid.Cells[column, line] = effectBlink;
                }
            }

            EffectBlink.Enqueue(effectBlink);
        }
    }
}
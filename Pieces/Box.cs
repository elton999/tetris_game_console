using System;

namespace tetris.Pieces
{
    public class Box : Piece
    {
        public override void Start()
        {
            base.Start();
            FormObject = new char[6,6] {
                {'B', 'B', '-', '-', '-', '-'},
                {'B', 'B', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
            };
        }
    }
}
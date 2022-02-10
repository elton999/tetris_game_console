using System;

namespace tetris.Pieces
{
    public class BoxPiece : Piece
    {
        public BoxPiece()
        {
            FormObject = new char[6,6] {
                {'#', '#', '-', '-', '-', '-'},
                {'#', '#', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
            };
        }
    }
}
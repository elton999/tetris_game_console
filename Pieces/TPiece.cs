namespace tetris.Pieces
{
    public class TPiece : Piece
    {
        public TPiece()
        {
            FormObject = new char[6,6] {
                {'#', '-', '-', '-', '-', '-'},
                {'#', '#', '-', '-', '-', '-'},
                {'#', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
            };
        }
    }
}
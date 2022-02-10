namespace tetris.Pieces
{
    public class LPiece : Piece
    {
        public LPiece()
        {
            FormObject = new char[6,6] {
                {'-', '-', '#', '-', '-', '-'},
                {'#', '#', '#', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
            };
        }
    }
}
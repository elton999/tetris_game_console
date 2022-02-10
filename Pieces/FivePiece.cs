namespace tetris.Pieces
{
    public class FivePiece : Piece
    {
        public FivePiece()
        {
            FormObject = new char[6,6] {
                {'#', '#', '-', '-', '-', '-'},
                {'-', '#', '#', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
            };
        }
    }
}
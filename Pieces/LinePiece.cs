namespace tetris.Pieces
{
    public class LinePiece : Piece
    {
        public LinePiece()
        {
            FormObject = new char[6,6] {
                {'#', '#', '#', '#', '#', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
            };
        }        
    }
}
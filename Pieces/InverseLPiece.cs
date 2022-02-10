namespace tetris.Pieces
{
    public class InverseLPiece : Piece
    {
        public InverseLPiece()
        {
            FormObject = new char[6,6] {
                {'#', '-', '-', '-', '-', '-'},
                {'#', '#', '#', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
                {'-', '-', '-', '-', '-', '-'},
            };
        }   
    }
}
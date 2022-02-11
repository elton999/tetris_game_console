using System;
using tetris.Pieces;

namespace tetris
{
    public class PieceRaffle 
    {
        public static Piece GetNewPiece()
        {
            Random random = new Random();
            int pieceNumber = random.Next(0, 7);

            return GetPieceFromNumber(pieceNumber);
        }

        public static Piece GetPieceFromNumber(int pieceNumber)
        {
            switch (pieceNumber)
            {
                /*case 0:
                    return new BoxPiece();
                case 1:
                    return new FivePiece();
                case 2:
                    return new InverseLPiece();
                case 3:
                    return new LinePiece();
                case 4:
                    return new LPiece();
                case 5:
                    return new SPiece();*/
                default:
                    return new TPiece();
            }
        }
    }
}
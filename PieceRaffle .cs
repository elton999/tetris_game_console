using System;
using tetris.Pieces;

namespace tetris
{
    public class PieceRaffle 
    {
        public static Piece GetNewPiece()
        {
            Random random = new Random();
            int pieceNumber = random.Next(0, 6);

            return GetPieceFromNumber(pieceNumber);
        }

        public static Piece GetPieceFromNumber(int pieceNumber)
        {
            switch (pieceNumber)
            {
                case 0:
                    return new BoxPiece();
                    break;
                case 1:
                    return new FivePiece();
                    break;
                case 2:
                    return new InverseLPiece();
                    break;
                case 3:
                    return new LinePiece();
                    break;
                case 4:
                    return new LPiece();
                    break;
                case 5:
                    return new SPiece();
                    break;
                default:
                    return new TPiece();
                    break;
            }
        }
    }
}
using System;
using tetris.interfaces;

namespace tetris
{
    public class PieceManager : IUpdateObject, IPrint
    {
        public Piece CurrentPiece;
        public Grid Grid;

        public PieceManager(Grid grid)
        {
            Grid = grid;
            CurrentPiece = PieceRaffle.GetNewPiece();
        }

        public void Update()
        {
            if(Grid.LinesComplete.Count > 0) return;

            CurrentPiece.Update();

            if(Collision.IsColliding(CurrentPiece, Grid, CurrentPiece.X, CurrentPiece.Y + 1))
            {
                Grid.SetPieceOnGrid(CurrentPiece);
                CurrentPiece = PieceRaffle.GetNewPiece();
            }
        }

        public void Print()
        {
            if(CurrentPiece.PieceMovement != null)
                CurrentPiece.Print();
        }
    }
}
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
        }

        public void Update()
        {
            CurrentPiece.Update();

            if(Collision.IsColliding(CurrentPiece, Grid, CurrentPiece.X, CurrentPiece.Y + 1))
            {
                Grid.SetPieceOnGrid(CurrentPiece);
                SetNewPiece();
            }
        }

        public void Print()
        {
            if(CurrentPiece.PieceMovement != null)
                CurrentPiece.Print();
        }

        public void SetNewPiece()
        {
            CurrentPiece = new Pieces.Box();
            CurrentPiece.Start();
        }
    }
}
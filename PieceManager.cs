using tetris.interfaces;

namespace tetris
{
    public class PieceManager : IUpdateObject, IPrint
    {
        public Piece CurrentPiece;
        public Grid Grid;
        public UI UI;

        public PieceManager(Grid grid, UI ui)
        {
            Grid = grid;
            UI = ui;
            CurrentPiece = PieceRaffle.GetNewPiece();
        }

        public void Update()
        {
            if(UI.IsGameOver)
            {
                if (Input.Instance.Restart)
                {
                    UI.StartGame();
                    CurrentPiece = PieceRaffle.GetNewPiece();
                }
                return;
            }

            if(Grid.Lines.LinesComplete.Count > 0) return;

            CurrentPiece.Update();

            if(Collision.IsColliding(CurrentPiece, Grid, CurrentPiece.X, CurrentPiece.Y + 1))
            {
                Grid.SetPieceOnGrid(CurrentPiece);
                
                if(CurrentPiece.Y == 0)
                {
                    UI.GameOver();
                    return;
                }

                CurrentPiece = PieceRaffle.GetNewPiece();
            }
        }

        public void Print()
        {
            if(CurrentPiece.PieceMovement != null && !UI.IsGameOver)
                CurrentPiece.Print();
        }
    }
}
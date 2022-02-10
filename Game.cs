using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tetris
{
    public class Game
    {
        public Grid Grid;
        public PieceManager PieceManager;
        public PieceMovement PieceMovement;
        public GridEfx GridEfx;

        public void Start()
        {
            Grid = new Grid(10, 20);
            Grid.Print();
            GridEfx = new GridEfx(Grid);

            PieceMovement = new PieceMovement();
            PieceMovement.Grid = Grid;

            PieceManager = new PieceManager(Grid);
            PieceManager.SetNewPiece();
        }

        public void Update()
        {
            Grid.CheckLinesComplete();

            InputHandler.Instance.Update();
            
            PieceManager.CurrentPiece.PieceMovement = PieceMovement;
            PieceManager.Update();
        }

        public void Print()
        {
            Grid.Print();
            GridEfx.Print();
            PieceManager.Print();
        }
    }
}
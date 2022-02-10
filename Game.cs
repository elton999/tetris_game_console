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

        public void Start()
        {
            Grid = new Grid(10, 20);
            Grid.Print();

            PieceMovement = new PieceMovement();
            PieceMovement.Grid = Grid;

            PieceManager = new PieceManager(Grid);
            PieceManager.SetNewPiece();
        }

        public void Update()
        {
            InputHandler.Instance.Update();
            
            PieceManager.CurrentPiece.PieceMovement = PieceMovement;
            PieceManager.Update();
        }

        public void Print()
        {
            Grid.Print();
            PieceManager.Print();
        }
    }
}
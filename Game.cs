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
        public Piece CurrentPiece;
        public PieceMovement PieceMovement;

        public void Start()
        {
            Grid = new Grid(10, 20);
            Grid.Print();

            PieceMovement = new PieceMovement();
            PieceMovement.Grid = Grid;

            CurrentPiece = new Pieces.Box();
            CurrentPiece.Start();
            CurrentPiece.PieceMovement = PieceMovement;

        }

        public void Update()
        {
            CurrentPiece.PieceMovement = PieceMovement;

            InputHandler.Instance.Update();

            CurrentPiece.Update();
        }

        public void Print()
        {
            Grid.Print();
            CurrentPiece.Print();
        }
    }
}
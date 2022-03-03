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
        public GridEfx GridEfx;
        public PieceManager PieceManager;
        public PieceMovement PieceMovement;
        public UI UI;

        public void Start()
        {
            Grid = new Grid(10, 20);
            Grid.Print();
            GridEfx = new GridEfx(Grid);

            PieceMovement = new PieceMovement(Grid);
            PieceManager = new PieceManager(Grid);

            UI = new UI();
        }

        public void Update()
        {
            Grid.Lines.CheckLinesComplete();

            Input.Instance.Update();
            
            PieceManager.CurrentPiece.PieceMovement = PieceMovement;
            PieceManager.Update();
            GridEfx.Update();
        }

        public void Print()
        {
            Grid.Print();
            GridEfx.Print();
            PieceManager.Print();
            UI.Print();
        }
    }
}
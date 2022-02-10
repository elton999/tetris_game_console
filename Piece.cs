using System;
using tetris.interfaces;

namespace tetris
{
    public abstract class Piece : Cell, IObjectForm, IPrint, ILocations, IUpdateObject
    {
        private int _x = 0;
        private int _y = 0;
        
        public char[,] FormObject {get; set;}
        public int X {get => _x; set => _x = value;}
        public int Y {get => _y; set => _y = value;}

        public PieceMovement PieceMovement;

        public void Update()
        {
            SetMovementSettings();

            int yIncrement = 1;
            int xIncrement = 0;

            if (InputHandler.Instance.MoveRight)
                xIncrement = 1;
            if (InputHandler.Instance.MoveLeft)
                xIncrement = -1;

            PieceMovement.Move(X + xIncrement, Y + yIncrement);
        }

        public void SetMovementSettings()
        {
            PieceMovement.Form = this;
            PieceMovement.Location = this;
        }

        public void Print()
        {
            for(int line = 0; line < 6; line++)
            {
                for(int column = 0; column < 6; column++)
                {
                    int xLocation = X + column;
                    int yLocation = Y + line;
                    PrintCell(FormObject[line, column], xLocation, yLocation, PieceMovement.Grid);
                }
            }
        }
    }
}
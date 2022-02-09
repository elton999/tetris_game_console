using System;
using tetris.interfaces;

namespace tetris
{
    public abstract class Piece : IObjectForm, IPrint, ILocations, IStartObject, IUpdateObject
    {
        private int _x = 0;
        private int _y = 0;
        
        public char[,] FormObject {get; set;}
        public int X {get => _x; set => _x = value;}
        public int Y {get => _y; set => _y = value;}

        public PieceMovement PieceMovement;

        public virtual void Start() {}

        public void Update()
        {
            PieceMovement.Move(X, Y + 1);
        }

        public void Print()
        {
            for(int line = 0; line < 6; line++)
            {
                for(int column = 0; column < 6; column++)
                {
                    int xLocation = X + column;
                    int yLocation = Y + line;
                    PrintBlock(xLocation, yLocation);
                }
            }
        }

        private void PrintBlock(int xLocation, int yLocation)
        {
            char[,] cells = PieceMovement.Grid.Cells;
            if (xLocation < PieceMovement.Grid.X && yLocation < PieceMovement.Grid.Y)
            {
                if(cells[xLocation, yLocation] == '-')
                {
                    Console.SetCursorPosition(xLocation, yLocation);
                    Console.Write(FormObject[yLocation - Y, xLocation - X]);
                }
            }
        }
    }
}
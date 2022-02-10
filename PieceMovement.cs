using System;
using tetris.interfaces;

namespace tetris
{
    public class PieceMovement
    {
        public Grid Grid;
        public IObjectForm Form;
        public ILocations Location;

        public PieceMovement(Grid grid)
        {
            Grid = grid;
        }

        public void Move(int x, int y)
        {
            if(!Collision.IsColliding(Form, Grid, x, y))
            {
                Location.X = x;
                Location.Y = y;
            }
        }
    }
}
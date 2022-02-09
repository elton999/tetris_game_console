using System;
using tetris.interfaces;

namespace tetris
{
    public class PieceMovement
    {
        public Grid Grid;
        public IObjectForm Form;
        public ILocations Location;

        public void Move(int x, int y)
        {
            if(!Collision.IsOutOfGrid(Form, Grid, x, y))
            {
                Location.X = x;
                Location.Y = y;
            }
        }
    }
}
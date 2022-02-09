using System;
using tetris.interfaces;

namespace tetris
{
    public sealed class InputHandler : IUpdateObject
    {
        private static InputHandler _instance;
        public static InputHandler Instance 
        {
            get 
            {
                if(_instance == null)
                    _instance = new InputHandler();
                return _instance;
            }
        }

        public bool MoveLeft = false;
        public bool MoveRight = false;

        public void Update()
        {
            MoveRight = Input.Key == ConsoleKey.RightArrow;
            MoveLeft = Input.Key == ConsoleKey.LeftArrow;
        }
    }
}
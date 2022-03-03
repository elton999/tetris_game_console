using System;
using tetris.interfaces;

namespace tetris
{
    public sealed class Input : IUpdateObject
    {
        private static Input _instance;
        public static Input Instance 
        {
            get 
            {
                if(_instance == null)
                    _instance = new Input();
                return _instance;
            }
        }

        public bool MoveLeft = false;
        public bool MoveRight = false;
        public bool Rotate = false;

        public void Update()
        {
            MoveRight = InputSettings.Key == ConsoleKey.RightArrow;
            MoveLeft = InputSettings.Key == ConsoleKey.LeftArrow;
            Rotate = InputSettings.Key == ConsoleKey.UpArrow;
        }
    }
}
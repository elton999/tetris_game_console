using System;
using tetris.interfaces;

namespace tetris
{
    public class UI : IPrint
    {
        private bool _isGameOver = false;
        public bool IsGameOver { get => _isGameOver; }
        public int Score = 0;
        public Grid Grid;

        public UI(Grid grid)
        {
            Grid = grid;
        }

        public void Print()
        {
            PrintGameOver();

            PrintHorizontalLine(1, 10, 0);
            PrintHorizontalLine(12, 20, 0);

            Console.SetCursorPosition(13, 2);
            Console.Write("Score:");
            PrintHorizontalLine(12, 20, 3);

            Console.SetCursorPosition(13, 5);
            Console.Write(Score);
            PrintHorizontalLine(12, 20, 6);

            PrintHorizontalLine(1, 10, 21);
            PrintHorizontalLine(12, 20, 21);

            PrintVerticalLine(1, 20, 0);
            PrintVerticalLine(1, 20, 11);
            PrintVerticalLine(1, 20, 21);
        }

        public void PrintHorizontalLine(int start, int end, int verticalPosition)
        {
            for(int i = start; i <= end; i++)
            {
                Console.SetCursorPosition(i, verticalPosition);
                Console.Write('_');
            }
        }

        public void GameOver()
        {
            _isGameOver = true;
            Grid.Clear();
        }

        public void StartGame()
        {
            Grid.Clear();
            _isGameOver = false;
            Score = 0;
        }

        public void PrintGameOver()
        {
            if(IsGameOver)
            {
                Console.SetCursorPosition(2, 10);
                Console.Write("GameOver");
            }
        }

        public void PrintVerticalLine(int start, int end, int horizontalPosition)
        {
            for(int i = start; i <= end; i++)
            {
                Console.SetCursorPosition(horizontalPosition, i);
                Console.Write('|');
            }
        }
    }
}
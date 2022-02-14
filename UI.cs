using System;
using tetris.interfaces;

namespace tetris
{
    public class UI : IPrint
    {
        public void Print()
        {
            PrintHorizontalLine(1, 10, 0);
            PrintHorizontalLine(12, 20, 0);

            Console.SetCursorPosition(13, 2);
            Console.Write("Score:");
            PrintHorizontalLine(12, 20, 3);

            Console.SetCursorPosition(13, 5);
            Console.Write("0001");
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
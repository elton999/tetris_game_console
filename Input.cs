using System;
using tetris.interfaces;

namespace tetris
{
    public class Input
    {
        public static ConsoleKey Key = ConsoleKey.NumPad0;

        public static void Reset()
        {
            Key = ConsoleKey.NumPad0;
        }

        public static void CheckKey()
        {
            while(true)
            {
                Key = Console.ReadKey(true).Key;
            }
        }
    }
}
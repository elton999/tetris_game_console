using System.Threading;
using System;

namespace tetris
{
    class Program
    {
        static Game Game = new Game();
        public static void Main()
        {
            Game.Start();
            Console.Clear();

            while(true)
            {
                Game.Update();
                Game.Print();
                Thread.Sleep(200);
            }
        }
    }
}

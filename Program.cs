using System.Threading;
using System;

namespace tetris
{
    class Program
    {
        static Game Game = new Game();
        public static void Main()
        {
            var inputThread = new Thread(Input.CheckKey);
            inputThread.Start();
            
            Game.Start();
            Console.Clear();

            while(true)
            {
                Game.Update();
                Game.Print();

                Input.Reset();
                
                Thread.Sleep(200);
            }
        }
    }
}

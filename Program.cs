using System.Threading;
using System;

namespace tetris
{
    class Program
    {
        static Game Game = new Game();
        public static void Main()
        {
            var inputThread = new Thread(InputSettings.CheckKey);
            inputThread.Start();
            
            Game.Start();
            Console.Clear();

            while(true)
            {
                Game.Update();
                Game.Print();

                InputSettings.Reset();
                
                Thread.Sleep(200);
            }
        }
    }
}

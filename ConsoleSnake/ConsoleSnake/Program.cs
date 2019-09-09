using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(10, 20);
            ConsoleKey keyPressed = ConsoleKey.Spacebar;
            bool quit = false;
            ManualResetEvent mre = new ManualResetEvent(false);
            int count = 0;

            Task drawer = Task.Factory.StartNew(() =>
            {
                while (!quit)
                {
                    count++;
                    map.Draw();
                    Console.WriteLine(keyPressed);
                    Console.WriteLine(count);
                    mre.WaitOne(500);
                    mre.Reset();
                    Console.Clear();
                }
            });

            Task keyListener = Task.Factory.StartNew(() =>
            {
                while (!quit)
                {
                    keyPressed = Console.ReadKey().Key;
                    mre.Set();
                    if (keyPressed == ConsoleKey.Q)
                    {
                        quit = true;
                    }
                }
            });
            while (!quit)
            {

            }
        }
    }
}

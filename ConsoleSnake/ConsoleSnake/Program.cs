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
            //List<List<IDrawable>> map = new List<List<IDrawable>>();
            //map.Add(new List<IDrawable> { new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#') });
            //map.Add(new List<IDrawable> { new Tile('#'), new Tile('*'), new Tile('*'), new Tile('*'), new Tile('#') });
            //map.Add(new List<IDrawable> { new Tile('#'), new Tile('*'), new Tile('*'), new Tile('*'), new Tile('#') });
            //map.Add(new List<IDrawable> { new Tile('#'), new Tile('*'), new Tile('*'), new Tile('*'), new Tile('#') });
            //map.Add(new List<IDrawable> { new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#') });
            //map.Draw();
            Map map = new Map(10, 10);
            ConsoleKey keyPressed = ConsoleKey.Spacebar;
            bool quit = false;
            ManualResetEvent mre = new ManualResetEvent(false);

            Task drawer = Task.Factory.StartNew(() =>
            {
                while (!quit)
                {
                    map.Draw();
                    Console.WriteLine(keyPressed);
                    Thread.Sleep(500);
                    Console.Clear();
                }
            });

            Task keyListener = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    keyPressed = Console.ReadKey().Key;
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

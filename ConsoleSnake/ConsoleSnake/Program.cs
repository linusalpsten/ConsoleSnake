using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<IDrawable>> map = new List<List<IDrawable>>();
            map.Add(new List<IDrawable> { new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#') });
            map.Add(new List<IDrawable> { new Tile('#'), new Tile('*'), new Tile('*'), new Tile('*'), new Tile('#') });
            map.Add(new List<IDrawable> { new Tile('#'), new Tile('*'), new Tile('*'), new Tile('*'), new Tile('#') });
            map.Add(new List<IDrawable> { new Tile('#'), new Tile('*'), new Tile('*'), new Tile('*'), new Tile('#') });
            map.Add(new List<IDrawable> { new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#'), new Tile('#') });
            map.Draw();
        }
    }
}

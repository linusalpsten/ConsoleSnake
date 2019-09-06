using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public class Tile : IDrawable
    {
        char tile = ' ';

        public char GetDrawing()
        {
            return tile;
        }
    }
}

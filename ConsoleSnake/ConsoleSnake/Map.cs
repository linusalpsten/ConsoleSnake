using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    class Map
    {
        List<List<IDrawable>> map = new List<List<IDrawable>>();
        public Map(int width, int height)
        {
            if (width < 2 || height <2)
            {
                throw new ArgumentException("Map must be atleast 2 high and 2 wide.");
            }
            List<IDrawable> firstRow = new List<IDrawable>();
            for (int i = 0; i < width; i++)
            {
                firstRow.Add(new Tile('#'));
            }
            map.Add(firstRow);
            for (int i = 0; i < height-2; i++)
            {
                List<IDrawable> row = new List<IDrawable>();
                row.Add(new Tile('#'));
                for (int j = 0; j < width-2; j++)
                {
                    row.Add(new Tile('*'));
                }
                row.Add(new Tile('#'));
                map.Add(row);
            }
            List<IDrawable> lastRow = new List<IDrawable>();
            for (int i = 0; i < width; i++)
            {
                lastRow.Add(new Tile('#'));
            }
            map.Add(lastRow);
        }

        public void Draw()
        {
            map.Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSnake
{
    public static class Extensions
    {
        public static void Draw(this IEnumerable<IEnumerable<IDrawable>> drawables)
        {
            foreach (var row in drawables)
            {
                foreach (var column in row)
                {
                    Console.Write(column.GetDrawing());
                }
                Console.WriteLine();
            }
        }
    }
}

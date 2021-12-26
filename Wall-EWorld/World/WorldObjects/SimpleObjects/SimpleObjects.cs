using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public abstract class SimpleObjects : WorldObjects
    {
        /// <summary>
        /// Initializes an obstacle (Lifeless object(Ball, Box, Plant))
        /// </summary>
        /// <param name="space"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="shape"></param>
        /// <param name="size"></param>
        /// <param name="number"></param>
        protected SimpleObjects(Space space, int x, int y, int color, int size, int number) : base(space, x, y, color, size, number) { }

        /// <summary>
        /// Returns if the SimpleObject is portable
        /// </summary>
        /// <returns></returns>
        public override bool Portable()
        {
            return Size == 1;
        }

        /// <summary>
        /// Returns if the object can be dropped
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool CanDrop(int direction)
        {
            return space.IsInside(Row + dirRow[direction], Column + dirCol[direction]) && space[Row + dirRow[direction], Column + dirCol[direction]].Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public abstract class WorldObjects : IBarrier, IMovable, IPortable
    {

        protected static int[] dirRow = { -1, 0, 1, 0 };
        protected static int[] dirCol = { 0, 1, 0, -1 };

        protected Space space;
        protected Mediator mediator;
        
        /// <summary>
        /// Initializes an object
        /// </summary>
        /// <param name="space"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="shape"></param>
        /// <param name="size"></param>
        /// <param name="number"></param>
        protected WorldObjects(Space space, int x, int y, int color, int size, int number)
        {
            this.space = space;
            this.mediator = new Mediator(space);
            if (space.IsInside(x, y))
            {
                Row = x;
                Column = y;
                Color = color;
                Size = size;
                Number = number;
            }
        }

        internal int Row { get; set; }
        internal int Column { get; set; }
        public int Shape { get; set; }
        internal int Color { get; private set; }
        internal int Size { get; private set; }
        internal int Number { get; private set; }
        internal bool Stored { get; set; }

        /// <summary>
        /// Defines if the object is a barrier
        /// </summary>
        public abstract bool Barrier(int direction);
        /// <summary>
        /// Defines if the object can be moved
        /// </summary>
        public abstract bool Movable(int direction);
        /// <summary>
        /// Defines how the object is moved
        /// </summary>
        /// <param name="direction"></param>
        public abstract void Move(int direction);
        /// <summary>
        /// Defines if the object can be taken
        /// </summary>
        public abstract bool Portable();
        /// <summary>
        /// Defines if the object can be dropped
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public abstract bool CanDrop(int direction);

        public override string ToString()
        {
            return Size.ToString() + Color.ToString() + Shape.ToString();
        }
    }
}

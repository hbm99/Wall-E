using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Plant : SimpleObjects
    {
        public Plant(Space space, int x, int y, int color, int size, int number) : base(space, x, y, color, size, number)
        {
            Shape = 3;
        }
        /// <summary>
        /// Returns if the Plant represents a barrier
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Barrier(int direction)
        {
            return !Portable();
        }
        /// <summary>
        /// Returns if the Plant can be moved
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Movable(int direction)
        {
            return false;
        }
        /// <summary>
        /// Represents the Plant's movement
        /// </summary>
        /// <param name="direction"></param>
        public override void Move(int direction) { }
    }
}

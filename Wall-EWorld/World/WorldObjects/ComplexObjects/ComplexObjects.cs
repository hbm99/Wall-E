using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public abstract class ComplexObjects : WorldObjects, IProgramable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="space"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="shape"></param>
        /// <param name="size"></param>
        /// <param name="number"></param>
        protected ComplexObjects(Space space, int x, int y, int shape, int color, int number, int direction) : base(space, x, y, color, 3, number) { }
        /// <summary>
        /// Returns if the ComplexObject represents a barrier
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Barrier(int direction)
        {
            return true;
        }
        /// <summary>
        /// Returns if the ComplexObject can be dropped
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool CanDrop(int direction)
        {
            return false;
        }
        /// <summary>
        /// Returns if the ComplexObject can be moved
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Movable(int direction)
        {
            return false;
        }
        /// <summary>
        /// Returns if the ComplexObject is portable
        /// </summary>
        /// <returns></returns>
        public override bool Portable()
        {
            return false;
        }
        /// <summary>
        /// Represents the ComplexObject movement
        /// </summary>
        /// <param name="direction"></param>
        public override void Move(int direction) { }

        public abstract void Execute();
    }
  
}

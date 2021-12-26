using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Box : SimpleObjects
    {
        public Box(Space space, int x, int y, int color, int size, int number) : base(space, x, y, color, size, number)
        {
            Shape = 2;
        }
        /// <summary>
        /// Returns if the Box represents a barrier
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Barrier(int direction)
        {
            return !Movable(direction);
        }
        /// <summary>
        /// Returns if the Box can be moved
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Movable(int direction)
        {
            return Size == 3 ? false : space[Row + dirRow[direction], Column + dirCol[direction]].Empty;
        }
        /// <summary>
        /// Represents the Box's movement
        /// </summary>
        /// <param name="direction"></param>
        public override void Move(int direction)
        {
            if (!Movable(direction)) return;

            Box ImGoingToMove = (Box)space[Row + dirRow[direction], Column + dirCol[direction]].Object;
            ImGoingToMove.Move(direction);
            mediator.MoveObject(Row, Column, Row + dirRow[direction], Column + dirCol[direction]);
        }
    }
}

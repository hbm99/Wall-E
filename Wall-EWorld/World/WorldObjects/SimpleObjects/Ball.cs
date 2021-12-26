using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Ball : SimpleObjects
    {
        /// <summary>
        /// Initializes a Ball
        /// </summary>
        /// <param name="space"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="shape"></param>
        /// <param name="size"></param>
        /// <param name="number"></param>
        public Ball(Space space, int x, int y, int color, int size, int number) : base(space, x, y, color, size, number)
        {
            Shape = 1;
        }
        /// <summary>
        /// Returns if the Ball represents a barrier
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Barrier(int direction)
        {
            return !Movable(direction);
        }
        /// <summary>
        /// Returns if the Ball can be moved
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public override bool Movable(int direction)
        {
            if (space.IsInside(Row + dirRow[direction], Column + dirCol[direction]))
            {
                if (space[Row + dirRow[direction], Column + dirCol[direction]].Empty)
                    return true;
                else if (Size == 3) return false;
                else if (space[Row + dirRow[direction], Column + dirCol[direction]].Object.Shape == 1)
                {
                    Ball ImGoingToMove = (Ball)space[Row + dirRow[direction], Column + dirCol[direction]].Object;
                    return ImGoingToMove.Movable(direction);
                }
                else return false;
            }
            return false;
        }
        /// <summary>
        /// Represents the Ball's movement
        /// </summary>
        /// <param name="direction"></param>
        public override void Move(int direction)
        {
            if (Movable(direction))
            {

                if (space[Row + dirRow[direction], Column + dirCol[direction]].Empty)
                {
                    mediator.MoveObject(Row, Column, Row + dirRow[direction], Column + dirCol[direction]);
                    return;
                }
                else
                {
                    Ball IWillMove1 = (Ball)space[Row + dirRow[direction], Column + dirCol[direction]].Object;
                    IWillMove1.Move(direction);
                    mediator.MoveObject(Row, Column, Row + dirRow[direction], Column + dirCol[direction]);
                }
            }
        }
    }
}

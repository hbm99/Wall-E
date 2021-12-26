using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Mediator
    {
        Space world;

        public Mediator(Space world)
        {
            this.world = world;
        }
        /// <summary>
        /// Creates a SimpleObject(Ball,Box,Plant)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="shape"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool CreateSimpleObject(int x, int y, int shape, int size, int color, int number)
        {
            if (!world.IsInside(x, y)) return false;
            switch (shape)
            {
                case 0:
                    world[x, y] = new Place(null);
                    return true;
                case 1:
                    {
                        world[x, y] = new Place(new Ball(world, x, y, color, size, number));
                        world.AsociatedBarcodes.Add(number, world[x, y].Object);
                        return true;
                    }
                case 2:
                    {
                        world[x, y] = new Place(new Box(world, x, y, color, size, number));
                        world.AsociatedBarcodes.Add(number, world[x, y].Object);
                        return true;
                    }
                case 3:
                    {
                        world[x, y] = new Place(new Plant(world, x, y, color, size, number));
                        world.AsociatedBarcodes.Add(number, world[x, y].Object);
                        return true;
                    }
            }
            return false;
        }
        public bool CreateComplexObject(int x, int y, int shape, int size, int color, int number, int direction)
        {
            if (!world.IsInside(x, y)) return false;
            switch (shape)
            {
                case 4:
                    {
                        world[x, y] = new Place(new Robot(world, x, y, shape, size, color, number, direction));
                        world.AsociatedBarcodes.Add(number, world[x, y].Object);
                        return true;
                    }
            }
            return false;
        }

        /// <summary>
        /// Remove Objects on the space
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        public bool RemoveObject(int row, int column)
        {
            if (!world.IsInside(row, column)) 
                return false;

            world[row, column] = new Place(null);
            return true;
        }

        /// <summary>
        /// Moves Objects on the space
        /// </summary>
        /// <param name="rowStart"></param>
        /// <param name="colStart"></param>
        /// <param name="rowEnd"></param>
        /// <param name="colEnd"></param>
        /// <returns></returns>
        public bool MoveObject(int rowStart, int colStart, int rowEnd, int colEnd)
        {
            if (!world.IsInside(rowStart, colStart) || !world.IsInside(rowEnd, colEnd) || world[rowStart, colStart].Empty || !world[rowEnd, colEnd].Empty)
                return false;

            world[rowEnd, colEnd] = world[rowStart, colStart];

            world[rowEnd, colEnd].Object.Row = rowEnd;
            world[rowEnd, colEnd].Object.Column = colEnd;

            world[rowStart, colStart] = new Place(null);

            return true;
        }
    }
}

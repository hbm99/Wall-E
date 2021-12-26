using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Place
    {
        internal Place(WorldObjects a)
        {
            if (a == null) Empty = true;
            else { Object = a; Empty = false; }
        }
        /// <summary>
        /// Defines the object in the place
        /// </summary>
        public WorldObjects Object { get; set; }
        /// <summary>
        /// Defines if the place is empty or not
        /// </summary>
        internal bool Empty { get; private set; }
    }
    public class Space
    {
        Place[,] space;
        public Space(int rows, int columns)
        {
            space = new Place[rows, columns];
            for (int i = 0; i < space.GetLength(0); i++)
                for (int j = 0; j < space.GetLength(1); j++)
                    space[i, j] = new Place(null);
            AsociatedBarcodes = new Dictionary<int, WorldObjects>();
        }
        /// <summary>
        /// Indexer for the Space
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public Place this[int i,int j]
        {
            get { return space[i, j]; }
            set { space[i, j] = value; }
        }
        /// <summary>
        /// Returns the height of the space
        /// </summary>
        public int Rows { get { return space.GetLength(0); } }
        /// <summary>
        /// Returns the width of the space
        /// </summary>
        public int Columns { get { return space.GetLength(1); } }

        /// <summary>
        /// Dictionary with Barcodes
        /// </summary>
        public Dictionary<int, WorldObjects> AsociatedBarcodes { get; set; }
        /// <summary>
        /// Returns if [i,j] is valid
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public bool IsInside(int i, int j)
        {
            return i >= 0 && j >= 0 && i < space.GetLength(0) && j < space.GetLength(1);
        }

        /// <summary>
        /// Returns the List of Robots on the space
        /// </summary>
        /// <param name="world"></param>
        /// <returns></returns>
        public List<Robot> RobotsOnSpace()
        {
            List<Robot> robots = new List<Robot>();
            for (int i = 0; i < space.GetLength(0); i++)
                for (int j = 0; j < space.GetLength(1); j++)
                {
                    if (space[i, j].Object is Robot)
                        robots.Add((Robot)space[i, j].Object);
                }
            return robots;
        }
        /// <summary>
        /// Returns the List of simple objects on the space
        /// </summary>
        /// <returns></returns>
        public List<WorldObjects> WorldObjectsOnSpace()
        {
            List<WorldObjects> objects = new List<WorldObjects>();
            for (int i = 0; i < space.GetLength(0); i++)
                for (int j = 0; j < space.GetLength(1); j++)
                {
                    if (space[i, j].Object is WorldObjects)
                        objects.Add(space[i, j].Object);
                }
            return objects;
        }
    }
}

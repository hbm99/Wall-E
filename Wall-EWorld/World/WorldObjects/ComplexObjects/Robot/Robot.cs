using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Robot : ComplexObjects
    {
        int actionTime;
        int direction;
        int[] memory;

        WorldObjects sense;
        int distanceToSense;

        public MatrixLanguageMap CurrentRoutine { get { return RoutineStack.Peek(); } }
        /// <summary>
        /// Routines Stack
        /// </summary>
        public Stack<MatrixLanguageMap> RoutineStack { get; set; }
        
        /// <summary>
        /// Routines List
        /// </summary>
        public List<MatrixLanguageMap> RoutineList { get; set; }

        /// <summary>
        /// Robot's Stack
        /// </summary>
        public Stack<int> RobotStack { get; set; }
        
        /// <summary>
        /// Robot's Memory
        /// </summary>
        public int[] Memory { get { return memory; } }

        /// <summary>
        /// Returns if the Robot is equipped with an Object
        /// </summary>
        internal bool WithObject { get; private set; }
        /// <summary>
        /// It's the Object inside the Robot
        /// </summary>
        internal WorldObjects Taken { get; set; }

        internal int Direction { get { return direction; } set { direction = value; } }
        /// <summary>
        /// Initializes a Robot
        /// </summary>
        /// <param name="space"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="shape"></param>
        /// <param name="size"></param>
        /// <param name="number"></param>
        public Robot(Space space, int x, int y, int shape, int size, int color, int number, int direction) : base(space, x, y, shape, color, number, direction) 
        {
            RoutineStack = new Stack<MatrixLanguageMap>();
            RoutineList = new List<MatrixLanguageMap>();
            RobotStack = new Stack<int>();
            memory = new int[1000000];
            Shape = 4;
            Direction = direction;
        }
        /// <summary>
        /// Represents the Robot front movement
        /// </summary>
        internal void MoveForward()
        {
            actionTime += 1;

            if (space.IsInside(Row + dirRow[direction], Column + dirCol[direction]))
            {
                Place ImGoingToMove = space[Row + dirRow[direction], Column + dirCol[direction]];
                if (!ImGoingToMove.Empty) 
                {
                    if (!WithObject && ImGoingToMove.Object.Portable())
                    {
                        Taken = ImGoingToMove.Object;
                        Taken.Stored = true;
                        WithObject = true;
                        mediator.RemoveObject(Row + dirRow[direction], Column + dirCol[direction]);
                        mediator.MoveObject(Row, Column, Row + dirRow[direction], Column + dirCol[direction]);
                    }
                    else if (ImGoingToMove.Object.Movable(direction))
                    {
                        ImGoingToMove.Object.Move(direction);
                        mediator.MoveObject(Row, Column, Row + dirRow[direction], Column + dirCol[direction]);
                        if (WithObject)
                        {
                            Taken.Row = Row;
                            Taken.Column = Column;
                        }
                    }
                }
                else
                {
                    mediator.MoveObject(Row, Column, Row + dirRow[direction], Column + dirCol[direction]);
                    if (WithObject)
                    {
                        Taken.Row = Row;
                        Taken.Column = Column;
                    }
                }
            }
        }
        /// <summary>
        /// Represents the Robot back movement
        /// </summary>
        internal void MoveBackward()
        {
            actionTime += 1;
            int directionBackward;

            if (direction < 2) directionBackward = direction + 2;
            else directionBackward = direction - 2;

            if (space.IsInside(Row + dirRow[directionBackward], Column + dirCol[directionBackward]) && space[Row + dirRow[directionBackward], Column + dirCol[directionBackward]].Empty)
            {
                mediator.MoveObject(Row, Column, Row + dirRow[directionBackward], Column + dirCol[directionBackward]);
                if (WithObject)
                {
                    Taken.Row = Row;
                    Taken.Column = Column;
                }
            }
        }
        /// <summary>
        /// Represents how the Robot turns left
        /// </summary>
        internal void TurnLeft()
        {
            actionTime += 1;
            if (direction == 0) direction = 3;
            else direction--;
        }
        /// <summary>
        /// Represents how the Robot turns right
        /// </summary>
        internal void TurnRight()
        {
            actionTime += 1;
            if (direction == 3) direction = 0;
            else direction++;
        }
        /// <summary>
        /// Represents how the Robot drops an object
        /// </summary>
        internal void Drop()
        {
            actionTime += 1;

            if (WithObject)
            {
                Taken.Row = Row;
                Taken.Column = Column;
                if (Taken.CanDrop(direction))
                {
                    mediator.CreateSimpleObject(Row + dirRow[direction], Column + dirCol[direction], Taken.Shape, Taken.Size, Taken.Color, Taken.Number);
                    space[Row + dirRow[direction], Column + dirCol[direction]].Object.Stored = false;
                    WithObject = false;
                }
            }
        }
        /// <summary>
        /// The Robot pass a turn
        /// </summary>
        internal void Wait()
        {
            actionTime += 1;
        }
        /// <summary>
        /// Rerturns the time
        /// </summary>
        /// <returns></returns>
        internal int Time()
        {
            return actionTime;
        }
        /// <summary>
        /// Returns if the Robot is full, with an Object
        /// </summary>
        /// <returns></returns>
        internal bool Full()
        {
            return WithObject;
        }
        /// <summary>
        /// Returns how this Object feels
        /// </summary>
        /// <param name="direction"></param>
        public void Sense(int direction)
        {
            int i = Row + dirRow[direction];
            int j = Column = Column + dirCol[direction];
            distanceToSense = 0;
            while (space.IsInside(i, j))
            {
                if (space[i, j].Empty)
                    distanceToSense++;
                else sense = space[i, j].Object;

                i += dirRow[direction];
                j += dirCol[direction];
            }
        }
        /// <summary>
        /// Empty places in front of the Robot
        /// </summary>
        /// <returns></returns>
        internal int Ultrasonic()
        {
            Sense(direction);
            return distanceToSense;
        }
        /// <summary>
        /// Color of the front Object
        /// </summary>
        /// <returns></returns>
        internal int Webcam()
        {
            Sense(direction);
            if (sense != null)
                return sense.Color;
            else return 0;
        }
        /// <summary>
        /// Shape of the front Object
        /// </summary>
        /// <returns></returns>
        internal int Kinect()
        {
            Sense(direction);
            if (sense != null)
                return sense.Shape;
            else return 0;
        }
        /// <summary>
        /// Number of the front Object
        /// </summary>
        /// <returns></returns>
        internal int BarcodeScanner()
        {
            Sense(direction);
            if (sense != null)
                return sense.Number;
            else return 0;
        }
        /// <summary>
        /// Returns if the Robot has an Object inside
        /// </summary>
        /// <returns></returns>
        internal int Dumbbell()
        {
            return WithObject ? 1 : 0;
        }
        /// <summary>
        /// Returns the time since the Robot lives
        /// </summary>
        /// <returns></returns>
        internal int Chronometer()
        {
            return actionTime;
        }
        /// <summary>
        /// Orientation of the Robot
        /// </summary>
        /// <returns></returns>
        internal int Compass()
        {
            return direction;
        }
        /// <summary>
        /// Executes the top Routine
        /// </summary>
        public override void Execute()
        {
            RoutineStack.Peek().Execute();
        }
        public override string ToString()
        {
            if (!WithObject)
                return Size.ToString() + Color.ToString() + Shape.ToString() + Direction.ToString() + "000";
            else return Size.ToString() + Color.ToString() + Shape.ToString() + Direction.ToString() + Taken.ToString();
        }
    }
}

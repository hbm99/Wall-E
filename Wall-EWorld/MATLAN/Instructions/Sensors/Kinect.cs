using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Kinect : Instruction
    {
        public Kinect(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.Kinect());
        }
        public override string ToString()
        {
            return "shape";
        }
    }
}

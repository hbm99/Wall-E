using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Compass : Instruction
    {
        public Compass(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.Compass());
        }
        public override string ToString()
        {
            return "direction";
        }
    }
}

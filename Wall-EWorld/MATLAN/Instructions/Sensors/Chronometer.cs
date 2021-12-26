using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Chronometer : Instruction
    {
        public Chronometer(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.Chronometer());
        }
        public override string ToString()
        {
            return "time";
        }
    }
}

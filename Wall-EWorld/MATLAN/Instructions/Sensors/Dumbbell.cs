using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Dumbbell : Instruction
    {
        public Dumbbell(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.Dumbbell());
        }
        public override string ToString()
        {
            return "loaded";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class GetL : Instruction
    {
        public GetL(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['L']);
        }
        public override string ToString()
        {
            return "getL";
        }
    }
}

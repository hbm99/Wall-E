using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class GetI : Instruction
    {
        public GetI(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['I']);
        }
        public override string ToString()
        {
            return "getI";
        }
    }
}

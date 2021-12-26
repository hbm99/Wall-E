using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class GetA : Instruction
    {
        public GetA(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['A']);
        }
        public override string ToString()
        {
            return "getA";
        }
    }
}

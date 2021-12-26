using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class GetK : Instruction
    {
        public GetK(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['K']);
        }
        public override string ToString()
        {
            return "getK";
        }
    }
}

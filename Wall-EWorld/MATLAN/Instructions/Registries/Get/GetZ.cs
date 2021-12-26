using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class GetZ : Instruction
    {
        public GetZ(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['Z']);
        }
        public override string ToString()
        {
            return "getZ";
        }
    }
}

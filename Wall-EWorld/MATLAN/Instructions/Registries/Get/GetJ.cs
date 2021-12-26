using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class GetJ : Instruction
    {
        public GetJ(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['J']);
        }
        public override string ToString()
        {
            return "getJ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class GetW : Instruction
    {
        public GetW(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['W']);
        }
        public override string ToString()
        {
            return "getW";
        }
    }
}

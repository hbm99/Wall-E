using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class GetV : Instruction
    {
        public GetV(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['V']);
        }
        public override string ToString()
        {
            return "getV";
        }
    }
}

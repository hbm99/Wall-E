using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class GetQ : Instruction
    {
        public GetQ(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(currentRoutine.Registries['Q']);
        }
        public override string ToString()
        {
            return "getQ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetD : Instruction
    {
        public SetD(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['D'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setD";
        }
    }
}

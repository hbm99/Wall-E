using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetR : Instruction
    {
        public SetR(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['R'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setR";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetK : Instruction
    {
        public SetK(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['K'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setK";
        }
    }
}

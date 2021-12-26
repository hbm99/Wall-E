using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetZ : Instruction
    {
        public SetZ(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['Z'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setZ";
        }
    }
}

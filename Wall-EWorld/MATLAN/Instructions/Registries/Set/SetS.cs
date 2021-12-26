using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetS : Instruction
    {
        public SetS(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['S'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setS";
        }
    }
}

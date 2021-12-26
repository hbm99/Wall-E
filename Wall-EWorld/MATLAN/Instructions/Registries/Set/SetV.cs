using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetV : Instruction
    {
        public SetV(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['V'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setV";
        }
    }
}

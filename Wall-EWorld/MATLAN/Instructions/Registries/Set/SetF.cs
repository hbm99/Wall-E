using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetF : Instruction
    {
        public SetF(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['F'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setF";
        }
    }
}

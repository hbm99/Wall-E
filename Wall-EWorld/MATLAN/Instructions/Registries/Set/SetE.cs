using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetE : Instruction
    {
        public SetE(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['E'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setE";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetU : Instruction
    {
        public SetU(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['U'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setU";
        }
    }
}

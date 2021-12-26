using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetH : Instruction
    {
        public SetH(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['H'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setH";
        }
    }
}

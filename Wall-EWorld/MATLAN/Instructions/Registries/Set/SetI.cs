using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetI : Instruction
    {
        public SetI(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['I'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setI";
        }
    }
}

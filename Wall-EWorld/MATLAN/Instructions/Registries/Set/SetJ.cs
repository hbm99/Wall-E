using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetJ : Instruction
    {
        public SetJ(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['J'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setJ";
        }
    }
}

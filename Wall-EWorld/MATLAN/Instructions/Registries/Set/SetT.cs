using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetT : Instruction
    {
        public SetT(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['T'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setT";
        }
    }
}

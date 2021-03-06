using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetC : Instruction 
    {
        public SetC(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['C'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setC";
        }
    }
}

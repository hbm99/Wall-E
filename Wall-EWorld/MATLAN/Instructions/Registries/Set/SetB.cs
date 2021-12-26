using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetB : Instruction
    {
        public SetB(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['B'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setB";
        }
    }
}

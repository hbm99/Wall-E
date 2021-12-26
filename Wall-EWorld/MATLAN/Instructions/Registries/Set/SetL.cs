using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetL : Instruction
    {
        public SetL(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['L'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setL";
        }
    }
}

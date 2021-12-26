using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetY : Instruction
    {
        public SetY(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['Y'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setY";
        }
    }
}

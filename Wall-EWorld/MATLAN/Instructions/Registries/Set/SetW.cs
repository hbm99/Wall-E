using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetW : Instruction
    {
        public SetW(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['W'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setW";
        }
    }
}

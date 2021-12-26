using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetX : Instruction
    {
        public SetX(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['X'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setX";
        }
    }
}

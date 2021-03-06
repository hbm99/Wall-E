using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetM : Instruction
    {
        public SetM(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['M'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setM";
        }
    }
}

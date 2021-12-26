using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetN : Instruction
    {
        public SetN(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['N'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setN";
        }
    }
}

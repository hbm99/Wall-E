using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetO : Instruction
    {
        public SetO(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['O'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setO";
        }
    }
}

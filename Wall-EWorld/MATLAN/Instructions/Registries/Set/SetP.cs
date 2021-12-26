using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld 
{
    class SetP : Instruction
    {
        public SetP(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            currentRoutine.Registries['P'] = robot.RobotStack.Pop();
        }
        public override string ToString()
        {
            return "setP";
        }
    }
}

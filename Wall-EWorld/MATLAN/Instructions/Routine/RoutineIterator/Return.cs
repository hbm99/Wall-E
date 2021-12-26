using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Return : Instruction
    {
        public Return(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RoutineStack.Pop();
        }
        public override string ToString()
        {
            return "return";
        }
    }
}

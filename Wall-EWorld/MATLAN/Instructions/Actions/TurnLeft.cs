using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class TurnLeft : Instruction
    {
        public TurnLeft(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.TurnLeft();
        }
        public override string ToString()
        {
            return "left";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class MoveBackward : Instruction
    {
        public MoveBackward(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.MoveBackward();
        }
        public override string ToString()
        {
            return "backward";
        }
    }
}

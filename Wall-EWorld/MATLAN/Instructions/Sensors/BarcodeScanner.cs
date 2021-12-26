using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class BarcodeScanner : Instruction
    {
        public BarcodeScanner(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            robot.RobotStack.Push(robot.BarcodeScanner());
        }
        public override string ToString()
        {
            return "code";
        }
    }
}

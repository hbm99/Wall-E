using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Print : Instruction
    {
        public Print(Robot robot) : base(robot)
        {
        }
        public string Printer { get; set; }

        public override void Run()
        {
            Printer = robot.RobotStack.Pop().ToString();
        }
        public override string ToString()
        {
            return "console";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class Branch : Instruction
    {
        public Branch(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            if (robot.RobotStack.Count == 0 || robot.RobotStack.Peek() == 0) 
            {
                if (currentRoutine.Current.Direction == 0)
                    currentRoutine.Current.Direction = 3;
                else currentRoutine.Current.Direction--;
            }
            else
            {
                if (currentRoutine.Current.Direction == 3)
                    currentRoutine.Current.Direction = 0;
                else currentRoutine.Current.Direction++;
            }
        }
        public override string ToString()
        {
            return "branch";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    class TS : Instruction
    {
        public TS(Robot robot) : base(robot)
        {
        }

        public override void Run()
        {
            if (!currentRoutine.IsInside(currentRoutine.Current.Row + 1, currentRoutine.Current.Column - 1) || !currentRoutine.IsInside(currentRoutine.Current.Row, currentRoutine.Current.Column))
                robot.RoutineStack.Pop();
            if (currentRoutine.Current.Direction == 3 || currentRoutine.Current.Direction == 1)
            {
                currentRoutine.Current.Row++;
                currentRoutine.Current.Direction = 2;
            }
            else if (currentRoutine.Current.Direction == 0)
            {
                currentRoutine.Current.Column--;
                currentRoutine.Current.Direction = 3;
            }
            else currentRoutine.Current.Row++;
            //throw new ArgumentException("Invalid Direction");
        }
        public override string ToString()
        {
            return "TS";
        }
    }
}

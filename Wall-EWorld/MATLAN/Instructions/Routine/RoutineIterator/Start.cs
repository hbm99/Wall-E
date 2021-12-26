using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class Start : Instruction
    {
        public Start(Robot robot) : base(robot)
        {
        }

        /// <summary>
        /// Set Current in the Start Instruction
        /// </summary>
        public override void Run()
        {
            currentRoutine.Current.Direction = 2;
        }
        public override string ToString()
        {
            return "start";
        }
    }
}

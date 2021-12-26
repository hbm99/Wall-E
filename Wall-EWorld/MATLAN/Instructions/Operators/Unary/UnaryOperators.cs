using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    abstract class UnaryOperators : Operator
    {
        public override int OperandsCount { get { return 1; } }
        public UnaryOperators(Robot robot) : base(robot)
        {
        }

    }
}

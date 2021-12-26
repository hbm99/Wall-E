using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    abstract class TernaryOperator : Operator
    {
        public override int OperandsCount { get { return 3; } }
        public TernaryOperator(Robot robot) : base(robot)
        {
        }

    }
}

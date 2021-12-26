using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLanguage
{
    public abstract class Operator : Instruction
    {
        protected int[] operands;
        public Operator(int operandsCount)
        {
            operands = new int[operandsCount];
        }
        public abstract void Evaluate();
        public override void Run()
        {
            for (int i = 0; i < operands.Length; i++)
                operands[i] = robot.RobotStack.Pop();
        }
    }
}

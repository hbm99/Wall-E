using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_EWorld;

namespace MatrixLanguage
{
    public abstract class Instruction
    {
        protected MatrixLanguageMap currentRoutine;
        protected Robot robot;
        public abstract void Run();
    }
}

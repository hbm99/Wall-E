using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    /// <summary>
    /// Defines if the object is a barrier
    /// </summary>
    interface IBarrier
    {
        bool Barrier(int direction);
    }
    /// <summary>
    /// Defines if the object can be moved
    /// </summary>
    interface IMovable
    {
        bool Movable(int direction);
        void Move(int direction);
    }
    /// <summary>
    /// Defines if the object can be taken
    /// </summary>
    interface IPortable
    {
        bool Portable();
        bool CanDrop(int direction);
    }
    interface IProgramable
    {
        void Execute();
    }
}

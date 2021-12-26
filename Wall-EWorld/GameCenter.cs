using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class GameCenter
    {
        Space world;
        Random random;
        Mediator mediator;

        public GameCenter(Space world) 
        {
            this.world = world;
            Robots = world.RobotsOnSpace();
            random = new Random(DateTime.Now.Millisecond);
            mediator = new Mediator(world);
        }
        public MatrixLanguageMap CurrentRoutine { get; set; }
        public Mediator Mediator { get { return mediator; } }
        public List<Robot> Robots { get; set; }
        public Space World { get { return world; } set { world = value; } }

        /// <summary>
        /// Instruction to Instruction
        /// </summary>
        public void MiniSteps()
        {
            int nextRobot = random.Next(0, Robots.Count() - 1);

            if (Robots[nextRobot].RoutineStack.Peek().IsInstruction()) 
            {
                if (Robots[nextRobot].RoutineStack.Peek().IsAction())
                    nextRobot = random.Next(0, Robots.Count() - 1);

                if (Robots[nextRobot].RoutineStack.Peek().IsReturn() || !Robots[nextRobot].RoutineStack.Peek().Current.MoveNext())
                    Robots[nextRobot].RoutineStack.Pop();
            }
        }
        /// <summary>
        /// Action to Action
        /// </summary>
        public void NextStep()
        {
            int nextRobot = random.Next(0, Robots.Count() - 1);
            if (Robots[nextRobot].RoutineStack.Count != 0) 
                CurrentRoutine = Robots[nextRobot].CurrentRoutine;

            if (Robots[nextRobot].RoutineStack.Count != 0) 
            {
                while (true)
                {
                    if (Robots[nextRobot].RoutineStack.Peek().IsAction())
                    {
                        if (!Robots[nextRobot].RoutineStack.Peek().Current.MoveNext())
                        {
                            Robots[nextRobot].RoutineStack.Pop();
                            CurrentRoutine = null;
                        }
                        break;
                    }
                    if (Robots[nextRobot].RoutineStack.Peek().IsReturn() || !Robots[nextRobot].RoutineStack.Peek().Current.MoveNext())
                    {
                        Robots[nextRobot].RoutineStack.Pop();
                        CurrentRoutine = null;
                    }

                    if (Robots[nextRobot].RoutineStack.Count == 0)
                        break;
                }
            }
            

        }
        
        /// <summary>
        /// Plays all steps
        /// </summary>
        public void PlayAllSteps()
        {
            while (!EmptyRoutinesStacks())
                NextStep();
        }
        
        //public void RunGame()
        //{
        //    while (!EmptyRoutinesStacks())
        //    {
        //        while (indexCurrentRobot < Robots.Count) 
        //        {
        //            while (Robots[indexCurrentRobot].RoutineStack.Count != 0) 
        //            {
        //                if (!Robots[indexCurrentRobot].RoutineStack.Peek().Current.FindStart()) 
        //                    Robots[indexCurrentRobot].RoutineStack.Peek().Current.FindStart();

        //                while (Robots[indexCurrentRobot].RoutineStack.Peek().Current.MoveNext()) 
        //                {
        
        //                    if (Robots[indexCurrentRobot].RoutineStack.Peek().IsCallOrReCall())  
        //                        RunGame();
        //                    if (!Robots[indexCurrentRobot].RoutineStack.Peek().IsAction()) break;
        //                }

        //                if (!Robots[indexCurrentRobot].RoutineStack.Peek().Current.MoveNext())
        //                {
        //                    Robots[indexCurrentRobot].RoutineStack.Pop();
        //                    break;
        //                }
        //            }
        //            indexCurrentRobot++;
        //        }
        //    }
        //}

        /// <summary>
        /// All RoutineStacks are empty
        /// </summary>
        /// <returns></returns>
        private bool EmptyRoutinesStacks()
        {
            foreach (Robot item in Robots) 
                if (item.RoutineStack.Count != 0)
                    return false;
            return true;
        }
    }
}

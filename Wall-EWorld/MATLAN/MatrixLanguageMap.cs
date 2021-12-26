using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_EWorld
{
    public class MatrixLanguageCell
    {
        protected MatrixLanguageMap matrixLanguageMap;
        public MatrixLanguageCell(Instruction a)
        {
            if (a == null) Empty = true;
            else { Instruction = a; Empty = false; }
        }
        /// <summary>
        /// Defines the instruction in the place
        /// </summary>
        public Instruction Instruction { get; set; }
        
        /// <summary>
        /// Defines if the cell is empty or not
        /// </summary>
        public bool Empty { get; set; }
    }
    public class MatrixLanguageMap : ICloneable 
    {
        public int indexRoutineList;
        MatrixLanguageCell[,] matrixLanguageMap;
        protected Dictionary<char, int> registrationary;
        public MatrixLanguageMap(string name, int rows, int columns) 
        {
            matrixLanguageMap = new MatrixLanguageCell[rows, columns];
            for (int i = 0; i < matrixLanguageMap.GetLength(0); i++)
                for (int j = 0; j < matrixLanguageMap.GetLength(1); j++)
                    matrixLanguageMap[i, j] = new MatrixLanguageCell(null);

            Name = name;
            registrationary = new Dictionary<char, int>();
            Current = new Current(new Tuple<int, int>(0, 0), 0, this);
        }
        public string Name { get; set; }
        /// <summary>
        /// Current walking in matrixLanguageMap
        /// </summary>
        public Current Current { get; set; }

        /// <summary>
        /// Returns GetLength(0)
        /// </summary>
        public int RowsCount { get { return matrixLanguageMap.GetLength(0); } }

        /// <summary>
        /// Returns GetLength(1)
        /// </summary>
        public int ColumnsCount { get { return matrixLanguageMap.GetLength(1); } }

        /// <summary>
        /// Registry asociated to the Routine
        /// </summary>
        public Dictionary<char, int> Registries { get { return registrationary; } }

        /// <summary>
        /// Indexer for the MatrixLanguageMap
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public MatrixLanguageCell this[int i, int j]
        {
            get { return matrixLanguageMap[i, j]; }
            set { matrixLanguageMap[i, j] = value; }
        }

        /// <summary>
        /// Returns if [i,j] is valid
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public bool IsInside(int i, int j)
        {
            return i >= 0 && j >= 0 && i < matrixLanguageMap.GetLength(0) && j < matrixLanguageMap.GetLength(1);
        }

        /// <summary>
        /// Executes an action
        /// </summary>
        public void Execute()
        {
            matrixLanguageMap[Current.Row, Current.Column].Instruction.Run();
        }
        /// <summary>
        /// Returns if there is an Action in the place
        /// </summary>
        /// <returns></returns>
        public bool IsAction()
        {
            return matrixLanguageMap[Current.Row, Current.Column].Instruction is Drop || matrixLanguageMap[Current.Row, Current.Column].Instruction is MoveForward 
                || matrixLanguageMap[Current.Row, Current.Column].Instruction is MoveBackward || matrixLanguageMap[Current.Row, Current.Column].Instruction is TurnLeft 
                || matrixLanguageMap[Current.Row, Current.Column].Instruction is TurnRight;
        }
        /// <summary>
        /// Returns if there is an Instruction
        /// </summary>
        /// <returns></returns>
        public bool IsInstruction()
        {
            return matrixLanguageMap[Current.Row, Current.Column].Instruction is Instruction;
        }
       
        /// <summary>
        /// Returns if there is a Return in the place
        /// </summary>
        /// <returns></returns>
        public bool IsReturn()
        {
            return matrixLanguageMap[Current.Row, Current.Column].Instruction is Return;
        }
        /// <summary>
        /// Clones the MatrixLanguageMap
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            MatrixLanguageMap newRoutine = new MatrixLanguageMap(Name, RowsCount, ColumnsCount);

            for (int i = 0; i < RowsCount; i++)
                for (int j = 0; j < ColumnsCount; j++)
                    newRoutine[i, j] = matrixLanguageMap[i, j];

            return newRoutine;
        }
    }
    public class Current
    {
        MatrixLanguageMap routine;
        bool foundStart;
        public int Row { get; set; }
        public int Column { get; set; }
        public int Direction { get; set; }
        public Current(Tuple<int, int> position, int direction, MatrixLanguageMap routine) 
        {
            Row = position.Item1;
            Column = position.Item2;
            this.routine = routine;
            foundStart = false;
        }
        /// <summary>
        /// Makes the Current find the Start instruction
        /// </summary>
        /// <returns></returns>
        public void FindStart()
        {
            for (int i = 0; i < routine.RowsCount; i++)
                for (int j = 0; j < routine.ColumnsCount; j++)
                {
                    if (routine[i, j].Instruction is Start)
                    {
                        routine.Current.Row = i;
                        routine.Current.Column = j;
                        foundStart = true;
                        return;
                    }
                }
            foundStart = false;
        } 
        /// <summary>
        /// Makes the Current move next
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (!foundStart) FindStart();

            while (routine[Row, Column].Empty)
            {
                int tempRow = Row;
                int tempColumn = Column;

                switch (Direction)
                {
                    case 0:
                            Row--;
                            break;
                    case 1:
                            Column++;
                            break;
                    case 2:
                            Row++;
                            break;
                    case 3:
                            Column--;
                            break;
                }

                if (!routine.IsInside(Row, Column))
                {
                    Row = tempRow;
                    Column = tempColumn;

                    return false;
                }
            }
            if (routine.IsInside(Row, Column) && !routine[Row, Column].Empty)  
            {
                int tempRow = Row;
                int tempColumn = Column;

                routine[Row, Column].Instruction.Run();

                if (routine[tempRow, tempColumn].Instruction is Branch || routine[tempRow, tempColumn].Instruction is NE
                    || routine[tempRow, tempColumn].Instruction is NW || routine[tempRow, tempColumn].Instruction is SE
                    || routine[tempRow, tempColumn].Instruction is SW || routine[tempRow, tempColumn].Instruction is TE
                    || routine[tempRow, tempColumn].Instruction is TN || routine[tempRow, tempColumn].Instruction is TS
                    || routine[tempRow, tempColumn].Instruction is TW)
                    return true;

                switch (Direction)
                {
                    case 0:
                        {
                            if (routine.IsInside(Row - 1, Column)) 
                                Row--;
                            else
                            {
                                Row = tempRow;
                                Column = tempColumn;
                                return false;
                            }
                        }
                        break;
                    case 1:
                        {
                            if (routine.IsInside(Row, Column + 1)) 
                                Column++;
                            else
                            {
                                Row = tempRow;
                                Column = tempColumn;
                                return false;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (routine.IsInside(Row + 1, Column)) 
                                Row++;
                            else
                            {
                                Row = tempRow;
                                Column = tempColumn;
                                return false;
                            }
                        }
                        break;
                    case 3:
                        {
                            if (routine.IsInside(Row, Column - 1)) 
                                Column--;
                            else
                            {
                                Row = tempRow;
                                Column = tempColumn;
                                return false;
                            }
                        }
                        break;
                }
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wall_EWorld;

namespace MatrixLanguage
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
        internal Instruction Instruction { get; private set; }
        /// <summary>
        /// Defines if the cell is empty or not
        /// </summary>
        internal bool Empty { get; private set; }
    }
    public class MatrixLanguageMap //Routine
    {
        MatrixLanguageCell[,] matrixLanguageMap;
        protected Dictionary<char, int> registrationary;
        public MatrixLanguageMap(int rows, int columns) 
        {
            matrixLanguageMap = new MatrixLanguageCell[rows, columns];
            for (int i = 0; i < matrixLanguageMap.GetLength(0); i++)
                for (int j = 0; j < matrixLanguageMap.GetLength(1); j++)
                    matrixLanguageMap[i, j] = new MatrixLanguageCell(null);
            registrationary = new Dictionary<char, int>();
        }
        /// <summary>
        /// Current walking in matrixLanguageMap
        /// </summary>
        public Current Current { get; set; }
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
            set { this[i, j] = value; }
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
    }
    public class Current
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Direction { get; set; }
        public Current(Tuple<int, int> position, int direction)
        {
            Row = position.Item1;
            Column = position.Item2;
        }
    }
}

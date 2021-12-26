using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wall_EWorld;

namespace MyWinForm
{
    public partial class RoutineOptions : Form
    {
        Remove remove;
        MatrixLanguageMap routine;
        Size cellSize;
        Robot robot;
        SpaceCreator spaceCreator;
        RoutineCreator routineCreator;

        public Instruction Instruction { get; set; }
        public int InstructionRow { get; set; }
        public int InstructionColumn { get; set; }

        public RoutineOptions(Robot robot)
        {
            InitializeComponent();
            routineCreator = new RoutineCreator();
            spaceCreator = new SpaceCreator();
            this.robot = robot;
            remove = new Remove();
            routine = new MatrixLanguageMap(routineCreator.Name, 0, 0);
            cellSize = new Size(30, 30);
        }
        private void buttonCancelRoutine_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxRoutine_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int dim = 30;
            pictureBoxRoutine.Height = routine.RowsCount * dim + 1;
            pictureBoxRoutine.Width = routine.ColumnsCount * dim + 1;


            for (int i = 0; i < routine.RowsCount; i++)
                for (int j = 0; j < routine.ColumnsCount; j++) 
                {
                    if (routine[i, j].Empty)
                        graphics.DrawImage(Image.FromFile("resources\\000.jpg"), j * dim, i * dim, dim, dim);
                    else
                    {
                        string dir = "Instructions\\" + routine[i, j].Instruction.ToString() + ".png";
                        graphics.DrawImage(Image.FromFile(dir), j * dim, i * dim, dim, dim);
                    }
                }
        }
        private void buttonAddInstruction_Click(object sender, EventArgs e)
        {
            int row = (int)numericUpDownRow.Value;
            int column = (int)numericUpDownColumn.Value;
            string instruction = listBoxRoutineInstructions.SelectedItem.ToString();

            if (routine[row, column].Instruction != null)
                MessageBox.Show("Can't set Instruction over Instruction");
            else
                Parser.Parse(instruction, robot, row, column);

            pictureBoxRoutine.Refresh();
        }

        private void pictureBoxRoutine_MouseClick(object sender, MouseEventArgs e)
        {
            int row = e.Y / cellSize.Height;
            int column = e.X / cellSize.Width;

            InstructionRow = row;
            InstructionColumn = column;

            if (routine[row, column].Instruction != null)
            {
                remove.ShowDialog();
                if (remove.Delete) routine[row, column].Instruction = null;
            }
            pictureBoxRoutine.Refresh();
        }

        private void createNewRoutineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            routineCreator.ShowDialog();

            routine = new MatrixLanguageMap(routineCreator.Name, routineCreator.Rows, routineCreator.Columns);
            robot.RoutineStack.Push(routine);

            pictureBoxRoutine.Refresh();
        }

        private void buttonSaveRoutine_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}

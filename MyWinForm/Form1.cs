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
    public partial class Form1 : Form
    {
        SetObject setObject;
        //Space world;
        SpaceCreator spaceCreator;
        Size cellSize;
        //Mediator mediator;
        Remove remove;
        RobotOptions robotOptions;
        GameCenter gameCenter;
        bool gamePlaying;
        public Form1()
        {
            InitializeComponent();
            spaceCreator = new SpaceCreator();
            //world = new Space(10, 20);
            cellSize = new Size(30, 30);
            setObject = new SetObject();
            //mediator = new Mediator(world);
            remove = new Remove();
            gamePlaying = false;
            gameCenter = new GameCenter(new Space(10, 20));
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            int dim = 30;
            pictureBoxWorld.Height = gameCenter.World.Rows * dim + 1;
            pictureBoxWorld.Width = gameCenter.World.Columns * dim + 1;


            for (int i = 0; i < gameCenter.World.Rows; i++)
                for (int j = 0; j < gameCenter.World.Columns; j++)
                {
                    if (gameCenter.World[i, j].Object == null)
                        graphics.DrawImage(Image.FromFile("resources\\000.jpg"), j * dim, i * dim, dim, dim);
                    else
                    {
                        string dir = "resources\\" + gameCenter.World[i, j].Object.ToString() + ".jpg";
                        graphics.DrawImage(Image.FromFile(dir), j * dim, i * dim, dim, dim);
                    }
                }
        }

        private void createNewSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spaceCreator.ShowDialog();

            int rows = spaceCreator.Rows;
            int columns = spaceCreator.Columns;

            gameCenter = new GameCenter(new Space(rows, columns));

            pictureBoxWorld.Refresh();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int row = e.Y/ cellSize.Height;
            int column = e.X / cellSize.Width;

            if (gameCenter.World[row, column].Object == null)
            {
                setObject.ShowDialog();
                if (!setObject.Exit)
                {
                    if (gameCenter.World.AsociatedBarcodes.ContainsKey(setObject.Barcode))
                        MessageBox.Show("You must not duplicate Barcodes");
                    else if (!setObject.Exit)
                    {
                        if (setObject.Shape != 3)
                            gameCenter.Mediator.CreateSimpleObject(row, column, setObject.Shape + 1, setObject.ObjectSize + 1, setObject.Color + 1, setObject.Barcode);

                        else
                        {
                            gameCenter.Mediator.CreateComplexObject(row, column, 4, 3, setObject.Color + 1, setObject.Barcode, setObject.Direction);
                            gameCenter.Robots.Add(gameCenter.World[row,column].Object as Robot);
                        }
                    }
                }
            }
            else if (gameCenter.World[row,column].Object.Shape != 4) 
            {
                remove.ShowDialog();
                if (remove.Delete)
                    gameCenter.Mediator.RemoveObject(row, column);
            }
            else
            {
                robotOptions = new RobotOptions(gameCenter.World[row, column].Object as Robot);
                robotOptions.ShowDialog();
                switch (robotOptions.action)
                {
                    case Actions.Show:
                        break;
                    case Actions.Create:
                        break;
                    case Actions.Remove:
                        {
                            gameCenter.Mediator.RemoveObject(row, column);
                            gameCenter.World.RobotsOnSpace();
                        }
                            break;
                    default:
                        break;
                }
            }

            pictureBoxWorld.Refresh();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamePlaying = true;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamePlaying = false;
        }

        private void advanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameCenter.MiniSteps();
            pictureBox1.Refresh();
            pictureBoxWorld.Refresh();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gamePlaying = false;
            pictureBoxWorld.Refresh();
        }

        private void timerExecution_Tick(object sender, EventArgs e)
        {
            if (gamePlaying)
            {
                gameCenter.NextStep();

                pictureBoxWorld.Refresh();
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            if (gameCenter.CurrentRoutine == null) return;

            MatrixLanguageMap routine = gameCenter.CurrentRoutine;
            Graphics graphics = e.Graphics;
            int dim = 30;
            pictureBox1.Height = routine.RowsCount * dim + 1;
            pictureBox1.Width = routine.ColumnsCount * dim + 1;


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

        private void guideForClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-To start, you must set on a World cell an Object by pushing it\n" +
                "-Then, if it is a Complex Object, you can create a Routine by pushing it\n");
        }
    }
}

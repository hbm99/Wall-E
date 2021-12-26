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
    public enum Actions { Default, Show, Create, Remove}
    public partial class RobotOptions : Form
    {
        Remove remove;
        RoutineOptions routineVisual;
        Robot robot;

        public Actions action { get; set; }
        public RobotOptions(Robot robot) 
        {
            InitializeComponent();
            this.robot = robot;
            remove = new Remove();
            action = Actions.Default;
            routineVisual = new RoutineOptions(robot);
        }

        private void buttonRemoveRobot_Click(object sender, EventArgs e)
        {
            remove.ShowDialog();
            if (remove.Delete)
            {
                Close();
                action = Actions.Remove;
            }
        }

        private void buttonCreateRoutine_Click(object sender, EventArgs e)
        {
            routineVisual.ShowDialog();
        }

        private void RobotOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            action = Actions.Default;
        }
    }
}

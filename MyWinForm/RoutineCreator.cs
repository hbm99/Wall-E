using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForm
{
    public partial class RoutineCreator : Form
    {
        public RoutineCreator()
        {
            InitializeComponent();
        }
        public string RoutineName { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }

        private void buttonAcceptSpaceCreator_Click(object sender, EventArgs e)
        {
            RoutineName = textBox1.ToString();
            Rows = (int)numericUpDownRows.Value;
            Columns = (int)numericUpDownColumns.Value;
            Close();
        }

        private void buttonCancelSpaceCreator_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

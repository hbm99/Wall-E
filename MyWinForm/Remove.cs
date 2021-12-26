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
    public partial class Remove : Form
    {
        public bool Delete { get; set; }
        public Remove()
        {
            InitializeComponent();
            Delete = false;
        }

        private void buttonCancelRemove_Click(object sender, EventArgs e)
        {
            Delete = false;
            Close();
        }

        private void buttonAcceptRemove_Click(object sender, EventArgs e)
        {
            Delete = true;
            Close();
        }
    }
}

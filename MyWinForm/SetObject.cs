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
    public partial class SetObject : Form
    {
        bool created;
        public int Shape { get; set; }
        public int ObjectSize { get; set; }
        public int Color { get; set; }
        public int Direction { get; set; }
        public int Barcode { get; set; }
        public bool Exit { get; set; }

        public SetObject()
        {
            InitializeComponent();
            Exit = false;
        }

        private void comboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShape.SelectedIndex == 3)
            {
                comboBoxSize.Enabled = false;
                comboBoxDirection.Enabled = true;
            }
            else
            {
                comboBoxSize.Enabled = true;
                comboBoxDirection.Enabled = false;
            }
        }

        private void buttonShowPreview_Click(object sender, EventArgs e)
        {
            if (comboBoxShape.SelectedIndex == 3) 
            {
                if (comboBoxColor.SelectedItem == null || comboBoxDirection.SelectedItem == null
                    || numericUpDownBarcode.Value == 0)
                {
                    created = false;
                    MessageBox.Show("You need to complete some fields or BarCode is 0");
                }
                else
                {
                    Graphics g = pictureBoxPreview.CreateGraphics();
                    string preview = 3 + "" + (comboBoxColor.SelectedIndex + 1) + "" + 4 + "" + (comboBoxDirection.SelectedIndex) + "000";
                    string dir = "resources\\" + preview + ".jpg";
                    g.DrawImage(Image.FromFile(dir), 0, 0);
                    created = true;
                }
            }
            else
            {
                if (comboBoxColor.SelectedItem == null || comboBoxSize.SelectedItem == null
                    || numericUpDownBarcode.Value == 0)
                {
                    created = false;
                    MessageBox.Show("You need to complete some fields or BarCode is 0");
                }
                else
                {
                    Graphics g = pictureBoxPreview.CreateGraphics();
                    string preview = (comboBoxSize.SelectedIndex + 1) + "" + (comboBoxColor.SelectedIndex + 1) + "" + (comboBoxShape.SelectedIndex + 1);
                    string dir = "resources\\" + preview + ".jpg";
                    g.DrawImage(Image.FromFile(dir), 0, 0, pictureBoxPreview.Width, pictureBoxPreview.Height);
                    created = true;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (created)
                Close();

            buttonShowPreview_Click(sender, e);
            Shape = comboBoxShape.SelectedIndex;
            ObjectSize = comboBoxSize.SelectedIndex;
            Color = comboBoxColor.SelectedIndex;
            Direction = comboBoxDirection.SelectedIndex;
            Barcode = (int)numericUpDownBarcode.Value;
            Exit = false;
        }

        private void SetObject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit = true;
        }
    }
}

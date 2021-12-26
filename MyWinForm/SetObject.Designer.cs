namespace MyWinForm
{
    partial class SetObject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblShape = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonShowPreview = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.numericUpDownBarcode = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(5, 17);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(44, 13);
            this.lblShape.TabIndex = 0;
            this.lblShape.Text = "Shape :";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(12, 56);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(37, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(16, 100);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size :";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(5, 137);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(55, 13);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "Direction :";
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "ball",
            "box",
            "plant",
            "robot"});
            this.comboBoxShape.Location = new System.Drawing.Point(62, 14);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(73, 21);
            this.comboBoxShape.TabIndex = 4;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.comboBoxSize.Location = new System.Drawing.Point(62, 97);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(73, 21);
            this.comboBoxSize.TabIndex = 5;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "red",
            "yellow",
            "green",
            "blue",
            "brown",
            "black",
            "white"});
            this.comboBoxColor.Location = new System.Drawing.Point(62, 53);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(73, 21);
            this.comboBoxColor.TabIndex = 6;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Items.AddRange(new object[] {
            "north",
            "east",
            "south",
            "west"});
            this.comboBoxDirection.Location = new System.Drawing.Point(62, 134);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(73, 21);
            this.comboBoxDirection.TabIndex = 7;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxPreview.Location = new System.Drawing.Point(210, 53);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxPreview.TabIndex = 8;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonShowPreview
            // 
            this.buttonShowPreview.Location = new System.Drawing.Point(215, 12);
            this.buttonShowPreview.Name = "buttonShowPreview";
            this.buttonShowPreview.Size = new System.Drawing.Size(75, 23);
            this.buttonShowPreview.TabIndex = 9;
            this.buttonShowPreview.Text = "Show";
            this.buttonShowPreview.UseVisualStyleBackColor = true;
            this.buttonShowPreview.Click += new System.EventHandler(this.buttonShowPreview_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(215, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(7, 180);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(53, 13);
            this.lblBarcode.TabIndex = 11;
            this.lblBarcode.Text = "Barcode :";
            // 
            // numericUpDownBarcode
            // 
            this.numericUpDownBarcode.Location = new System.Drawing.Point(62, 178);
            this.numericUpDownBarcode.Name = "numericUpDownBarcode";
            this.numericUpDownBarcode.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownBarcode.TabIndex = 12;
            // 
            // SetObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 214);
            this.Controls.Add(this.numericUpDownBarcode);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonShowPreview);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblShape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetObject";
            this.Text = "Create Object";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetObject_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonShowPreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.NumericUpDown numericUpDownBarcode;
    }
}
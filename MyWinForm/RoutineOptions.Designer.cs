namespace MyWinForm
{
    partial class RoutineOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutineOptions));
            this.pictureBoxRoutine = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelRoutine = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancelRoutine = new System.Windows.Forms.Button();
            this.buttonSaveRoutine = new System.Windows.Forms.Button();
            this.labelRoutineInstruction = new System.Windows.Forms.Label();
            this.labelRoutineRow = new System.Windows.Forms.Label();
            this.labelRoutineColumn = new System.Windows.Forms.Label();
            this.listBoxRoutineInstructions = new System.Windows.Forms.ListBox();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.buttonAddInstruction = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewRoutineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoutine)).BeginInit();
            this.flowLayoutPanelRoutine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRoutine
            // 
            this.pictureBoxRoutine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxRoutine.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxRoutine.Name = "pictureBoxRoutine";
            this.pictureBoxRoutine.Size = new System.Drawing.Size(515, 353);
            this.pictureBoxRoutine.TabIndex = 0;
            this.pictureBoxRoutine.TabStop = false;
            this.pictureBoxRoutine.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxRoutine_Paint);
            this.pictureBoxRoutine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRoutine_MouseClick);
            // 
            // flowLayoutPanelRoutine
            // 
            this.flowLayoutPanelRoutine.AutoScroll = true;
            this.flowLayoutPanelRoutine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelRoutine.Controls.Add(this.pictureBoxRoutine);
            this.flowLayoutPanelRoutine.Location = new System.Drawing.Point(29, 41);
            this.flowLayoutPanelRoutine.Name = "flowLayoutPanelRoutine";
            this.flowLayoutPanelRoutine.Size = new System.Drawing.Size(518, 366);
            this.flowLayoutPanelRoutine.TabIndex = 1;
            // 
            // buttonCancelRoutine
            // 
            this.buttonCancelRoutine.BackColor = System.Drawing.Color.Red;
            this.buttonCancelRoutine.Location = new System.Drawing.Point(12, 431);
            this.buttonCancelRoutine.Name = "buttonCancelRoutine";
            this.buttonCancelRoutine.Size = new System.Drawing.Size(75, 48);
            this.buttonCancelRoutine.TabIndex = 4;
            this.buttonCancelRoutine.Text = "Cancel";
            this.buttonCancelRoutine.UseVisualStyleBackColor = false;
            this.buttonCancelRoutine.Click += new System.EventHandler(this.buttonCancelRoutine_Click);
            // 
            // buttonSaveRoutine
            // 
            this.buttonSaveRoutine.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSaveRoutine.Location = new System.Drawing.Point(693, 431);
            this.buttonSaveRoutine.Name = "buttonSaveRoutine";
            this.buttonSaveRoutine.Size = new System.Drawing.Size(75, 48);
            this.buttonSaveRoutine.TabIndex = 5;
            this.buttonSaveRoutine.Text = "Save";
            this.buttonSaveRoutine.UseVisualStyleBackColor = false;
            this.buttonSaveRoutine.Click += new System.EventHandler(this.buttonSaveRoutine_Click);
            // 
            // labelRoutineInstruction
            // 
            this.labelRoutineInstruction.AutoSize = true;
            this.labelRoutineInstruction.BackColor = System.Drawing.Color.Silver;
            this.labelRoutineInstruction.Location = new System.Drawing.Point(581, 127);
            this.labelRoutineInstruction.Name = "labelRoutineInstruction";
            this.labelRoutineInstruction.Size = new System.Drawing.Size(62, 13);
            this.labelRoutineInstruction.TabIndex = 6;
            this.labelRoutineInstruction.Text = "Instruction :";
            // 
            // labelRoutineRow
            // 
            this.labelRoutineRow.AutoSize = true;
            this.labelRoutineRow.BackColor = System.Drawing.Color.Silver;
            this.labelRoutineRow.Location = new System.Drawing.Point(608, 158);
            this.labelRoutineRow.Name = "labelRoutineRow";
            this.labelRoutineRow.Size = new System.Drawing.Size(35, 13);
            this.labelRoutineRow.TabIndex = 7;
            this.labelRoutineRow.Text = "Row :";
            // 
            // labelRoutineColumn
            // 
            this.labelRoutineColumn.AutoSize = true;
            this.labelRoutineColumn.BackColor = System.Drawing.Color.Silver;
            this.labelRoutineColumn.Location = new System.Drawing.Point(595, 189);
            this.labelRoutineColumn.Name = "labelRoutineColumn";
            this.labelRoutineColumn.Size = new System.Drawing.Size(48, 13);
            this.labelRoutineColumn.TabIndex = 8;
            this.labelRoutineColumn.Text = "Column :";
            // 
            // listBoxRoutineInstructions
            // 
            this.listBoxRoutineInstructions.FormattingEnabled = true;
            this.listBoxRoutineInstructions.Items.AddRange(new object[] {
            "add",
            "and",
            "backward",
            "branch",
            "call",
            "code",
            "color",
            "console",
            "dec",
            "direction",
            "distance",
            "div",
            "drop",
            "eq",
            "forward",
            "geq",
            "getA",
            "getAt",
            "getB",
            "getC",
            "getD",
            "getE",
            "getF",
            "getG",
            "getH",
            "getI",
            "getJ",
            "getK",
            "getL",
            "getM",
            "getN",
            "getQ",
            "getR",
            "getS",
            "getT",
            "getU",
            "getV",
            "getW",
            "getX",
            "getY",
            "getZ",
            "gt",
            "inc",
            "land",
            "left",
            "leq",
            "lnot",
            "loaded",
            "lor",
            "lt",
            "lxor",
            "mod",
            "mul",
            "NE",
            "neq",
            "not",
            "null",
            "number",
            "NW",
            "one",
            "or",
            "recCall",
            "return",
            "right",
            "routine",
            "SE",
            "setA",
            "setAt",
            "setB",
            "setC",
            "setD",
            "setE",
            "setF",
            "setG",
            "setH",
            "setI",
            "setJ",
            "setK",
            "setL",
            "setM",
            "setN",
            "setO",
            "setP",
            "setQ",
            "setR",
            "setS",
            "setT",
            "setU",
            "setV",
            "setW",
            "setX",
            "setY",
            "setZ",
            "shape",
            "start",
            "sub",
            "SW",
            "TE",
            "ternary",
            "time",
            "TN",
            "TS",
            "TW",
            "zero"});
            this.listBoxRoutineInstructions.Location = new System.Drawing.Point(652, 124);
            this.listBoxRoutineInstructions.Name = "listBoxRoutineInstructions";
            this.listBoxRoutineInstructions.Size = new System.Drawing.Size(53, 17);
            this.listBoxRoutineInstructions.TabIndex = 9;
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Location = new System.Drawing.Point(652, 156);
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRow.TabIndex = 10;
            // 
            // numericUpDownColumn
            // 
            this.numericUpDownColumn.Location = new System.Drawing.Point(652, 187);
            this.numericUpDownColumn.Name = "numericUpDownColumn";
            this.numericUpDownColumn.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownColumn.TabIndex = 11;
            // 
            // buttonAddInstruction
            // 
            this.buttonAddInstruction.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAddInstruction.Location = new System.Drawing.Point(611, 247);
            this.buttonAddInstruction.Name = "buttonAddInstruction";
            this.buttonAddInstruction.Size = new System.Drawing.Size(75, 48);
            this.buttonAddInstruction.TabIndex = 12;
            this.buttonAddInstruction.Text = "Add Instruction";
            this.buttonAddInstruction.UseVisualStyleBackColor = false;
            this.buttonAddInstruction.Click += new System.EventHandler(this.buttonAddInstruction_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewRoutineToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // createNewRoutineToolStripMenuItem
            // 
            this.createNewRoutineToolStripMenuItem.Name = "createNewRoutineToolStripMenuItem";
            this.createNewRoutineToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.createNewRoutineToolStripMenuItem.Text = "Create new Routine";
            this.createNewRoutineToolStripMenuItem.Click += new System.EventHandler(this.createNewRoutineToolStripMenuItem_Click);
            // 
            // RoutineOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 491);
            this.Controls.Add(this.buttonAddInstruction);
            this.Controls.Add(this.numericUpDownColumn);
            this.Controls.Add(this.numericUpDownRow);
            this.Controls.Add(this.listBoxRoutineInstructions);
            this.Controls.Add(this.labelRoutineColumn);
            this.Controls.Add(this.labelRoutineRow);
            this.Controls.Add(this.labelRoutineInstruction);
            this.Controls.Add(this.buttonSaveRoutine);
            this.Controls.Add(this.buttonCancelRoutine);
            this.Controls.Add(this.flowLayoutPanelRoutine);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RoutineOptions";
            this.Text = "RoutineOptions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoutine)).EndInit();
            this.flowLayoutPanelRoutine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRoutine;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRoutine;
        private System.Windows.Forms.Button buttonCancelRoutine;
        private System.Windows.Forms.Button buttonSaveRoutine;
        private System.Windows.Forms.Label labelRoutineInstruction;
        private System.Windows.Forms.Label labelRoutineRow;
        private System.Windows.Forms.Label labelRoutineColumn;
        private System.Windows.Forms.ListBox listBoxRoutineInstructions;
        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private System.Windows.Forms.NumericUpDown numericUpDownColumn;
        private System.Windows.Forms.Button buttonAddInstruction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewRoutineToolStripMenuItem;
    }
}
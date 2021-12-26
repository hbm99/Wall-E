namespace MyWinForm
{
    partial class RoutineCreator
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
            this.buttonCancelSpaceCreator = new System.Windows.Forms.Button();
            this.buttonAcceptSpaceCreator = new System.Windows.Forms.Button();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelSpaceCreator
            // 
            this.buttonCancelSpaceCreator.BackColor = System.Drawing.Color.Red;
            this.buttonCancelSpaceCreator.Location = new System.Drawing.Point(51, 176);
            this.buttonCancelSpaceCreator.Name = "buttonCancelSpaceCreator";
            this.buttonCancelSpaceCreator.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSpaceCreator.TabIndex = 11;
            this.buttonCancelSpaceCreator.Text = "Cancel";
            this.buttonCancelSpaceCreator.UseVisualStyleBackColor = false;
            this.buttonCancelSpaceCreator.Click += new System.EventHandler(this.buttonCancelSpaceCreator_Click);
            // 
            // buttonAcceptSpaceCreator
            // 
            this.buttonAcceptSpaceCreator.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAcceptSpaceCreator.Location = new System.Drawing.Point(167, 176);
            this.buttonAcceptSpaceCreator.Name = "buttonAcceptSpaceCreator";
            this.buttonAcceptSpaceCreator.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptSpaceCreator.TabIndex = 10;
            this.buttonAcceptSpaceCreator.Text = "Accept";
            this.buttonAcceptSpaceCreator.UseVisualStyleBackColor = false;
            this.buttonAcceptSpaceCreator.Click += new System.EventHandler(this.buttonAcceptSpaceCreator_Click);
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Location = new System.Drawing.Point(122, 114);
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownColumns.TabIndex = 9;
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(122, 64);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRows.TabIndex = 8;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(48, 116);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(53, 13);
            this.lblColumns.TabIndex = 7;
            this.lblColumns.Text = "Columns :";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRows.Location = new System.Drawing.Point(61, 66);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(40, 13);
            this.lblRows.TabIndex = 6;
            this.lblRows.Text = "Rows :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(52, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 13;
            // 
            // RoutineCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancelSpaceCreator);
            this.Controls.Add(this.buttonAcceptSpaceCreator);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoutineCreator";
            this.Text = "RoutineCreator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelSpaceCreator;
        private System.Windows.Forms.Button buttonAcceptSpaceCreator;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
    }
}
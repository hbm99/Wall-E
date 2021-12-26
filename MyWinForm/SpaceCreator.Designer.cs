namespace MyWinForm
{
    partial class SpaceCreator
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
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.buttonAcceptSpaceCreator = new System.Windows.Forms.Button();
            this.buttonCancelSpaceCreator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblRows.Location = new System.Drawing.Point(79, 18);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(40, 13);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows :";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(66, 58);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(53, 13);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns :";
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.Location = new System.Drawing.Point(140, 16);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.numericUpDownRows.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRows.TabIndex = 2;
            this.numericUpDownRows.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.Location = new System.Drawing.Point(140, 56);
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.numericUpDownColumns.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownColumns.TabIndex = 3;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // buttonAcceptSpaceCreator
            // 
            this.buttonAcceptSpaceCreator.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAcceptSpaceCreator.Location = new System.Drawing.Point(242, 92);
            this.buttonAcceptSpaceCreator.Name = "buttonAcceptSpaceCreator";
            this.buttonAcceptSpaceCreator.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptSpaceCreator.TabIndex = 4;
            this.buttonAcceptSpaceCreator.Text = "Accept";
            this.buttonAcceptSpaceCreator.UseVisualStyleBackColor = false;
            this.buttonAcceptSpaceCreator.Click += new System.EventHandler(this.buttonAcceptSpaceCreator_Click);
            // 
            // buttonCancelSpaceCreator
            // 
            this.buttonCancelSpaceCreator.BackColor = System.Drawing.Color.Red;
            this.buttonCancelSpaceCreator.Location = new System.Drawing.Point(12, 92);
            this.buttonCancelSpaceCreator.Name = "buttonCancelSpaceCreator";
            this.buttonCancelSpaceCreator.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSpaceCreator.TabIndex = 5;
            this.buttonCancelSpaceCreator.Text = "Cancel";
            this.buttonCancelSpaceCreator.UseVisualStyleBackColor = false;
            this.buttonCancelSpaceCreator.Click += new System.EventHandler(this.buttonCancelSpaceCreator_Click);
            // 
            // SpaceCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 127);
            this.Controls.Add(this.buttonCancelSpaceCreator);
            this.Controls.Add(this.buttonAcceptSpaceCreator);
            this.Controls.Add(this.numericUpDownColumns);
            this.Controls.Add(this.numericUpDownRows);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.lblRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SpaceCreator";
            this.Text = "SpaceCreator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.Button buttonAcceptSpaceCreator;
        private System.Windows.Forms.Button buttonCancelSpaceCreator;
    }
}
namespace MyWinForm
{
    partial class RobotOptions
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
            this.buttonRemoveRobot = new System.Windows.Forms.Button();
            this.buttonCreateRoutine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRemoveRobot
            // 
            this.buttonRemoveRobot.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveRobot.Location = new System.Drawing.Point(12, 64);
            this.buttonRemoveRobot.Name = "buttonRemoveRobot";
            this.buttonRemoveRobot.Size = new System.Drawing.Size(260, 42);
            this.buttonRemoveRobot.TabIndex = 1;
            this.buttonRemoveRobot.Text = "Remove Robot";
            this.buttonRemoveRobot.UseVisualStyleBackColor = false;
            this.buttonRemoveRobot.Click += new System.EventHandler(this.buttonRemoveRobot_Click);
            // 
            // buttonCreateRoutine
            // 
            this.buttonCreateRoutine.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateRoutine.Name = "buttonCreateRoutine";
            this.buttonCreateRoutine.Size = new System.Drawing.Size(260, 42);
            this.buttonCreateRoutine.TabIndex = 2;
            this.buttonCreateRoutine.Text = "Create Routine";
            this.buttonCreateRoutine.UseVisualStyleBackColor = true;
            this.buttonCreateRoutine.Click += new System.EventHandler(this.buttonCreateRoutine_Click);
            // 
            // RobotOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.buttonCreateRoutine);
            this.Controls.Add(this.buttonRemoveRobot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RobotOptions";
            this.Text = "RobotOptions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobotOptions_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRemoveRobot;
        private System.Windows.Forms.Button buttonCreateRoutine;
    }
}
namespace MyWinForm
{
    partial class Remove
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
            this.lblRemoveQuestion = new System.Windows.Forms.Label();
            this.buttonAcceptRemove = new System.Windows.Forms.Button();
            this.buttonCancelRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemoveQuestion
            // 
            this.lblRemoveQuestion.AutoSize = true;
            this.lblRemoveQuestion.Location = new System.Drawing.Point(44, 31);
            this.lblRemoveQuestion.Name = "lblRemoveQuestion";
            this.lblRemoveQuestion.Size = new System.Drawing.Size(186, 13);
            this.lblRemoveQuestion.TabIndex = 0;
            this.lblRemoveQuestion.Text = "Are you sure about removing this cell?";
            // 
            // buttonAcceptRemove
            // 
            this.buttonAcceptRemove.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAcceptRemove.Location = new System.Drawing.Point(155, 80);
            this.buttonAcceptRemove.Name = "buttonAcceptRemove";
            this.buttonAcceptRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptRemove.TabIndex = 1;
            this.buttonAcceptRemove.Text = "Accept";
            this.buttonAcceptRemove.UseVisualStyleBackColor = false;
            this.buttonAcceptRemove.Click += new System.EventHandler(this.buttonAcceptRemove_Click);
            // 
            // buttonCancelRemove
            // 
            this.buttonCancelRemove.BackColor = System.Drawing.Color.Red;
            this.buttonCancelRemove.Location = new System.Drawing.Point(47, 80);
            this.buttonCancelRemove.Name = "buttonCancelRemove";
            this.buttonCancelRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelRemove.TabIndex = 2;
            this.buttonCancelRemove.Text = "Cancel";
            this.buttonCancelRemove.UseVisualStyleBackColor = false;
            this.buttonCancelRemove.Click += new System.EventHandler(this.buttonCancelRemove_Click);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 132);
            this.Controls.Add(this.buttonCancelRemove);
            this.Controls.Add(this.buttonAcceptRemove);
            this.Controls.Add(this.lblRemoveQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Remove";
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemoveQuestion;
        private System.Windows.Forms.Button buttonAcceptRemove;
        private System.Windows.Forms.Button buttonCancelRemove;
    }
}
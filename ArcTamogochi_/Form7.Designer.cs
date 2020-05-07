namespace ArcTamogochi_
{
    partial class AchForm
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
            this.components = new System.ComponentModel.Container();
            this.lbAch = new System.Windows.Forms.ListBox();
            this.tAch = new System.Windows.Forms.Timer(this.components);
            this.lblClose = new System.Windows.Forms.Label();
            this.lblAchievements = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAch
            // 
            this.lbAch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbAch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAch.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAch.ForeColor = System.Drawing.Color.White;
            this.lbAch.FormattingEnabled = true;
            this.lbAch.ItemHeight = 25;
            this.lbAch.Location = new System.Drawing.Point(12, 36);
            this.lbAch.Name = "lbAch";
            this.lbAch.Size = new System.Drawing.Size(677, 275);
            this.lbAch.TabIndex = 0;
            this.lbAch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAch_MouseDown);
            this.lbAch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbAch_MouseMove);
            // 
            // tAch
            // 
            this.tAch.Enabled = true;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(663, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblAchievements
            // 
            this.lblAchievements.AutoSize = true;
            this.lblAchievements.BackColor = System.Drawing.Color.Transparent;
            this.lblAchievements.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAchievements.ForeColor = System.Drawing.Color.White;
            this.lblAchievements.Location = new System.Drawing.Point(284, 9);
            this.lblAchievements.Name = "lblAchievements";
            this.lblAchievements.Size = new System.Drawing.Size(145, 25);
            this.lblAchievements.TabIndex = 2;
            this.lblAchievements.Text = "Достижения";
            // 
            // AchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(701, 312);
            this.ControlBox = false;
            this.Controls.Add(this.lblAchievements);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lbAch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Достижения";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AchForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AchForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbAch;
        public System.Windows.Forms.Timer tAch;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblAchievements;
    }
}
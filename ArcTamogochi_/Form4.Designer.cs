namespace ArcTamogochi_
{
    partial class formCatName
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
            this.tbCatName = new System.Windows.Forms.TextBox();
            this.lblGetName = new System.Windows.Forms.Label();
            this.lblOK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCatName
            // 
            this.tbCatName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbCatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCatName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCatName.ForeColor = System.Drawing.Color.White;
            this.tbCatName.Location = new System.Drawing.Point(16, 36);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(362, 33);
            this.tbCatName.TabIndex = 0;
            this.tbCatName.TextChanged += new System.EventHandler(this.tbCatName_TextChanged);
            this.tbCatName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCatName_KeyPress);
            // 
            // lblGetName
            // 
            this.lblGetName.AutoSize = true;
            this.lblGetName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGetName.Location = new System.Drawing.Point(12, 9);
            this.lblGetName.Name = "lblGetName";
            this.lblGetName.Size = new System.Drawing.Size(377, 25);
            this.lblGetName.TabIndex = 1;
            this.lblGetName.Text = "Введите имя для вашего питомца.";
            // 
            // lblOK
            // 
            this.lblOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOK.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOK.Location = new System.Drawing.Point(146, 79);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(101, 24);
            this.lblOK.TabIndex = 2;
            this.lblOK.Text = "Принять";
            this.lblOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOK.Visible = false;
            this.lblOK.Click += new System.EventHandler(this.lblOK_Click);
            // 
            // formCatName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(390, 112);
            this.ControlBox = false;
            this.Controls.Add(this.lblOK);
            this.Controls.Add(this.lblGetName);
            this.Controls.Add(this.tbCatName);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCatName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Имя";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCatName_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCatName;
        private System.Windows.Forms.Label lblGetName;
        private System.Windows.Forms.Label lblOK;
    }
}
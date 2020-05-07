namespace ArcTamogochi_
{
    partial class formEvent
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
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEvent
            // 
            this.lblEvent.Location = new System.Drawing.Point(12, 34);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(323, 178);
            this.lblEvent.TabIndex = 0;
            this.lblEvent.Text = "lblEvent";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(309, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Location = new System.Drawing.Point(151, 217);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(43, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "ОК";
            this.btnOK.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlert.Location = new System.Drawing.Point(102, 9);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(140, 25);
            this.lblAlert.TabIndex = 3;
            this.lblAlert.Text = "Сообщение";
            // 
            // formEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(347, 251);
            this.ControlBox = false;
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblEvent);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "formEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Событие";
            this.Load += new System.EventHandler(this.formEvent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formEvent_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formEvent_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label btnOK;
        private System.Windows.Forms.Label lblAlert;
    }
}
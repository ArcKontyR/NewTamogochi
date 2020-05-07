namespace ArcTamogochi_
{
    partial class formPharmacy
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
            this.lblPharmacyName = new System.Windows.Forms.Label();
            this.lblPillGive = new System.Windows.Forms.Label();
            this.lblPill = new System.Windows.Forms.Label();
            this.lblSyringe = new System.Windows.Forms.Label();
            this.lblPillValue = new System.Windows.Forms.Label();
            this.lblPillPrice = new System.Windows.Forms.Label();
            this.lblBuyPill = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblSyringePrice = new System.Windows.Forms.Label();
            this.lblBuySyringe = new System.Windows.Forms.Label();
            this.lblSyringeValue = new System.Windows.Forms.Label();
            this.lblSyringeGive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPharmacyName
            // 
            this.lblPharmacyName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPharmacyName.Location = new System.Drawing.Point(39, 9);
            this.lblPharmacyName.Name = "lblPharmacyName";
            this.lblPharmacyName.Size = new System.Drawing.Size(121, 24);
            this.lblPharmacyName.TabIndex = 6;
            this.lblPharmacyName.Text = "Аптека";
            this.lblPharmacyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPillGive
            // 
            this.lblPillGive.AutoSize = true;
            this.lblPillGive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPillGive.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPillGive.Location = new System.Drawing.Point(12, 138);
            this.lblPillGive.Name = "lblPillGive";
            this.lblPillGive.Size = new System.Drawing.Size(64, 25);
            this.lblPillGive.TabIndex = 18;
            this.lblPillGive.Text = "Дать";
            this.lblPillGive.Click += new System.EventHandler(this.lblPillGive_Click_1);
            this.lblPillGive.MouseEnter += new System.EventHandler(this.lblPillGive_MouseEnter);
            this.lblPillGive.MouseLeave += new System.EventHandler(this.lblPillGive_MouseLeave);
            // 
            // lblPill
            // 
            this.lblPill.AutoSize = true;
            this.lblPill.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPill.Location = new System.Drawing.Point(12, 33);
            this.lblPill.Name = "lblPill";
            this.lblPill.Size = new System.Drawing.Size(84, 58);
            this.lblPill.TabIndex = 19;
            this.lblPill.Text = "💊";
            // 
            // lblSyringe
            // 
            this.lblSyringe.AutoSize = true;
            this.lblSyringe.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSyringe.Location = new System.Drawing.Point(102, 33);
            this.lblSyringe.Name = "lblSyringe";
            this.lblSyringe.Size = new System.Drawing.Size(84, 58);
            this.lblSyringe.TabIndex = 23;
            this.lblSyringe.Text = "💉";
            // 
            // lblPillValue
            // 
            this.lblPillValue.AutoSize = true;
            this.lblPillValue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPillValue.Location = new System.Drawing.Point(12, 91);
            this.lblPillValue.Name = "lblPillValue";
            this.lblPillValue.Size = new System.Drawing.Size(24, 25);
            this.lblPillValue.TabIndex = 24;
            this.lblPillValue.Text = "0";
            // 
            // lblPillPrice
            // 
            this.lblPillPrice.AutoSize = true;
            this.lblPillPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPillPrice.Location = new System.Drawing.Point(72, 67);
            this.lblPillPrice.Name = "lblPillPrice";
            this.lblPillPrice.Size = new System.Drawing.Size(24, 25);
            this.lblPillPrice.TabIndex = 29;
            this.lblPillPrice.Text = "1";
            // 
            // lblBuyPill
            // 
            this.lblBuyPill.AutoSize = true;
            this.lblBuyPill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuyPill.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuyPill.Location = new System.Drawing.Point(12, 114);
            this.lblBuyPill.Name = "lblBuyPill";
            this.lblBuyPill.Size = new System.Drawing.Size(85, 25);
            this.lblBuyPill.TabIndex = 34;
            this.lblBuyPill.Text = "Купить";
            this.lblBuyPill.Click += new System.EventHandler(this.lblBuyPill_Click_1);
            this.lblBuyPill.MouseEnter += new System.EventHandler(this.lblBuyPill_MouseEnter);
            this.lblBuyPill.MouseLeave += new System.EventHandler(this.lblBuyPill_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClose.Location = new System.Drawing.Point(51, 183);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(100, 25);
            this.lblClose.TabIndex = 43;
            this.lblClose.Text = "Закрыть";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblSyringePrice
            // 
            this.lblSyringePrice.AutoSize = true;
            this.lblSyringePrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSyringePrice.Location = new System.Drawing.Point(150, 67);
            this.lblSyringePrice.Name = "lblSyringePrice";
            this.lblSyringePrice.Size = new System.Drawing.Size(36, 25);
            this.lblSyringePrice.TabIndex = 44;
            this.lblSyringePrice.Text = "30";
            // 
            // lblBuySyringe
            // 
            this.lblBuySyringe.AutoSize = true;
            this.lblBuySyringe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuySyringe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBuySyringe.Location = new System.Drawing.Point(108, 114);
            this.lblBuySyringe.Name = "lblBuySyringe";
            this.lblBuySyringe.Size = new System.Drawing.Size(85, 25);
            this.lblBuySyringe.TabIndex = 47;
            this.lblBuySyringe.Text = "Купить";
            this.lblBuySyringe.Click += new System.EventHandler(this.lblBuySyringe_Click_1);
            this.lblBuySyringe.MouseEnter += new System.EventHandler(this.lblBuySyringe_MouseEnter);
            this.lblBuySyringe.MouseLeave += new System.EventHandler(this.lblBuySyringe_MouseLeave);
            // 
            // lblSyringeValue
            // 
            this.lblSyringeValue.AutoSize = true;
            this.lblSyringeValue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSyringeValue.Location = new System.Drawing.Point(108, 91);
            this.lblSyringeValue.Name = "lblSyringeValue";
            this.lblSyringeValue.Size = new System.Drawing.Size(24, 25);
            this.lblSyringeValue.TabIndex = 46;
            this.lblSyringeValue.Text = "0";
            // 
            // lblSyringeGive
            // 
            this.lblSyringeGive.AutoSize = true;
            this.lblSyringeGive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSyringeGive.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSyringeGive.Location = new System.Drawing.Point(108, 138);
            this.lblSyringeGive.Name = "lblSyringeGive";
            this.lblSyringeGive.Size = new System.Drawing.Size(64, 25);
            this.lblSyringeGive.TabIndex = 45;
            this.lblSyringeGive.Text = "Дать";
            this.lblSyringeGive.Click += new System.EventHandler(this.lblSyringeGive_Click_1);
            this.lblSyringeGive.MouseEnter += new System.EventHandler(this.lblSyringeGive_MouseEnter);
            this.lblSyringeGive.MouseLeave += new System.EventHandler(this.lblSyringeGive_MouseLeave);
            // 
            // formPharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(198, 217);
            this.ControlBox = false;
            this.Controls.Add(this.lblBuySyringe);
            this.Controls.Add(this.lblSyringeValue);
            this.Controls.Add(this.lblSyringeGive);
            this.Controls.Add(this.lblSyringePrice);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblBuyPill);
            this.Controls.Add(this.lblPillPrice);
            this.Controls.Add(this.lblPillValue);
            this.Controls.Add(this.lblSyringe);
            this.Controls.Add(this.lblPill);
            this.Controls.Add(this.lblPillGive);
            this.Controls.Add(this.lblPharmacyName);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formPharmacy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formPharmacy_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formPharmacy_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPharmacyName;
        public System.Windows.Forms.Label lblPillGive;
        public System.Windows.Forms.Label lblPill;
        public System.Windows.Forms.Label lblSyringe;
        public System.Windows.Forms.Label lblPillValue;
        public System.Windows.Forms.Label lblPillPrice;
        public System.Windows.Forms.Label lblBuyPill;
        public System.Windows.Forms.Label lblClose;
        public System.Windows.Forms.Label lblSyringePrice;
        public System.Windows.Forms.Label lblBuySyringe;
        public System.Windows.Forms.Label lblSyringeValue;
        public System.Windows.Forms.Label lblSyringeGive;
    }
}
namespace ArcTamogochi_
{
    partial class formMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.prbMood = new System.Windows.Forms.ProgressBar();
            this.lblMood = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.prbHealth = new System.Windows.Forms.ProgressBar();
            this.tMood = new System.Windows.Forms.Timer(this.components);
            this.lblHealthValue = new System.Windows.Forms.Label();
            this.lblMoodValue = new System.Windows.Forms.Label();
            this.frameUp = new System.Windows.Forms.Timer(this.components);
            this.lblSatietyValue = new System.Windows.Forms.Label();
            this.lblSatiety = new System.Windows.Forms.Label();
            this.prbSatiety = new System.Windows.Forms.ProgressBar();
            this.tSatiety = new System.Windows.Forms.Timer(this.components);
            this.tHealth = new System.Windows.Forms.Timer(this.components);
            this.tAutoSaveTrue = new System.Windows.Forms.Timer(this.components);
            this.btnShop = new System.Windows.Forms.Label();
            this.btnFeed = new System.Windows.Forms.Label();
            this.btnWork = new System.Windows.Forms.Label();
            this.lblTirednessValue = new System.Windows.Forms.Label();
            this.lblTiredness = new System.Windows.Forms.Label();
            this.prbTiredness = new System.Windows.Forms.ProgressBar();
            this.tTirednessDown = new System.Windows.Forms.Timer(this.components);
            this.tTirednessUp = new System.Windows.Forms.Timer(this.components);
            this.btnPharmacy = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Label();
            this.lblThirstValue = new System.Windows.Forms.Label();
            this.lblThirst = new System.Windows.Forms.Label();
            this.prbThirst = new System.Windows.Forms.ProgressBar();
            this.tThirst = new System.Windows.Forms.Timer(this.components);
            this.lblSaved = new System.Windows.Forms.Label();
            this.tAutoSaveFalse = new System.Windows.Forms.Timer(this.components);
            this.lblCatName = new System.Windows.Forms.Label();
            this.pbPet = new System.Windows.Forms.PictureBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblAchStats = new System.Windows.Forms.Label();
            this.btnAchievements = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Label();
            this.tEvent = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
            this.SuspendLayout();
            // 
            // prbMood
            // 
            this.prbMood.Location = new System.Drawing.Point(343, 285);
            this.prbMood.Name = "prbMood";
            this.prbMood.Size = new System.Drawing.Size(143, 25);
            this.prbMood.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbMood.TabIndex = 1;
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.BackColor = System.Drawing.Color.Transparent;
            this.lblMood.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMood.ForeColor = System.Drawing.Color.White;
            this.lblMood.Location = new System.Drawing.Point(492, 285);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(143, 25);
            this.lblMood.TabIndex = 2;
            this.lblMood.Text = "Настроение";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(492, 316);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(112, 25);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "Здоровье";
            // 
            // prbHealth
            // 
            this.prbHealth.Location = new System.Drawing.Point(343, 316);
            this.prbHealth.Name = "prbHealth";
            this.prbHealth.Size = new System.Drawing.Size(143, 25);
            this.prbHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbHealth.TabIndex = 3;
            // 
            // tMood
            // 
            this.tMood.Interval = 5000;
            this.tMood.Tick += new System.EventHandler(this.tMood_Tick);
            // 
            // lblHealthValue
            // 
            this.lblHealthValue.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthValue.ForeColor = System.Drawing.Color.White;
            this.lblHealthValue.Location = new System.Drawing.Point(391, 316);
            this.lblHealthValue.Name = "lblHealthValue";
            this.lblHealthValue.Size = new System.Drawing.Size(50, 25);
            this.lblHealthValue.TabIndex = 6;
            this.lblHealthValue.Text = "0";
            this.lblHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoodValue
            // 
            this.lblMoodValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMoodValue.ForeColor = System.Drawing.Color.White;
            this.lblMoodValue.Location = new System.Drawing.Point(391, 285);
            this.lblMoodValue.Name = "lblMoodValue";
            this.lblMoodValue.Size = new System.Drawing.Size(50, 25);
            this.lblMoodValue.TabIndex = 7;
            this.lblMoodValue.Text = "0";
            this.lblMoodValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frameUp
            // 
            this.frameUp.Interval = 1;
            this.frameUp.Tick += new System.EventHandler(this.frameUp_Tick);
            // 
            // lblSatietyValue
            // 
            this.lblSatietyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblSatietyValue.ForeColor = System.Drawing.Color.White;
            this.lblSatietyValue.Location = new System.Drawing.Point(391, 254);
            this.lblSatietyValue.Name = "lblSatietyValue";
            this.lblSatietyValue.Size = new System.Drawing.Size(50, 25);
            this.lblSatietyValue.TabIndex = 10;
            this.lblSatietyValue.Text = "0";
            this.lblSatietyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSatiety
            // 
            this.lblSatiety.AutoSize = true;
            this.lblSatiety.BackColor = System.Drawing.Color.Transparent;
            this.lblSatiety.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSatiety.ForeColor = System.Drawing.Color.White;
            this.lblSatiety.Location = new System.Drawing.Point(492, 254);
            this.lblSatiety.Name = "lblSatiety";
            this.lblSatiety.Size = new System.Drawing.Size(103, 25);
            this.lblSatiety.TabIndex = 9;
            this.lblSatiety.Text = "Сытость";
            // 
            // prbSatiety
            // 
            this.prbSatiety.Location = new System.Drawing.Point(343, 254);
            this.prbSatiety.Name = "prbSatiety";
            this.prbSatiety.Size = new System.Drawing.Size(143, 25);
            this.prbSatiety.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbSatiety.TabIndex = 8;
            // 
            // tSatiety
            // 
            this.tSatiety.Interval = 10000;
            this.tSatiety.Tick += new System.EventHandler(this.tSatiety_Tick);
            // 
            // tHealth
            // 
            this.tHealth.Interval = 15000;
            this.tHealth.Tick += new System.EventHandler(this.tHealth_Tick);
            // 
            // tAutoSaveTrue
            // 
            this.tAutoSaveTrue.Enabled = true;
            this.tAutoSaveTrue.Interval = 60000;
            this.tAutoSaveTrue.Tick += new System.EventHandler(this.tAutoSave_Tick);
            // 
            // btnShop
            // 
            this.btnShop.AutoSize = true;
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(263, 40);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(102, 25);
            this.btnShop.TabIndex = 12;
            this.btnShop.Text = "Магазин";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            this.btnShop.MouseEnter += new System.EventHandler(this.btnShop_MouseEnter);
            this.btnShop.MouseLeave += new System.EventHandler(this.btnShop_MouseLeave);
            // 
            // btnFeed
            // 
            this.btnFeed.AutoSize = true;
            this.btnFeed.BackColor = System.Drawing.Color.Transparent;
            this.btnFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeed.ForeColor = System.Drawing.Color.White;
            this.btnFeed.Location = new System.Drawing.Point(263, 65);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(128, 25);
            this.btnFeed.TabIndex = 13;
            this.btnFeed.Text = "Покормить";
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            this.btnFeed.MouseEnter += new System.EventHandler(this.btnFeed_MouseEnter);
            this.btnFeed.MouseLeave += new System.EventHandler(this.btnFeed_MouseLeave);
            // 
            // btnWork
            // 
            this.btnWork.AutoSize = true;
            this.btnWork.BackColor = System.Drawing.Color.Transparent;
            this.btnWork.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWork.ForeColor = System.Drawing.Color.White;
            this.btnWork.Location = new System.Drawing.Point(155, 90);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(193, 25);
            this.btnWork.TabIndex = 14;
            this.btnWork.Text = "Пойти на работу";
            this.btnWork.Click += new System.EventHandler(this.lblWork_Click);
            this.btnWork.MouseEnter += new System.EventHandler(this.btnWork_MouseEnter);
            this.btnWork.MouseLeave += new System.EventHandler(this.btnWork_MouseLeave);
            // 
            // lblTirednessValue
            // 
            this.lblTirednessValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTirednessValue.ForeColor = System.Drawing.Color.White;
            this.lblTirednessValue.Location = new System.Drawing.Point(391, 191);
            this.lblTirednessValue.Name = "lblTirednessValue";
            this.lblTirednessValue.Size = new System.Drawing.Size(50, 25);
            this.lblTirednessValue.TabIndex = 18;
            this.lblTirednessValue.Text = "0";
            this.lblTirednessValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiredness
            // 
            this.lblTiredness.AutoSize = true;
            this.lblTiredness.BackColor = System.Drawing.Color.Transparent;
            this.lblTiredness.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTiredness.ForeColor = System.Drawing.Color.White;
            this.lblTiredness.Location = new System.Drawing.Point(492, 188);
            this.lblTiredness.Name = "lblTiredness";
            this.lblTiredness.Size = new System.Drawing.Size(122, 25);
            this.lblTiredness.TabIndex = 17;
            this.lblTiredness.Text = "Усталость";
            // 
            // prbTiredness
            // 
            this.prbTiredness.Location = new System.Drawing.Point(343, 191);
            this.prbTiredness.Name = "prbTiredness";
            this.prbTiredness.Size = new System.Drawing.Size(143, 25);
            this.prbTiredness.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbTiredness.TabIndex = 16;
            // 
            // tTirednessDown
            // 
            this.tTirednessDown.Interval = 2500;
            this.tTirednessDown.Tick += new System.EventHandler(this.tTirednessDown_Tick);
            // 
            // tTirednessUp
            // 
            this.tTirednessUp.Interval = 10000;
            this.tTirednessUp.Tick += new System.EventHandler(this.tTirednessUp_Tick);
            // 
            // btnPharmacy
            // 
            this.btnPharmacy.AutoSize = true;
            this.btnPharmacy.BackColor = System.Drawing.Color.Transparent;
            this.btnPharmacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPharmacy.ForeColor = System.Drawing.Color.White;
            this.btnPharmacy.Location = new System.Drawing.Point(120, 40);
            this.btnPharmacy.Name = "btnPharmacy";
            this.btnPharmacy.Size = new System.Drawing.Size(90, 25);
            this.btnPharmacy.TabIndex = 19;
            this.btnPharmacy.Text = "Аптека";
            this.btnPharmacy.Click += new System.EventHandler(this.lblPharmacy_Click);
            this.btnPharmacy.MouseEnter += new System.EventHandler(this.btnPharmacy_MouseEnter);
            this.btnPharmacy.MouseLeave += new System.EventHandler(this.btnPharmacy_MouseLeave);
            // 
            // btnHeal
            // 
            this.btnHeal.AutoSize = true;
            this.btnHeal.BackColor = System.Drawing.Color.Transparent;
            this.btnHeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeal.ForeColor = System.Drawing.Color.White;
            this.btnHeal.Location = new System.Drawing.Point(120, 65);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(124, 25);
            this.btnHeal.TabIndex = 20;
            this.btnHeal.Text = "Подлечить";
            this.btnHeal.Click += new System.EventHandler(this.lblHeal_Click);
            this.btnHeal.MouseEnter += new System.EventHandler(this.btnHeal_MouseEnter);
            this.btnHeal.MouseLeave += new System.EventHandler(this.btnHeal_MouseLeave);
            // 
            // lblThirstValue
            // 
            this.lblThirstValue.BackColor = System.Drawing.Color.Transparent;
            this.lblThirstValue.ForeColor = System.Drawing.Color.White;
            this.lblThirstValue.Location = new System.Drawing.Point(391, 222);
            this.lblThirstValue.Name = "lblThirstValue";
            this.lblThirstValue.Size = new System.Drawing.Size(50, 25);
            this.lblThirstValue.TabIndex = 24;
            this.lblThirstValue.Text = "0";
            this.lblThirstValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThirst
            // 
            this.lblThirst.AutoSize = true;
            this.lblThirst.BackColor = System.Drawing.Color.Transparent;
            this.lblThirst.ForeColor = System.Drawing.Color.White;
            this.lblThirst.Location = new System.Drawing.Point(492, 222);
            this.lblThirst.Name = "lblThirst";
            this.lblThirst.Size = new System.Drawing.Size(91, 25);
            this.lblThirst.TabIndex = 23;
            this.lblThirst.Text = "Жажда";
            // 
            // prbThirst
            // 
            this.prbThirst.Location = new System.Drawing.Point(343, 222);
            this.prbThirst.Name = "prbThirst";
            this.prbThirst.Size = new System.Drawing.Size(143, 25);
            this.prbThirst.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbThirst.TabIndex = 22;
            // 
            // tThirst
            // 
            this.tThirst.Interval = 7500;
            this.tThirst.Tick += new System.EventHandler(this.tThirst_Tick);
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.BackColor = System.Drawing.Color.Transparent;
            this.lblSaved.Location = new System.Drawing.Point(498, 352);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(133, 25);
            this.lblSaved.TabIndex = 25;
            this.lblSaved.Text = "Сохранено";
            this.lblSaved.Visible = false;
            // 
            // tAutoSaveFalse
            // 
            this.tAutoSaveFalse.Interval = 1500;
            this.tAutoSaveFalse.Tick += new System.EventHandler(this.tAutoSaveFalse_Tick);
            // 
            // lblCatName
            // 
            this.lblCatName.BackColor = System.Drawing.Color.Transparent;
            this.lblCatName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCatName.Location = new System.Drawing.Point(94, 124);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(240, 25);
            this.lblCatName.TabIndex = 11;
            this.lblCatName.Text = "Имя";
            this.lblCatName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPet
            // 
            this.pbPet.BackColor = System.Drawing.Color.Transparent;
            this.pbPet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPet.BackgroundImage")));
            this.pbPet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPet.Location = new System.Drawing.Point(99, 152);
            this.pbPet.Name = "pbPet";
            this.pbPet.Size = new System.Drawing.Size(240, 243);
            this.pbPet.TabIndex = 26;
            this.pbPet.TabStop = false;
            this.pbPet.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoney.Location = new System.Drawing.Point(0, 343);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(109, 25);
            this.lblMoney.TabIndex = 27;
            this.lblMoney.Text = "Монеты :";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(620, -1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(26, 25);
            this.lblClose.TabIndex = 29;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // lblAchStats
            // 
            this.lblAchStats.AutoSize = true;
            this.lblAchStats.BackColor = System.Drawing.Color.Transparent;
            this.lblAchStats.Enabled = false;
            this.lblAchStats.Location = new System.Drawing.Point(0, -1);
            this.lblAchStats.Name = "lblAchStats";
            this.lblAchStats.Size = new System.Drawing.Size(25, 25);
            this.lblAchStats.TabIndex = 22;
            this.lblAchStats.Text = "+";
            this.lblAchStats.Visible = false;
            this.lblAchStats.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAchievements
            // 
            this.btnAchievements.AutoSize = true;
            this.btnAchievements.BackColor = System.Drawing.Color.Transparent;
            this.btnAchievements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAchievements.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAchievements.ForeColor = System.Drawing.Color.White;
            this.btnAchievements.Location = new System.Drawing.Point(0, 318);
            this.btnAchievements.Name = "btnAchievements";
            this.btnAchievements.Size = new System.Drawing.Size(145, 25);
            this.btnAchievements.TabIndex = 33;
            this.btnAchievements.Text = "Достижения";
            this.btnAchievements.Click += new System.EventHandler(this.btnAchievements_Click);
            this.btnAchievements.MouseEnter += new System.EventHandler(this.btnAchievements_MouseEnter);
            this.btnAchievements.MouseLeave += new System.EventHandler(this.btnAchievements_MouseLeave);
            // 
            // btnStats
            // 
            this.btnStats.AutoSize = true;
            this.btnStats.BackColor = System.Drawing.Color.Transparent;
            this.btnStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStats.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(0, 296);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(139, 25);
            this.btnStats.TabIndex = 34;
            this.btnStats.Text = "Статистика";
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            this.btnStats.MouseEnter += new System.EventHandler(this.btnStats_MouseEnter);
            this.btnStats.MouseLeave += new System.EventHandler(this.btnStats_MouseLeave);
            // 
            // tEvent
            // 
            this.tEvent.Interval = 60000;
            this.tEvent.Tick += new System.EventHandler(this.tEvent_Tick);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 386);
            this.Controls.Add(this.lblAchStats);
            this.Controls.Add(this.btnAchievements);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.pbPet);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.lblThirstValue);
            this.Controls.Add(this.lblThirst);
            this.Controls.Add(this.prbThirst);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnPharmacy);
            this.Controls.Add(this.lblTirednessValue);
            this.Controls.Add(this.lblTiredness);
            this.Controls.Add(this.prbTiredness);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblSatietyValue);
            this.Controls.Add(this.lblSatiety);
            this.Controls.Add(this.prbSatiety);
            this.Controls.Add(this.lblMoodValue);
            this.Controls.Add(this.lblHealthValue);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.prbHealth);
            this.Controls.Add(this.lblMood);
            this.Controls.Add(this.prbMood);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Твой кот";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMain_FormClosed);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ProgressBar prbMood;
        public System.Windows.Forms.Label lblMood;
        public System.Windows.Forms.Label lblHealth;
        public System.Windows.Forms.ProgressBar prbHealth;
        public System.Windows.Forms.Timer tMood;
        public System.Windows.Forms.Label lblHealthValue;
        public System.Windows.Forms.Label lblMoodValue;
        public System.Windows.Forms.Timer frameUp;
        public System.Windows.Forms.Label lblSatietyValue;
        public System.Windows.Forms.Label lblSatiety;
        public System.Windows.Forms.ProgressBar prbSatiety;
        public System.Windows.Forms.Timer tSatiety;
        public System.Windows.Forms.Timer tHealth;
        public System.Windows.Forms.Timer tAutoSaveTrue;
        public System.Windows.Forms.Label btnShop;
        public System.Windows.Forms.Label btnFeed;
        public System.Windows.Forms.Label btnWork;
        public System.Windows.Forms.Label lblTirednessValue;
        public System.Windows.Forms.Label lblTiredness;
        public System.Windows.Forms.ProgressBar prbTiredness;
        private System.Windows.Forms.Timer tTirednessDown;
        private System.Windows.Forms.Timer tTirednessUp;
        public System.Windows.Forms.Label btnPharmacy;
        public System.Windows.Forms.Label btnHeal;
        public System.Windows.Forms.Label lblThirstValue;
        public System.Windows.Forms.Label lblThirst;
        public System.Windows.Forms.ProgressBar prbThirst;
        public System.Windows.Forms.Timer tThirst;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Timer tAutoSaveFalse;
        public System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.PictureBox pbPet;
        public System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblAchStats;
        private System.Windows.Forms.Label btnAchievements;
        private System.Windows.Forms.Label btnStats;
        private System.Windows.Forms.Timer tEvent;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ArcTamogochi_
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

        }
         //for git test
        Point lastPointGame;
        public byte workTimeWashingFloors;
        public byte workTimeGluePaper;
        public byte workTimeCarryFood;
        public byte workTimeCashier;
        public byte workTimeCarwash;
        public byte workTimeFactory;
        public byte workTimeSite;
        public byte workTimeGame;
        public byte workTimeStream;
        public byte workTimeBook;
        public byte satiety = 70;
        public byte mood = 70;
        public byte health = 100;
        public byte tiredness = 20;
        public byte thirst = 50;
        public bool tirednessUp = true;
        public byte MelonValue;
        public byte GrapeValue;
        public byte CornValue;
        public byte DonutValue;
        public byte ChickenValue;
        public byte MilkValue;
        public byte PillValue;
        public byte SyringeValue;
        public bool havePet = true;
        byte[] products = new byte[6];
        byte[] medicine = new byte[2];
        public string petName = "";
        const byte n = 40;// кол-во характеристик
        string[] data = new string[n];
        Random rnd = new Random();
        public int Money;
        public byte catDies;
        public int allMoney;
        public int allMelons;
        public int allGrapes;
        public int allCorns;
        public int allDonuts;
        public int allChickens;
        public int allMilk;
        public int allPills;
        public int allSyringe;

        public void timerBackup()
        {
            tMood.Enabled = true;
            tHealth.Enabled = false;
            tSatiety.Enabled = true;
            tThirst.Enabled = true;
            tTirednessDown.Enabled = false;
            tTirednessUp.Enabled = true;
            frameUp.Enabled = true;
            tAutoSaveTrue.Enabled = true;
            tEvent.Enabled = true;
        }

        public void timerOff()
        {
            tMood.Enabled = false;
            tHealth.Enabled = false;
            tSatiety.Enabled = false;
            tThirst.Enabled = false;
            tTirednessDown.Enabled = false;
            tTirednessUp.Enabled = false;
            frameUp.Enabled = true;
            tirednessUp = false;
            tEvent.Enabled = false;
        }

        public void petSpawn()
        {
        
            btnPharmacy.Location = new Point(120, 40);
            btnShop.Location = new Point(263, 40);
            btnWork.Location = new Point(155, 90);
            satiety = 70;
            mood = 70;
            health = 100;
            tiredness = 20;
            thirst = 50;
            formCatName CatName = new formCatName();
            CatName.Owner = this;
            CatName.ShowDialog();
            Width = 643;
            Height = 386;
            timerBackup();
            havePet = true;
            pbPet.Visible = true;
            lblCatName.Visible = true;
            lblHealth.Visible = true;
            lblHealthValue.Visible = true;
            prbHealth.Visible = true;
            lblMood.Visible = true;
            lblMoodValue.Visible = true;
            prbMood.Visible = true;
            lblSatiety.Visible = true;
            lblSatietyValue.Visible = true;
            prbSatiety.Visible = true;
            lblThirst.Visible = true;
            lblThirstValue.Visible = true;
            prbThirst.Visible = true;
            lblTiredness.Visible = true;
            lblTirednessValue.Visible = true;
            prbTiredness.Visible = true;
            btnFeed.Visible = true;
            btnHeal.Visible = true;

        }

        public void frameUpdate()
        {
            lblHealthValue.Text = health.ToString();
            prbHealth.Value = health;
            lblMoodValue.Text = mood.ToString();
            prbMood.Value = mood;
            lblSatietyValue.Text = satiety.ToString();
            prbSatiety.Value = satiety;
            lblThirstValue.Text = thirst.ToString();
            prbThirst.Value = thirst;
            lblTirednessValue.Text = tiredness.ToString();
            prbTiredness.Value = tiredness;
            lblCatName.Text = petName;
            if (Money <= 99999)
            {
                lblMoney.Text = $"Монеты: {Money}";
            }
            else
            {
                lblMoney.Text = "Монеты: 99999";
            }
            if (havePet == true)
            {
                if (mood == 0)
                {
                    tMood.Enabled = false;
                }
                else
                {
                    tMood.Enabled = true;
                }
                if (thirst == 0)
                {
                    tThirst.Enabled = false;
                    tTirednessUp.Interval  = 5000;
                }
                else
                {
                    tThirst.Enabled = true;
                    tTirednessUp.Interval = 10000;
                }
                if (tiredness == 100)
                {
                    tirednessUp = false;
                }
                else if (tiredness == 0)
                {
                    tirednessUp = true;
                }
                if (tirednessUp == false)
                {
                    tMood.Enabled = false;
                    tHealth.Enabled = false;
                    tSatiety.Enabled = false;
                    tThirst.Enabled = false;
                    tTirednessDown.Enabled = true;
                    tTirednessUp.Enabled = false;
                    
                }
                else
                {
                    tMood.Enabled = true;
                    tHealth.Enabled = true;
                    tSatiety.Enabled = true;
                    tThirst.Enabled = true;
                    tTirednessDown.Enabled = false;
                    tTirednessUp.Enabled = true;
                }
                if (satiety == 0)
                {
                    tSatiety.Enabled = false;
                    tHealth.Enabled = true;
                }
                else
                {
                    tSatiety.Enabled = true;
                    tHealth.Enabled = false;
                }
                if (health == 0)
                {
                    catDies++;
                    timerOff();
                    frameUp.Enabled = false;
                    DialogResult diagResult = MessageBox.Show("Ваш питомец умер. Вы купите нового?", "Это не конец.", MessageBoxButtons.YesNo);
                    if (diagResult == DialogResult.Yes && Money >= 500)
                    {
                        Money -= 500;
                        petSpawn();
                    }
                    else
                    {
                        if (diagResult != DialogResult.No)
                        {
                            MessageBox.Show("Недостаточно монет", "Это не конец.", MessageBoxButtons.OK);
                        }
                        havePet = false;
                        timerOff();
                        health = 1;
                        Width = 643;
                        Height = 386;
                        lblCatName.Visible = false;
                        lblHealth.Visible = false;
                        lblHealthValue.Visible = false;
                        prbHealth.Visible = false;
                        lblMood.Visible = false;
                        lblMoodValue.Visible = false;
                        prbMood.Visible = false;
                        lblSatiety.Visible = false;
                        lblSatietyValue.Visible = false;
                        prbSatiety.Visible = false;
                        lblThirst.Visible = false;
                        lblThirstValue.Visible = false;
                        prbThirst.Visible = false;
                        lblTiredness.Visible = false;
                        lblTirednessValue.Visible = false;
                        prbTiredness.Visible = false;
                        btnFeed.Visible = false;
                        btnHeal.Visible = false;
                    }
                }
            }
            if (havePet == false)
            {
                btnPharmacy.Location = new Point(315,215);
                btnShop.Location = new Point(475, 215);
                btnWork.Location = new Point(350, 250);
                timerOff();  
                Width = 643;
                Height = 386;
                lblCatName.Visible = false;
                lblHealth.Visible = false;
                lblHealthValue.Visible = false;
                prbHealth.Visible = false;
                lblMood.Visible = false;
                lblMoodValue.Visible = false;
                prbMood.Visible = false;
                lblSatiety.Visible = false;
                lblSatietyValue.Visible = false;
                prbSatiety.Visible = false;
                lblThirst.Visible = false;
                lblThirstValue.Visible = false;
                prbThirst.Visible = false;
                lblTiredness.Visible = false;
                lblTirednessValue.Visible = false;
                prbTiredness.Visible = false;
                btnFeed.Visible = false;
                btnHeal.Visible = false;
                pbPet.Visible = false;
            }
            
        }

        public void dataStack()
        {
            data[0] = petName; // имя питомца
            data[1] = mood.ToString(); // показатель настроения
            data[2] = health.ToString(); // показатель здоровья
            data[3] = satiety.ToString(); // показатель сытости
            data[4] = tiredness.ToString(); // показатель усталости
            data[5] = tirednessUp.ToString(); 
            data[6] = Money.ToString(); // рублики
            data[7] = MelonValue.ToString(); // Арбуз
            data[8] = GrapeValue.ToString(); // Виноград
            data[9] = CornValue.ToString(); // Кукуруза
            data[10] = DonutValue.ToString(); // Пончик
            data[11] = ChickenValue.ToString(); // Кур очка
            data[12] = PillValue.ToString(); // Таблетка
            data[13] = SyringeValue.ToString(); // Шприц
            data[14] = workTimeGluePaper.ToString(); // отработано расклейщиком листовок
            data[15] = workTimeWashingFloors.ToString(); // отработано мойщиком полов
            data[16] = workTimeCarryFood.ToString(); // отработано разносчиком еды
            data[17] = workTimeCashier.ToString(); // отработано продавцом
            data[18] = workTimeCarwash.ToString(); // отработано на автомойке
            data[19] = workTimeFactory.ToString(); // отработано на заводе
            data[20] = workTimeSite.ToString(); // сделано сайтов
            data[21] = workTimeGame.ToString(); // сделано игр
            data[22] = workTimeStream.ToString(); // проведено стримов
            data[23] = workTimeBook.ToString(); // написано книг
            data[24] = thirst.ToString(); // показатель жажды
            data[25] = MilkValue.ToString(); // Молоко
            data[26] = havePet.ToString(); // есть ли питомец
            data[27] = catDies.ToString(); // Смерти кота
            data[28] = allMoney.ToString(); // всего монет
            data[29] = allMelons.ToString(); // всего арбузов
            data[30] = allGrapes.ToString(); // всего винограда
            data[31] = allCorns.ToString(); // всего кукурузы
            data[32] = allDonuts.ToString(); // всего пончиков
            data[33] = allChickens.ToString(); // всего кур очек
            data[34] = allMilk.ToString(); // всего молока
            data[35] = allPills.ToString(); // всего таблеток
            data[36] = allSyringe.ToString(); // всего шприцов
        }   
        public void saveProgress()
        {
            dataStack();
            File.WriteAllLines("Progress.ati", data);
        }

        public void loadProgress(string name)
        {
            string[] loadedData = File.ReadAllLines(name);
            petName = loadedData[0];
            mood = Convert.ToByte(loadedData[1]);
            health = Convert.ToByte(loadedData[2]);
            satiety = Convert.ToByte(loadedData[3]);
            tiredness = Convert.ToByte(loadedData[4]);
            tirednessUp = bool.Parse(loadedData[5]);
            Money = Convert.ToInt32(loadedData[6]);
            MelonValue = Convert.ToByte(loadedData[7]);
            GrapeValue = Convert.ToByte(loadedData[8]);
            CornValue = Convert.ToByte(loadedData[9]);
            DonutValue = Convert.ToByte(loadedData[10]);
            ChickenValue = Convert.ToByte(loadedData[11]);
            PillValue = Convert.ToByte(loadedData[12]);
            SyringeValue = Convert.ToByte(loadedData[13]);
            workTimeGluePaper = Convert.ToByte(loadedData[14]);
            workTimeWashingFloors = Convert.ToByte(loadedData[15]);
            workTimeCarryFood = Convert.ToByte(loadedData[16]);
            workTimeCashier = Convert.ToByte(loadedData[17]);
            workTimeCarwash = Convert.ToByte(loadedData[18]);
            workTimeFactory = Convert.ToByte(loadedData[19]);
            workTimeSite = Convert.ToByte(loadedData[20]);
            workTimeGame = Convert.ToByte(loadedData[21]);
            workTimeStream = Convert.ToByte(loadedData[22]);
            workTimeBook = Convert.ToByte(loadedData[23]);
            thirst = Convert.ToByte(loadedData[24]);
            MilkValue = Convert.ToByte(loadedData[25]);
            havePet = bool.Parse(loadedData[26]);
            catDies = Convert.ToByte(loadedData[27]);
            allMoney = Convert.ToInt32(loadedData[28]);
            allMelons = Convert.ToInt32(loadedData[29]);
            allGrapes = Convert.ToInt32(loadedData[30]);
            allCorns = Convert.ToInt32(loadedData[31]);
            allDonuts = Convert.ToInt32(loadedData[32]);
            allChickens = Convert.ToInt32(loadedData[33]);
            allMilk = Convert.ToInt32(loadedData[34]);
            allPills = Convert.ToInt32(loadedData[35]);
            allSyringe = Convert.ToInt32(loadedData[36]);
        }

        private void tMood_Tick(object sender, EventArgs e)
        {
            mood -= 1;
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("Progress.ati"))
            {
                loadProgress("Progress.ati");
                frameUp.Enabled = true;
                if (havePet == true)
                {
                    timerBackup();
                }
                else
                {
                    timerOff();
                }
            }
            else
            {
                MelonValue = 3;
                allMelons += 3;
                GrapeValue = 1;
                allGrapes += 1;
                CornValue = 1;
                allCorns += 1;
                PillValue = 5;
                allPills += 5;
                SyringeValue = 1;
                allSyringe += 1;
                petSpawn();
            }
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveProgress();
        }

        private void frameUp_Tick(object sender, EventArgs e)
        {
            frameUpdate();
        }

        private void tSatiety_Tick(object sender, EventArgs e)
        {
            satiety--;
        }

        private void tHealth_Tick(object sender, EventArgs e)
        {
            health--;
        }

        private void tAutoSave_Tick(object sender, EventArgs e)
        {
            saveProgress();
            lblSaved.Visible = true;
            tAutoSaveFalse.Enabled = true;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            saveProgress();
            formShop Shop = new formShop();
            Shop.Owner = this;
            Shop.lblMelonGive.Visible = false;
            Shop.lblGrapeGive.Visible = false;
            Shop.lblCornGive.Visible = false;
            Shop.lblDonutGive.Visible = false;
            Shop.lblChickenGive.Visible = false;
            Shop.lblMilkGive.Visible = false;
            Shop.lblBuyMelon.Visible = true;
            Shop.lblBuyGrape.Visible = true;
            Shop.lblBuyCorn.Visible = true;
            Shop.lblBuyDonut.Visible = true;
            Shop.lblBuyChicken.Visible = true;
            Shop.lblBuyMilk.Visible = true;
            Shop.lblMelonPrice.Visible = true;
            Shop.lblGrapePrice.Visible = true;
            Shop.lblCornPrice.Visible = true;
            Shop.lblDonutPrice.Visible = true;
            Shop.lblChickenPrice.Visible = true;
            Shop.lblMilkPrice.Visible = true;
            Shop.lblShopName.Text = "Магазин";
            Shop.Text = "Магазин";
            if (havePet == false)
            {
                Shop.Width = 614;
                Shop.Height = 297;
            } else
            {
                Shop.Width = 614;
                Shop.Height = 175;
            }
            
            Shop.ShowDialog();
        }

        private void lblWork_Click(object sender, EventArgs e)
        {
            saveProgress();
            FormJobs Work = new FormJobs();
            Work.Owner = this;
            Work.ShowDialog();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            saveProgress();
            formShop Shop = new formShop();
            Shop.Owner = this;
            Shop.lblMelonGive.Visible = true;
            Shop.lblGrapeGive.Visible = true;
            Shop.lblCornGive.Visible = true;
            Shop.lblDonutGive.Visible = true;
            Shop.lblChickenGive.Visible = true;
            Shop.lblMilkGive.Visible = true;
            Shop.lblBuyMelon.Visible = false;
            Shop.lblBuyGrape.Visible = false;
            Shop.lblBuyCorn.Visible = false;
            Shop.lblBuyDonut.Visible = false;
            Shop.lblBuyChicken.Visible = false;
            Shop.lblBuyMilk.Visible = false;
            Shop.lblMelonValue.Visible = true;
            Shop.lblGrapeValue.Visible = true;
            Shop.lblCornValue.Visible = true;
            Shop.lblDonutValue.Visible = true;
            Shop.lblChickenValue.Visible = true;
            Shop.lblMilkValue.Visible = true;
            Shop.lblMelonPrice.Visible = false;
            Shop.lblGrapePrice.Visible = false;
            Shop.lblCornPrice.Visible = false;
            Shop.lblDonutPrice.Visible = false;
            Shop.lblChickenPrice.Visible = false;
            Shop.lblMilkPrice.Visible = false;
            Shop.lblShopName.Text = "Склад";
            Shop.Text = "Склад";
            Shop.Width = 614;
            Shop.Height = 175;
            Shop.ShowDialog();
        }

        private void tTirednessUp_Tick(object sender, EventArgs e)
        {
            tiredness++;
        }

        private void tTirednessDown_Tick(object sender, EventArgs e)
        {
            tiredness--;
        }

        private void lblPharmacy_Click(object sender, EventArgs e)
        {
            saveProgress();
            formPharmacy Pharmacy = new formPharmacy();
            Pharmacy.Owner = this;
            Pharmacy.lblPillGive.Visible = false;
            Pharmacy.lblSyringeGive.Visible = false;
            Pharmacy.lblBuyPill.Visible = true;
            Pharmacy.lblBuySyringe.Visible = true;
            Pharmacy.lblPillPrice.Visible = true;
            Pharmacy.lblSyringePrice.Visible = true;
            Pharmacy.lblPharmacyName.Text = "Аптека";
            Pharmacy.Text = "Аптека";
            Pharmacy.ShowDialog();
        }

        private void lblHeal_Click(object sender, EventArgs e)
        {
            saveProgress();
            formPharmacy Pharmacy = new formPharmacy();
            Pharmacy.Owner = this;
            Pharmacy.lblPillGive.Visible = true;
            Pharmacy.lblSyringeGive.Visible = true;
            Pharmacy.lblBuyPill.Visible = false;
            Pharmacy.lblBuySyringe.Visible = false;
            Pharmacy.lblPillPrice.Visible = false;
            Pharmacy.lblSyringePrice.Visible = false;
            Pharmacy.lblPharmacyName.Text = "Аптечка";
            Pharmacy.Text = "Аптечка";
            Pharmacy.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            havePet = true;
            health = 0;
        }

        private void tThirst_Tick(object sender, EventArgs e)
        {
            thirst--;
        }

        private void tAutoSaveFalse_Tick(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
            tAutoSaveFalse.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mood += Convert.ToByte(rnd.Next(1, 5));
            if (mood >= 100)
            {
                mood = 100;
            }
            if (tirednessUp == true && tiredness<=98)
            {
                tiredness += 2;
            }
        }

        private void btnPharmacy_MouseEnter(object sender, EventArgs e)
        {
            btnPharmacy.ForeColor = Color.LightSkyBlue;
        }

        private void btnPharmacy_MouseLeave(object sender, EventArgs e)
        {
            btnPharmacy.ForeColor = Color.White;
        }

        private void btnShop_MouseEnter(object sender, EventArgs e)
        {
            btnShop.ForeColor = Color.LightSkyBlue;
        }

        private void btnShop_MouseLeave(object sender, EventArgs e)
        {
            btnShop.ForeColor = Color.White;
        }

        private void btnHeal_MouseEnter(object sender, EventArgs e)
        {
            btnHeal.ForeColor = Color.LightSkyBlue;
        }

        private void btnHeal_MouseLeave(object sender, EventArgs e)
        {
            btnHeal.ForeColor = Color.White;
        }

        private void btnFeed_MouseEnter(object sender, EventArgs e)
        {
            btnFeed.ForeColor = Color.LightSkyBlue;
        }

        private void btnFeed_MouseLeave(object sender, EventArgs e)
        {
            btnFeed.ForeColor = Color.White;
        }

        private void btnWork_MouseEnter(object sender, EventArgs e)
        {
            btnWork.ForeColor = Color.LightSkyBlue;
        }

        private void btnWork_MouseLeave(object sender, EventArgs e)
        {
            btnWork.ForeColor = Color.White;
        }

        private void btnAchievements_MouseEnter(object sender, EventArgs e)
        {
            btnAchievements.ForeColor = Color.LightYellow;
        }

        private void btnAchievements_MouseLeave(object sender, EventArgs e)
        {
            btnAchievements.ForeColor = Color.White;
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            AchForm Ach = new AchForm();
            Ach.Show();
            Ach.Owner = this;
            if (workTimeGluePaper >= 1)
            {
                Ach.Achievements.Add("НАЧАЛО НАЧАЛ - Вы впервые поработали.");
            }
            if (allMoney>=1 && allMoney <10000)
            {
                Ach.Achievements.Add("ПЕРВАЯ ЗАРПЛАТА - Вы заработали свои первые деньги.");
            } else
            if (allMoney >= 10000)
            {
                Ach.Achievements.Add("МОНЕТНЫЙ МАГНАТ - Вы заработали 10 или больше тысяч.");
            }
            if (catDies >= 10)
            {
                Ach.Achievements.Add("ЛУЧШИЙ ХОЗЯИН - Ваш питомец умер больше 10 раз.");
            }
            if (allPills >=100 && allSyringe>=100)
            {
                Ach.Achievements.Add("АПТЕКАРЬ - Вы купили 100 или больше пилюль и шприцов с лекарством.");
            }
            if (allMelons>=1000)
            {
                Ach.Achievements.Add("АРБУЗНЫЙ ПОСТАВЩИК - Вы купили 1000 или больше арбузов.");
            }
            
            if (workTimeBook >=100)
            {
                Ach.Achievements.Add("ШТАМПОВЩИК - Вы написали 100 или больше книг");
            }
            string[] AchivementsArray = new string[Ach.Achievements.Count];
            AchivementsArray = Ach.Achievements.ToArray();
            Ach.lbAch.Items.Clear();
            Ach.lbAch.Items.AddRange(AchivementsArray);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.LightSkyBlue;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void formMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointGame = new Point(e.X, e.Y);
        }

        private void formMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointGame.X;
                this.Top += e.Y - lastPointGame.Y;
            }
        }
        
        private void btnStats_Click(object sender, EventArgs e)
        {
            formStats Stats = new formStats();
            Stats.Owner = this;
            Stats.ShowDialog();
        }

        private void tEvent_Tick(object sender, EventArgs e)
        {
            formEvent Event = new formEvent();
            Event.Owner = this;
            Event.ShowDialog();
        }

        private void btnStats_MouseEnter(object sender, EventArgs e)
        {
            btnStats.ForeColor = Color.LightSkyBlue;
        }

        private void btnStats_MouseLeave(object sender, EventArgs e)
        {
            btnStats.ForeColor = Color.White;
        }
    }
}

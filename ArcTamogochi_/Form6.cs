using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcTamogochi_
{
    public partial class FormJobs : Form
    {
        Point lastPointGame;
        byte workTimeGluePaper = 0;
        byte workTimeWashingFloors = 0;
        byte workTimeCarryFood = 0;
        byte workTimeCashier = 0;
        byte workTimeCarwash = 0;
        byte workTimeFactory= 0;
        byte workTimeSite = 0;
        byte workTimeGame = 0;
        byte workTimeStream = 0;
        byte workTimeBook = 0;

        public FormJobs()
        {
            InitializeComponent();
            const byte n = 10;
            loadProgress("Progress.ati");
            string[] jobs = new string[n]
            {
                "Расклеивать листовки",
                "Мыть полы",
                "Разносить еду",
                "Работать кассиром",
                "Работать на автомойке",
                "Работать на заводе",
                "Написать сайт",
                "Сделать игру",
                "Стримить",
                "Написать книгу"
            };
            lbJobs.Items.AddRange(jobs);
        }

        private void loadProgress(string name)
        {
           string[] loadedData = File.ReadAllLines(name);
           workTimeGluePaper = Convert.ToByte(loadedData[14]);
           workTimeWashingFloors = Convert.ToByte(loadedData[15]);
           workTimeCarryFood = Convert.ToByte(loadedData[16]);
           workTimeCashier = Convert.ToByte(loadedData[17]);
           workTimeCarwash= Convert.ToByte(loadedData[18]);
           workTimeFactory = Convert.ToByte(loadedData[19]);
           workTimeSite = Convert.ToByte(loadedData[20]);
           workTimeGame = Convert.ToByte(loadedData[21]);
           workTimeStream = Convert.ToByte(loadedData[22]);
           workTimeBook = Convert.ToByte(loadedData[23]);
        }

        Random rand = new Random();

        private void lbJobs_DoubleClick(object sender, EventArgs e)
        {
            FormWork Work = new FormWork();
            formMain Main = Owner as formMain;
            Work.Owner = Main;
            switch (lbJobs.SelectedIndex)
            {
                case 0:
                    Work.NewMoney = rand.Next(2, 3);
                    Work.min = 70;
                    Work.max = 90;
                    Work.ShowDialog();
                    Work.Dispose();
                    workTimeGluePaper++;
                    break;
                case 1:
                    if (!(workTimeGluePaper <= 5))
                    {
                        Work.NewMoney = rand.Next(2, 4);
                        Work.min = 60;
                        Work.max = 85;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeWashingFloors++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 2:
                    if (!(workTimeWashingFloors <= 5))
                    {
                        Work.NewMoney = rand.Next(4, 5);
                        Work.min = 50;
                        Work.max = 70;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeCarryFood++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 3:
                    if (!(workTimeCarryFood <= 5))
                    {
                        Work.NewMoney = rand.Next(5, 6);
                        Work.min = 40;
                        Work.max = 65;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeCashier++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 4:
                    if (!(workTimeCashier <= 5))
                    {
                        Work.NewMoney = rand.Next(6, 7);
                        Work.min = 30;
                        Work.max = 50;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeCarwash++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 5:
                    if (!(workTimeCarwash <= 5))
                    {
                        Work.NewMoney = rand.Next(7, 9);
                        Work.min = 20;
                        Work.max = 45;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeFactory++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 6:
                    if (!(workTimeFactory <= 5))
                    {
                        Work.NewMoney = rand.Next(9, 12);
                        Work.min = 10;
                        Work.max = 35;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeSite++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 7:
                    if (!(workTimeSite <= 5))
                    {
                        Work.NewMoney = rand.Next(15, 20);
                        Work.min = 10;
                        Work.max = 30;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeGame++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 8:
                    if (!(workTimeGame <= 5))
                    {
                        Work.NewMoney = rand.Next(20, 25);
                        Work.min = 5;
                        Work.max = 15;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeStream++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                case 9:
                    if (!(workTimeStream <= 5))
                    {
                        Work.NewMoney = rand.Next(30, 40);
                        Work.min = 1;
                        Work.max = 10;
                        Work.ShowDialog();
                        Work.Dispose();
                        workTimeBook++;
                    }
                    else
                    {
                        MessageBox.Show("У вас недостаточно опыта для данной работы", "");
                    }
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (workTimeGluePaper > 5)
            {
                lblWash.ForeColor = Color.White;
            }
            else
            {
                lblWash.ForeColor = Color.Red;
            }
            if (workTimeWashingFloors > 5)
            {
                lblFood.ForeColor = Color.White;
            }
            else
            {
                lblFood.ForeColor = Color.Red;
            }
            if (workTimeCarryFood > 5)
            {
                lblCashier.ForeColor = Color.White;
            }
            else
            {
                lblCashier.ForeColor = Color.Red;
            }
            if (workTimeCashier > 5)
            {
                lblCarWash.ForeColor = Color.White;
            }
            else
            {
                lblCarWash.ForeColor = Color.Red;
            }
            if (workTimeCarwash > 5)
            {
                lblFactory.ForeColor = Color.White;
            }
            else
            {
                lblFactory.ForeColor = Color.Red;
            }
            if (workTimeFactory > 5)
            {
                lblSite.ForeColor = Color.White;
            }
            else
            {
                lblSite.ForeColor = Color.Red;
            }
            if (workTimeSite > 5)
            {
                lblGame.ForeColor = Color.White;
            }
            else
            {
                lblGame.ForeColor = Color.Red;
            }
            if (workTimeGame > 5)
            {
                lblStream.ForeColor = Color.White;
            }
            else
            {
                lblStream.ForeColor = Color.Red;
            }
            if (workTimeStream > 5)
            {
                lblBook.ForeColor = Color.White;
            }
            else
            {
                lblBook.ForeColor = Color.Red;
            }
        }

        private void FormJobs_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMain Main = Owner as formMain;
            Main.workTimeWashingFloors = workTimeWashingFloors;
            Main.workTimeGluePaper = workTimeGluePaper;
            Main.workTimeCarryFood = workTimeCarryFood;
            Main.workTimeCashier = workTimeCashier;
            Main.workTimeCarwash = workTimeCarwash;
            Main.workTimeFactory = workTimeFactory;
            Main.workTimeSite = workTimeSite;
            Main.workTimeGame = workTimeGame;
            Main.workTimeStream = workTimeStream;
            Main.workTimeBook = workTimeBook;
            Main.saveProgress();
            
        }

        private void FormJobs_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointGame = new Point(e.X, e.Y);
        }

        private void FormJobs_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointGame.X;
                this.Top += e.Y - lastPointGame.Y;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.LightSkyBlue;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }
    }
}

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

namespace ArcTamogochi_
{
    public partial class formPharmacy : Form
    {
        Point lastPointGame;

        public formPharmacy()
        {
            InitializeComponent();
            formMain Main = Owner as formMain;
            loadProgress("Progress.ati");
            lblPillValue.Text = medicine[0].ToString();
            lblSyringeValue.Text = medicine[1].ToString();
        }

        byte[] medicine = new byte[2];
        int Money;
        
        private void loadProgress(string name)
        {
            string[] loadedData = File.ReadAllLines(name);
            Money = Convert.ToInt32(loadedData[6]);
            medicine[0] = Convert.ToByte(loadedData[12]);
            medicine[1] = Convert.ToByte(loadedData[13]);
        }

       

        private void lblClose_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            Main.PillValue = medicine[0];
            Main.SyringeValue = medicine[1];
            Main.Money = Money;
            Main.saveProgress();
            Close();
        }

        private void lblBuyPill_Click_1(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 1)
            {
                medicine[0] += 1;
                Main.allPills++;
                lblPillValue.Text = medicine[0].ToString();
                Money -= 1;
            }
        }

        private void lblBuySyringe_Click_1(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 30)
            {
                Main.allSyringe++;
                medicine[1] += 1;
                lblSyringeValue.Text = medicine[1].ToString();
                Money -= 30;
            }
        }

        private void lblSyringeGive_Click_1(object sender, EventArgs e)
        {
            if (medicine[1] >= 1)
            {
                medicine[1] -= 1;
                lblSyringeValue.Text = medicine[1].ToString();
                formMain Main = Owner as formMain;
                if (Main.health + 50 > 100)
                {
                    Main.health = 100;
                }
                else
                {
                    Main.health += 50;
                }
            }
        }

        private void lblPillGive_Click_1(object sender, EventArgs e)
        {

            if (medicine[0] >= 1)
            {
                medicine[0] -= 1;
                lblPillValue.Text = medicine[0].ToString();
                formMain Main = Owner as formMain;
                if (Main.health + 10 > 100)
                {
                    Main.health = 100;
                }
                else
                {
                    Main.health += 10;
                }

            }
        }

        private void formPharmacy_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointGame = new Point(e.X, e.Y);
        }

        private void formPharmacy_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointGame.X;
                this.Top += e.Y - lastPointGame.Y;
            }
        }

        private void lblBuyPill_MouseEnter(object sender, EventArgs e)
        {
            lblBuyPill.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyPill_MouseLeave(object sender, EventArgs e)
        {
            lblBuyPill.ForeColor = Color.White;
        }

        private void lblPillGive_MouseEnter(object sender, EventArgs e)
        {
            lblPillGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblPillGive_MouseLeave(object sender, EventArgs e)
        {
            lblPillGive.ForeColor = Color.White;
        }

        private void lblBuySyringe_MouseEnter(object sender, EventArgs e)
        {
            lblBuySyringe.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuySyringe_MouseLeave(object sender, EventArgs e)
        {
            lblBuySyringe.ForeColor = Color.White;
        }

        private void lblSyringeGive_MouseEnter(object sender, EventArgs e)
        {
            lblSyringeGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblSyringeGive_MouseLeave(object sender, EventArgs e)
        {
            lblSyringeGive.ForeColor = Color.White;
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

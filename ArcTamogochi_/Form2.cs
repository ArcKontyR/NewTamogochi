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
    public partial class formShop : Form
    {
        byte[] products = new byte[6];
        int Money;
        Point lastPointGame;

        public formShop()
        {
            InitializeComponent();
            formMain Main = Owner as formMain;
            loadProgress("Progress.ati");
            lblMelonValue.Text = products[0].ToString();
            lblGrapeValue.Text = products[1].ToString();
            lblCornValue.Text = products[2].ToString();
            lblDonutValue.Text = products[3].ToString();
            lblChickenValue.Text = products[4].ToString();
            lblMilkValue.Text = products[5].ToString();
            
            
        }
        
        private void loadProgress(string name)
        {
            string[] loadedData = File.ReadAllLines(name);
            Money = Convert.ToInt32(loadedData[6]);
            products[0] = Convert.ToByte(loadedData[7]);
            products[1] = Convert.ToByte(loadedData[8]);
            products[2] = Convert.ToByte(loadedData[9]);
            products[3] = Convert.ToByte(loadedData[10]);
            products[4] = Convert.ToByte(loadedData[11]);
            products[5] = Convert.ToByte(loadedData[25]);
        }

        private void lblBuyMelon_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 5)
            {
                products[0] += 1;
                Main.allMelons++;
                lblMelonValue.Text = products[0].ToString();
                Money -= 5;
            }

        }

        private void lblBuyGrape_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 10)
            {
                products[1] += 1;
                Main.allGrapes++;
                lblGrapeValue.Text = products[1].ToString();
                Money -= 10;
            }
        }

        private void lblBuyCorn_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 15)
            {
                products[2] += 1;
                Main.allCorns++;
                lblCornValue.Text = products[2].ToString();
                Money -= 15;
            }
        }

        private void lblBuyDonut_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 20)
            {
                products[3] += 1;
                Main.allDonuts++;
                lblDonutValue.Text = products[3].ToString();
                Money -= 20;
            }
        }

        private void lblBuyChicken_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 25)
            {
                products[4] += 1;
                Main.allChickens++;
                lblChickenValue.Text = products[4].ToString();
                Money -= 25;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            Main.MelonValue = products[0];
            Main.GrapeValue = products[1];
            Main.CornValue = products[2];
            Main.DonutValue = products[3];
            Main.ChickenValue = products[4];
            Main.MilkValue = products[5];
            Main.Money = Money;
            Main.saveProgress();
            Close();
        }

        private void lblMelonGive_Click(object sender, EventArgs e)
        {
            if (products[0] >= 1)
            {
                products[0] -= 1;
                lblMelonValue.Text = products[0].ToString();
                formMain Main = Owner as formMain;
                if (Main.mood >= 50)
                {
                    if (Main.thirst + 50 > 100)
                    {
                        Main.thirst = 100;
                    }
                    else
                    {
                        Main.thirst += 50;
                    }
                }
                else
                {
                    if (Main.thirst + 30 > 100)
                    {
                        Main.thirst = 100;
                    }
                    else
                    {
                        Main.thirst += 30;
                    }
                }

            }
        }

        private void lblGrapeGive_Click(object sender, EventArgs e)
        {
            if (products[1] >= 1)
            {
                products[1] -= 1;
                lblGrapeValue.Text = products[1].ToString();
                formMain Main = Owner as formMain;
                if (Main.mood >= 50)
                {
                    if (Main.satiety + 20 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 20;
                    }
                } else
                {
                    if (Main.satiety + 10 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 10;
                    }
                }
            }
        }

        private void lblCornGive_Click(object sender, EventArgs e)
        {
            if (products[2] >= 1)
            {
                products[2] -= 1;
                lblCornValue.Text = products[2].ToString();
                formMain Main = Owner as formMain;
                if (Main.mood >= 50)
                {
                    if (Main.satiety + 25 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 25;
                    }
                }
                else
                {
                    if (Main.satiety + 15 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 15;
                    }
                }
            }
        }

        private void lblDonutGive_Click(object sender, EventArgs e)
        {
            if (products[3] >= 1)
            {
                products[3] -= 1;
                lblDonutValue.Text = products[3].ToString();
                formMain Main = Owner as formMain;
                if (Main.mood >= 50)
                {
                    if (Main.satiety + 30 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 30;
                    }
                }
                else
                {
                    if (Main.satiety + 20 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 20;
                    }
                }
            }
        }

        private void lblChickenGive_Click(object sender, EventArgs e)
        {
            if (products[4] >= 1)
            {
                products[4] -= 1;
                lblChickenValue.Text = products[4].ToString();
                formMain Main = Owner as formMain;
                if (Main.mood >= 50)
                {
                    if (Main.satiety + 35 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 35;
                    }
                }
                else
                {
                    if (Main.satiety + 25 > 100)
                    {
                        Main.satiety = 100;
                    }
                    else
                    {
                        Main.satiety += 25;
                    }
                }
            }
        }

        private void lblBuyMilk_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 5)
            {
                products[5] += 1;
                Main.allMilk++;
                lblMilkValue.Text = products[5].ToString();
                Money -= 5;
            }
        }

        private void lblMilkGive_Click(object sender, EventArgs e)
        {
            if (products[5] >= 1)
            {
                products[5] -= 1;
                formMain Main = Owner as formMain;
                lblMilkValue.Text = products[5].ToString();
                if (Main.mood >= 50)
                {
                    if (Main.thirst + 20 > 100)
                    {
                        Main.thirst = 100;
                    }
                    else
                    {
                        Main.thirst += 20;
                    }
                } else
                {
                    if (Main.thirst + 10 > 100)
                    {
                        Main.thirst = 100;
                    }
                    else
                    {
                        Main.thirst += 10;
                    }
                }
            }
        }

        private void lblBuyCat_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            if (Money >= 500)
            {
                Main.havePet = true;
                Main.petSpawn();
                Width = 614;
                Height = 175;
                Money -= 500;
            } else
            {
                MessageBox.Show("Недостаточно монет", "Это не конец.", MessageBoxButtons.OK);
            }
        }

        private void formShop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointGame.X;
                this.Top += e.Y - lastPointGame.Y;
            }
        }

        private void formShop_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointGame = new Point(e.X, e.Y);
        }

        private void formShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void lblBuyMilk_MouseEnter(object sender, EventArgs e)
        {
            lblBuyMilk.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyMilk_MouseLeave(object sender, EventArgs e)
        {
            lblBuyMilk.ForeColor = Color.White;
        }

        private void lblMilkGive_MouseEnter(object sender, EventArgs e)
        {
            lblMilkGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblMilkGive_MouseLeave(object sender, EventArgs e)
        {
            lblMilkGive.ForeColor = Color.White;
        }

        private void lblBuyMelon_MouseEnter(object sender, EventArgs e)
        {
            lblBuyMelon.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyMelon_MouseLeave(object sender, EventArgs e)
        {
            lblBuyMelon.ForeColor = Color.White;
        }

        private void lblMelonGive_MouseEnter(object sender, EventArgs e)
        {
            lblMelonGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblMelonGive_MouseLeave(object sender, EventArgs e)
        {
            lblMelonGive.ForeColor = Color.White;
        }

        private void lblBuyGrape_MouseEnter(object sender, EventArgs e)
        {
            lblBuyGrape.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyGrape_MouseLeave(object sender, EventArgs e)
        {
            lblBuyGrape.ForeColor = Color.White;
        }

        private void lblGrapeGive_MouseEnter(object sender, EventArgs e)
        {
            lblGrapeGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblGrapeGive_MouseLeave(object sender, EventArgs e)
        {
            lblGrapeGive.ForeColor = Color.White;
        }

        private void lblBuyCorn_MouseEnter(object sender, EventArgs e)
        {
            lblBuyCorn.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyCorn_MouseLeave(object sender, EventArgs e)
        {
            lblBuyCorn.ForeColor = Color.White;
        }

        private void lblCornGive_MouseEnter(object sender, EventArgs e)
        {
            lblCornGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblCornGive_MouseLeave(object sender, EventArgs e)
        {
            lblCornGive.ForeColor = Color.White;
        }

        private void lblBuyDonut_MouseEnter(object sender, EventArgs e)
        {
            lblBuyDonut.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyDonut_MouseLeave(object sender, EventArgs e)
        {
            lblBuyDonut.ForeColor = Color.White;
        }

        private void lblDonutGive_MouseEnter(object sender, EventArgs e)
        {
            lblDonutGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblDonutGive_MouseLeave(object sender, EventArgs e)
        {
            lblDonutGive.ForeColor = Color.White;
        }

        private void lblBuyChicken_MouseEnter(object sender, EventArgs e)
        {
            lblBuyChicken.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyChicken_MouseLeave(object sender, EventArgs e)
        {
            lblBuyChicken.ForeColor = Color.White;
        }

        private void lblChickenGive_MouseEnter(object sender, EventArgs e)
        {
            lblChickenGive.ForeColor = Color.LightSkyBlue;
        }

        private void lblChickenGive_MouseLeave(object sender, EventArgs e)
        {
            lblChickenGive.ForeColor = Color.White;
        }

        private void lblBuyCat_MouseEnter(object sender, EventArgs e)
        {
            lblBuyCat.ForeColor = Color.LightSkyBlue;
        }

        private void lblBuyCat_MouseLeave(object sender, EventArgs e)
        {
            lblBuyCat.ForeColor = Color.White;
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

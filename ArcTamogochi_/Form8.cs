using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcTamogochi_
{
    public partial class formStats : Form
    {
        public formStats()
        {
            InitializeComponent();
        }

        Point lastPointGame;

        private void formStats_Load(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            lbStats.Items.Add($"{Main.allMoney} - Всего заработано монет") ;
            lbStats.Items.Add($"{Main.catDies} - Питомцев умерло");
            lbStats.Items.Add($"{Main.allMelons} - Всего куплено арбузов");
            lbStats.Items.Add($"{Main.allGrapes} - Всего куплено винограда");
            lbStats.Items.Add($"{Main.allCorns} - Всего куплено кукуруз");
            lbStats.Items.Add($"{Main.allDonuts} - Всего куплено пончиков");
            lbStats.Items.Add($"{Main.allChickens} - Всего куплено курочек");
            lbStats.Items.Add($"{Main.allMilk} - Всего куплено молока");
            lbStats.Items.Add($"{Main.allPills} - Всего куплено таблеток");
            lbStats.Items.Add($"{Main.allSyringe} - Всего куплено шприцов");
            lbStats.Items.Add($"{Main.workTimeGluePaper} - Отработано расклейщиком листовок");
            lbStats.Items.Add($"{Main.workTimeWashingFloors} - Отработано мойщиком полов");
            lbStats.Items.Add($"{Main.workTimeCarryFood} - Отработано доставщиком еды");
            lbStats.Items.Add($"{Main.workTimeCashier} - Отработано кассиром");
            lbStats.Items.Add($"{Main.workTimeCarwash} - Отработано в автомойке");
            lbStats.Items.Add($"{Main.workTimeFactory} - Отработано на заводе");
            lbStats.Items.Add($"{Main.workTimeSite} - Сделано сайтов");
            lbStats.Items.Add($"{Main.workTimeGame} - Сделано игр");
            lbStats.Items.Add($"{Main.workTimeStream} - Проведено стримов (коту)");
            lbStats.Items.Add($"{Main.workTimeBook} - Написано книг");

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

        private void formStats_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointGame = new Point(e.X, e.Y);
        }

        private void formStats_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointGame.X;
                this.Top += e.Y - lastPointGame.Y;
            }
        }
    }
}

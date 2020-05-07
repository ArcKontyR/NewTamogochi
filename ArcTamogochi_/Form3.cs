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
    public partial class FormWork : Form
    {
        public int NewMoney;
        public int workProgress;
        public FormWork()
        {
            InitializeComponent();
        }
        
        Random rand = new Random();
        public byte min;
        public byte max;
        byte working = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            workProgress = rand.Next(min, max);
            if(prbWork.Value + workProgress < 100)
            {
                prbWork.Value += workProgress;
            }
            else
            {
                prbWork.Value += 100 - prbWork.Value;
            }

            if (prbWork.Value == 100)
                this.Close();
        }

        private void FormWork_FormClosing(object sender, FormClosingEventArgs e)
        {
          formMain Main = Owner as formMain;
          Main.Money += NewMoney;
            Main.allMoney += NewMoney;
          Main.saveProgress();
        }

       

        private void tWorking_Tick(object sender, EventArgs e)
        {
            if (working == 0 )
            {
                lblLoading.Text = "Работаем";
                working++;
            } else
                if (working == 1)
            {
                lblLoading.Text = "Работаем.";
                working++;
            } else
                if (working == 2)
            {
                lblLoading.Text = "Работаем..";
                working++;
            } else
                if (working == 3)
            {
                lblLoading.Text = "Работаем...";
                working = 0;
            }
        }
    }
}

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
    public partial class formEvent : Form
    {
        public formEvent()
        {
            InitializeComponent();
        }

        Point lastPointGame;

        string[] events = new string[10] 
        { "Ваш питомец врезался в стену, пока бегал по коридору. \nЗдоровье -10",
          "Ваш питомец съел муху. \nСытость +1 \nНастроение +10",
          "Ваш питомец нагадил вам в тапки, в последствие чего он был публично высмеян. \nНастроение -20",
          "Ваш питомец запутался в одеяле. \n Настроение -10 \nМяу +ထ",
          "Ваш питомец съел ваш любимый цветок за что был поставлен в угол. Он проголодался. \nСытость -20",
          "Ваш питомец целый час гонялся за своим хвостом. Он куснул себя за хвост \nЗдоровье -3 \nНастроение +5",
          "Ваш питомец съел покусал ваш бутерброд и пролил воду на стол. \nСытость +15 \nЗдоровье +5 \nНастроение +5 \nЖажда +5",
          "Ваш питомец нашел мертвую мышь и принес её вам. Похвалите его. \nНастроение +10",
          "Ваш питомец испугался своей тени \nЖажда -10",
          "Ваш питомец целый час гонялся за своим хвостом. Неудача \nНастроение -5"
        };
        Random rnd = new Random();
        byte evNumber;
        private void lblClose_Click(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            Main.saveProgress();
            Close();
            Dispose();
        }

        private void formEvent_Load(object sender, EventArgs e)
        {
            formMain Main = Owner as formMain;
            evNumber = Convert.ToByte(rnd.Next(0, events.Length));
            lblEvent.Text = events[evNumber];
            switch (evNumber)
            {
                case 0:
                    if (Main.health >= 10)
                    {
                        Main.health -= 10;
                    } else
                    {
                        Main.health = 0;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 1:
                    if (Main.satiety <= 100)
                    {
                        Main.satiety++;
                    }
                    else
                    {
                        Main.satiety = 100;
                    }
                    if (Main.mood <= 90)
                    {
                        Main.mood += 10;
                    }
                    else
                    {
                        Main.mood = 100;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 2:
                    if (Main.mood >= 20)
                    {
                        Main.mood -= 20;
                    }
                    else
                    {
                        Main.mood = 0;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 3:
                    if (Main.mood >= 10)
                    {
                        Main.mood -= 10;
                    }
                    else
                    {
                        Main.mood = 0;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 4:
                    if (Main.satiety >= 20)
                    {
                        Main.satiety -= 20;
                    }
                    else
                    {
                        Main.satiety = 0;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 5:
                    if (Main.health >= 3)
                    {
                        Main.health-=3;
                    }
                    else
                    {
                        Main.health = 0;
                    }
                    if (Main.mood <=95)
                    {
                        Main.mood += 5;
                    }
                    else
                    {
                        Main.mood = 100;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 6:
                    if (Main.health <= 95)
                    {
                        Main.health += 5;
                    }
                    else
                    {
                        Main.health = 100;
                    }
                    if (Main.mood <= 95)
                    {
                        Main.mood += 5;
                    }
                    else
                    {
                        Main.mood = 100;
                    }
                    if (Main.satiety <= 85)
                    {
                        Main.satiety += 15;
                    }
                    else
                    {
                        Main.satiety = 100;
                    }
                    if (Main.thirst <= 95)
                    {
                        Main.thirst += 5;
                    }
                    else
                    {
                        Main.thirst = 100;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 7:
                    if (Main.mood <= 90)
                    {
                        Main.mood += 10;
                    }
                    else
                    {
                        Main.mood = 100;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 8:
                    if (Main.thirst >= 10)
                    {
                        Main.thirst -= 10;
                    }
                    else
                    {
                        Main.thirst = 0;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
                case 9:
                    if (Main.mood >= 5)
                    {
                        Main.mood -= 5;
                    }
                    else
                    {
                        Main.mood = 0;
                    }
                    Main.frameUpdate();
                    Main.saveProgress();
                    break;
            }
        }

        private void formEvent_MouseDown(object sender, MouseEventArgs e)
        {
            lastPointGame = new Point(e.X, e.Y);
        }

        private void formEvent_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPointGame.X;
                this.Top += e.Y - lastPointGame.Y;
            }
        }
    }
}

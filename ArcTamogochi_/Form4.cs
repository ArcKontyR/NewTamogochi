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
    public partial class formCatName : Form
    {
        public formCatName()
        {
            InitializeComponent();
        }

        private void lblOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formCatName_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMain Main = Owner as formMain;
            Main.petName = tbCatName.Text;
        }

        private void tbCatName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (key>=33 && key<=64 || key>=91 && key<=96 || key >=123 && key<=126)
            {
                e.Handled = true;
            }
        }

        private void tbCatName_TextChanged(object sender, EventArgs e)
        {
            if (tbCatName.Text != "")
            {
                lblOK.Visible = true;
            } else
            {
                lblOK.Visible = false;
            }
        }
    }
}

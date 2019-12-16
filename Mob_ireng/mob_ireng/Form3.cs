using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mob_ireng
{
    public partial class Form3 : Form
    {
        Form4 f4;
        Form5 f5;
        public int naudotojas_prisijunges;

        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) //prisijungimas
        {
            this.Hide();
            f4 = new Form4();
            f4.naudotojas_prisijunges = naudotojas_prisijunges;
            f4.FormClosed += new FormClosedEventHandler(f4_FormClosed);
            f4.ShowDialog();
        }

        private void f4_FormClosed(object sender, FormClosedEventArgs e)
        {
            naudotojas_prisijunges = f4.naudotojas_prisijunges;
            if (naudotojas_prisijunges > 0)
            {
                label5.Text = "Atsijungti";
                label5.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label5.Text = "Prisijungti/Registruotis";
                label5.ForeColor = System.Drawing.Color.Green;
            }
            if (naudotojas_prisijunges > 0)
            {
                this.Close();
            }
            else this.Show();
        }

        private void Button2_Click(object sender, EventArgs e) //registracija
        {
            this.Close();
            f5 = new Form5();
            f5.naudotojas_prisijunges = naudotojas_prisijunges;
            f5.FormClosed += new FormClosedEventHandler(f5_FormClosed);
            f5.ShowDialog();
        }

        private void f5_FormClosed(object sender, FormClosedEventArgs e)
        {
            naudotojas_prisijunges = f5.naudotojas_prisijunges;
            if (naudotojas_prisijunges == 1 || naudotojas_prisijunges == 2)
            {
                this.Close();
            }
            else this.Show();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (naudotojas_prisijunges > 0)
            {
                label5.Text = "Atsijungti";
                label5.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label5.Text = "Prisijungti/Registruotis";
                label5.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}

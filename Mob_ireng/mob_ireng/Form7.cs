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
    public partial class Form7 : Form
    {
        Form8 f8;
        Form9 f9;
        public int naudotojas_prisijunges;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f8 = new Form8();
            f8.naudotojas_prisijunges = this.naudotojas_prisijunges;
            f8.FormClosed += new FormClosedEventHandler(f8_FormClosed);
            f8.ShowDialog();
        }

        private void f8_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f9 = new Form9();
            f9.naudotojas_prisijunges = this.naudotojas_prisijunges;
            f9.FormClosed += new FormClosedEventHandler(f9_FormClosed);
            f9.ShowDialog();
        }

        private void f9_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}

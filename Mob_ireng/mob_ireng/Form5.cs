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
    public partial class Form5 : Form
    {
        public int naudotojas_prisijunges;
        naudotojo_repository naudotojai = new naudotojo_repository();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBoxelpastas.Text == "" || textBoxtelefonas.Text == "" || textBoxpassword.Text == "" || textBoxusername.Text == "" || textBoxpavarde.Text == "" || textBoxvardas.Text == "" || textBoxelpastas.Text == " " || textBoxtelefonas.Text == " " || textBoxpassword.Text == " " || textBoxusername.Text == " " || textBoxpavarde.Text == " " || textBoxvardas.Text == " " || textBoxelpastas.Text == "  " || textBoxtelefonas.Text == "  " || textBoxpassword.Text == "  " || textBoxusername.Text == "  " || textBoxpavarde.Text == "  " || textBoxvardas.Text == "  ")
            {
                MessageBox.Show("Visi laukai turi būti užpildyti.");
            }
            else
            {
                naudotojai.insert_naudotojas(textBoxvardas.Text, textBoxpavarde.Text, textBoxusername.Text, textBoxpassword.Text, textBoxelpastas.Text, textBoxtelefonas.Text);
                MessageBox.Show("Jus sekmingai prisiregistravote");
                this.Close();
            }
            naudotojas_prisijunges = 1;
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

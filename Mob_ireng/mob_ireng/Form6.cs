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
    public partial class Form6 : Form
    {
        public int naudotojas_prisijunges;
        naudotojo_repository naudotojai = new naudotojo_repository();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            naudotojai.set_naudotojas_by_id(naudotojas_prisijunges);
            List<naudotojas> naudotojo_sarasas = naudotojai.get_naudotojas();
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
            label3.Text = naudotojo_sarasas[0].username;
            label6.Text = naudotojo_sarasas[0].vardas;
            label7.Text = naudotojo_sarasas[0].pavarde;
            label8.Text = naudotojo_sarasas[0].el_pastas;
            label9.Text = naudotojo_sarasas[0].telefonas;
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            if (naudotojas_prisijunges > 0)
            {
                naudotojas_prisijunges = 0;
                this.Close();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

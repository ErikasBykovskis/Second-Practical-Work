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
    public partial class Form9 : Form
    {
        public int naudotojas_prisijunges;
        prekiu_repository prekes = new prekiu_repository();
        informaciju_repository informacijos = new informaciju_repository();
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
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
            prekes.set_prekiu_sarasas();
            List<preke> prekiu_sarasas = prekes.get_prekiu_sarasas();
            for (int i = 0; i < prekiu_sarasas.Count; i++)
            {
                comboBox1.Items.Add(prekiu_sarasas[i].preke_modelis);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            informacijos.delete_informaciju_sarasas(comboBox1.SelectedItem.ToString());
            MessageBox.Show("Prekė " + comboBox1.SelectedItem.ToString() + " ištrinta.");
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
    }
}

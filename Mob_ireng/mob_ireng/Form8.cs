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
    public partial class Form8 : Form
    {
        public int naudotojas_prisijunges;
        informaciju_repository informacijos = new informaciju_repository();
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            informacijos.set_informaciju_sarasas();
            List<garantija> garantiju_sarasas = informacijos.get_garantiju_sarasas();
            List<modelis> modeliu_sarasas = informacijos.get_modeliu_sarasas();
            List<gamintojas> gamintoju_sarasas = informacijos.get_gamintoju_sarasas();
            List<paveikslelis> paveiksleliu_sarasas = informacijos.get_paveiksleliu_sarasas();
            MessageBox.Show(garantiju_sarasas[0].garantijos_galiojimo_baigimo_data.ToString());
            for(int i = 0; i < gamintoju_sarasas.Count; i++)
            {
                comboBox1.Items.Add(gamintoju_sarasas[i].pavadinimas);
            }
            for (int i = 0; i < modeliu_sarasas.Count; i++)
            {
                comboBox2.Items.Add(modeliu_sarasas[i].pavadinimas);
            }
            for (int i = 0; i < garantiju_sarasas.Count; i++)
            {
                comboBox3.Items.Add(garantiju_sarasas[i].garantijos_galiojimo_baigimo_data);
            }
            for (int i = 0; i < paveiksleliu_sarasas.Count; i++)
            {
                comboBox4.Items.Add(paveiksleliu_sarasas[i].pavadinimas);
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label400_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            informacijos.insert_informaciju_sarasas(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), comboBox4.SelectedItem.ToString(), Convert.ToDouble(textBox1.Text));
            MessageBox.Show("Nauja preke issaugota.");
        }
    }
}

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
    public partial class Form10 : Form
    {
        public List<Krepselis> krepseliosarasas = new List<Krepselis>();
        public int naudotojas_prisijunges;
        informaciju_repository informacijos = new informaciju_repository();
        pirkejo_repository pirkejo = new pirkejo_repository();
        banku_repository bankai = new banku_repository();
        mobiliuju_irenginiu_repository mob_ireng = new mobiliuju_irenginiu_repository();
        mobiliojo_irenginio_uzsakymo_repository mob_ireng_uzs = new mobiliojo_irenginio_uzsakymo_repository();
        apmokejimo_repository apmokejimo = new apmokejimo_repository();
        uzsakymo_repository uzsakymo = new uzsakymo_repository();
        public int laikinas_banko_id;
        public double supvm;
        public double bepvm;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            bankai.set_banku_sarasas();
            List<bankas> banku_sarasas = bankai.get_banku_sarasas();
            for (int i = 0; i < banku_sarasas.Count; i++)
            {
                comboBox4.Items.Add(banku_sarasas[i].pavadinimas);
            }
            for (int i = 0; i < banku_sarasas.Count; i++)
            {
                if (comboBox4.SelectedItem.ToString() == banku_sarasas[i].pavadinimas)
                {
                    laikinas_banko_id = banku_sarasas[i].id;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mob_ireng.set_mobiliuju_irenginu_sarasu_id();
            List<mobilieji_irenginiai> mobiliuju_irenginiu_sarasas = mob_ireng.get_mobiliuju_irenginiu_sarasu_id();

            pirkejo.insert_pirkejas(naudotojas_prisijunges, laikinas_banko_id, textBox1.Text.ToString()); //+
            int pirkejo_id = pirkejo.get_pirkejo_id();

            for (int i = 0; i < krepseliosarasas.Count; i++)
            {
                for (int j = 0; j < mobiliuju_irenginiu_sarasas.Count; j++)
                {
                    if (krepseliosarasas[i].kaina == mobiliuju_irenginiu_sarasas[j].kaina)
                    {
                        mob_ireng_uzs.ivesti_mob_ireng_uzs(mobiliuju_irenginiu_sarasas[j].id, pirkejo_id, krepseliosarasas[i].kiekis); //+
                    }
                }
            }
            
            apmokejimo.insert_apmokejimas(pirkejo_id, "Apmoketa", supvm); //+
            List<int> idsai = new List<int>();
            idsai = mob_ireng_uzs.get_mob_ireng_uzs_main_id(pirkejo_id);
            int trans_id = apmokejimo.get_transakcijos_id();
            for(int i = 0; i < idsai.Count; i++)
            {
                uzsakymo.insert_uzsakymas(idsai[i], trans_id); //+
            }
            this.Close();
        }
    }
}


//pirkejas done; apmokejimas done; mobiliojo_irenginio_uzsakymas done; uzsakymas done.
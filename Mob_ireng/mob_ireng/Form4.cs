using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mob_ireng
{
    public partial class Form4 : Form
    {
        public int naudotojas_prisijunges;
        naudotojo_repository naudotojai = new naudotojo_repository();
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == " " || textBox2.Text == " " || textBox1.Text == "  " || textBox2.Text == "  ")
            {
                MessageBox.Show("Visi laukai turi būti užpildyti.");
            }
            else
            {
                naudotojai.set_naudotojas(textBox1.Text.ToString(), textBox2.Text.ToString());
                List<naudotojas> prisijunges_naudotojas = naudotojai.get_naudotojas();
                
                if (prisijunges_naudotojas.Count > 0)
                {
                    naudotojas_prisijunges = prisijunges_naudotojas[0].id;
                    MessageBox.Show("Jus sekmingai prisijungete!");
                    this.Close();
                }
                else if (prisijunges_naudotojas.Count == 0)
                {
                    MessageBox.Show("Username or Password is incorrect.");
                }
                else if (prisijunges_naudotojas[0].username == "admin" && prisijunges_naudotojas[0].password == "admin")
                {
                    naudotojas_prisijunges = 1;
                    MessageBox.Show("Prisijunge sistemos administratorius.");
                    this.Close();
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mob_ireng
{
    public partial class Form2 : Form
    {
        public List<Krepselis> krepseliosarasas = new List<Krepselis>();
        Label[] labels = new Label[100];
        Label[] labels2 = new Label[100];
        Label[] labels3 = new Label[100];
        Label[] labels4 = new Label[100];
        Label[] labels5 = new Label[100];
        Button[] buttons = new Button[100];
        public int krepseliocountnumber;
        public int delete = 0;
        public int done = 0;
        public int atidaryti = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int height = 0;
            int j = 0;

            for (int i = 0; i < krepseliosarasas.Count; i++)
            {
                var lbl = new Label();
                lbl.Name = Convert.ToString(("lbl_" + i));
                lbl.Text = krepseliosarasas[i].pavadinimas;
                lbl.Location = new Point(472, 365 + height);
                lbl.Font = new Font("Arial", 14, FontStyle.Regular);
                lbl.AutoSize = false;
                lbl.TextAlign = ContentAlignment.TopLeft;
                lbl.Size = new Size(170, 22);
                lbl.Visible = true;
                labels[i] = lbl;
                Controls.Add(labels[i]);

                var lbl2 = new Label();
                lbl2.Name = Convert.ToString(("lbl_" + i));
                lbl2.Text = (Math.Round((decimal)krepseliosarasas[i].kaina, 2)).ToString() + " Eur";
                lbl2.Location = new Point(745, 365 + height);
                lbl2.Font = new Font("Arial", 14, FontStyle.Regular);
                lbl2.AutoSize = false;
                lbl2.TextAlign = ContentAlignment.TopLeft;
                lbl2.AutoSize = false;
                lbl2.Size = new Size(123, 22);
                lbl2.Visible = true;
                labels2[i] = lbl2;
                Controls.Add(labels2[i]);

                var lbl3 = new Label();
                lbl3.Name = Convert.ToString(("lbl_" + i));
                lbl3.Text = krepseliosarasas[i].kiekis.ToString();
                lbl3.Location = new Point(896, 365 + height);
                lbl3.Font = new Font("Arial", 14, FontStyle.Regular);
                lbl3.AutoSize = false;
                lbl3.TextAlign = ContentAlignment.TopLeft;
                lbl3.AutoSize = false;
                lbl3.Size = new Size(123, 22);
                lbl3.Visible = true;
                labels3[i] = lbl3;
                Controls.Add(labels3[i]);

                var button = new Button();
                button.Name = Convert.ToString(i);
                button.Text = "Ištrinti";
                button.Location = new Point(350, 364 + height);
                button.Size = new Size(100, 25);
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Font = new Font("Arial", 10, FontStyle.Bold);
                button.Visible = true;
                button.Click += new EventHandler(button_Click);
                buttons[i] = button;
                Controls.Add(buttons[i]);

                height += 30;
                j++;
            }

            Label lbl4 = new Label();
            lbl4.Name = "lbl321321";
            double bepvm = 0;
            for (int i = 0; i < krepseliosarasas.Count; i++)
            {
                bepvm = bepvm + krepseliosarasas[i].ApskaiciuotaKainaBePvm();
            }
            lbl4.Text = (Math.Round((decimal)bepvm, 2)).ToString() + " Eur";
            lbl4.Location = new Point(1046, 365);
            lbl4.Font = new Font("Arial", 14, FontStyle.Regular);
            lbl4.AutoSize = false;
            lbl4.TextAlign = ContentAlignment.TopLeft;
            lbl4.AutoSize = false;
            lbl4.Size = new Size(123, 22);
            lbl4.Visible = true;
            Controls.Add(lbl4);

            Label lbl5 = new Label();
            lbl5.Name = "lbl123123";
            double supvm = 0;
            for (int i = 0; i < krepseliosarasas.Count; i++)
            {
                supvm = supvm + krepseliosarasas[i].ApskaiciuotaKainaSuPvm();
            }
            lbl5.Text = (Math.Round((decimal)supvm, 2)).ToString() + " Eur";
            lbl5.Location = new Point(1252, 365);
            lbl5.Font = new Font("Arial", 14, FontStyle.Regular);
            lbl5.AutoSize = false;
            lbl5.TextAlign = ContentAlignment.TopLeft;
            lbl5.AutoSize = false;
            lbl5.Size = new Size(123, 22);
            lbl5.Visible = true;
            Controls.Add(lbl5);

            Button button2 = new Button();
            button2.Name = "btn123";
            button2.Text = "Patvirtinti užsakymą";
            button2.Location = new Point(850, 395 + height);
            button2.Size = new Size(250, 30);
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Font = new Font("Arial", 10, FontStyle.Bold);
            button2.Visible = true;
            button2.Click += new EventHandler(button2_Click);
            Controls.Add(button2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\12349\Documents\Cheque.txt";
            string data = DateTime.Now.ToString("dd/MM/yyyy") + Environment.NewLine;
            File.WriteAllText(path, data);
            for (int i = 0; i < krepseliosarasas.Count; i++)
            {
                string createText = krepseliosarasas[i].pavadinimas + "   " + krepseliosarasas[i].kaina + " Eur   x" + krepseliosarasas[i].kiekis + Environment.NewLine;
                File.AppendAllText(path, createText);
            }
            double bepvm = 0;
            for (int i = 0; i < krepseliosarasas.Count; i++)
            {
                bepvm = bepvm + krepseliosarasas[i].ApskaiciuotaKainaBePvm();
            }
            string createbepvm = Convert.ToString(bepvm) + " Eur" + Environment.NewLine;
            File.AppendAllText(path, createbepvm);
            double supvm = 0;
            for (int i = 0; i < krepseliosarasas.Count; i++)
            {
                supvm = supvm + krepseliosarasas[i].ApskaiciuotaKainaSuPvm();
            }
            string createsupvm = Convert.ToString(supvm) + " Eur" + Environment.NewLine;
            File.AppendAllText(path, createsupvm);
            MessageBox.Show("Užsakymas patvirtintas\n\nČėkis išsaugotas C:\\Users\\12349\\Documents\\Cheque.txt");
            done = 1;
            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            krepseliosarasas.RemoveAt(Convert.ToInt32(btn.Name));
            atidaryti = 1;
            krepseliocountnumber--;
            this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

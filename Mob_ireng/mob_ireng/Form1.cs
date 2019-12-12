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
    public partial class Form1 : Form
    {
        prekiu_repository prekes = new prekiu_repository();
        List<Krepselis> krepseliosarasas = new List<Krepselis>();
        PictureBox[] pic = new PictureBox[100];
        TextBox[] texts = new TextBox[100];
        Label[] labels = new Label[100];
        Label[] labels2 = new Label[100];
        Label[] labels3 = new Label[100];
        Label[] labels4 = new Label[100];

        public int height = 0;
        public int width = 0;
        public int countnumber = 0;
        public int krepseliocountnumber = 0;
        public int done = 0;
        public int atidaryti = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prekes.set_prekiu_sarasas();
            List<preke> prekiu_sarasas = prekes.get_prekiu_sarasas();
            int j = 1;

            for (int i = 0; i < prekiu_sarasas.Count; i++)
            {
                if (j % 3 != 0)
                {
                    var lbl = new Label();
                    labels[i] = lbl;
                    lbl.Name = Convert.ToString(("lbl_" + i));
                    lbl.Text = prekiu_sarasas[i].preke_gamintojas + " " + prekiu_sarasas[i].preke_modelis;
                    lbl.Location = new Point(240 + width, 210 + height);
                    lbl.Font = new Font("Arial", 16, FontStyle.Bold);
                    lbl.AutoSize = false;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.AutoSize = false;
                    lbl.Size = new Size(250, 35);
                    lbl.Visible = true;
                    Controls.Add(lbl);

                    var lbl2 = new Label();
                    labels2[i] = lbl2;
                    lbl2.Name = Convert.ToString(("lbl2_" + i));
                    lbl2.Text = prekiu_sarasas[i].preke_garantijos_instrukcija + "\nGarantija galioja iki: " + prekiu_sarasas[i].preke_garantijos_galiojimo_laiko_baigimo_data;
                    lbl2.Location = new Point(450 + width, 350 + height);
                    lbl2.Font = new Font("Arial", 9, FontStyle.Bold);
                    lbl2.AutoSize = false;
                    lbl2.Size = new Size(125, 250);
                    lbl2.Visible = true;
                    Controls.Add(lbl2);

                    Button button = new Button();
                    button.Name = Convert.ToString(i);
                    button.Text = "Užsakyti";
                    button.Location = new Point(300 + width, 570 + height);
                    button.Size = new Size(100, 35);
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 10, FontStyle.Bold);
                    button.Visible = true;
                    button.Click += new EventHandler(button_Click);
                    Controls.Add(button);

                    Button button1 = new Button();
                    button1.Name = Convert.ToString(i);
                    button1.Text = "+";
                    button1.Location = new Point(405 + width, 570 + height);
                    button1.Visible = true;
                    button1.TextAlign = ContentAlignment.MiddleCenter;
                    button1.Size = new Size(17, 17);
                    button1.Font = new Font("Arial", 9, FontStyle.Bold);
                    button1.Click += new EventHandler(button1_Click);
                    Controls.Add(button1);

                    Button button2 = new Button();
                    button2.Name = Convert.ToString(i);
                    button2.Text = "-";
                    button2.Location = new Point(405 + width, 587 + height);
                    button2.Visible = true;
                    button2.TextAlign = ContentAlignment.MiddleCenter;
                    button2.Size = new Size(18, 18);
                    button2.Font = new Font("Arial", 9, FontStyle.Bold);
                    button2.Click += new EventHandler(button2_Click);
                    Controls.Add(button2);

                    var lbl3 = new Label();
                    labels3[i] = lbl3;
                    lbl3.Name = Convert.ToString(("lbl2_" + i));
                    lbl3.Text = "0";
                    lbl3.Location = new Point(425 + width, 578 + height);
                    lbl3.Font = new Font("Arial", 10, FontStyle.Bold);
                    lbl3.AutoSize = false;
                    lbl3.Size = new Size(25, 25);
                    lbl3.Visible = true;
                    Controls.Add(lbl3);

                    var picture = new PictureBox();
                    pic[i] = picture;
                    picture.Image = Image.FromFile(@"C:\Users\12349\Desktop\2praktinis_failai\mobilieji_irenginiai\" + prekiu_sarasas[i].preke_paveikslelis + ".jpg");
                    picture.Location = new Point(150 + width, 250 + height);
                    picture.Name = Convert.ToString(("pic_") + i);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Size = new Size(300, 300);
                    Controls.Add(picture);

                    width = width + 600;
                }
                else
                {

                    var lbl = new Label();
                    labels[i] = lbl;
                    lbl.Name = Convert.ToString(("lbl_" + i));
                    lbl.Text = prekiu_sarasas[i].preke_gamintojas + " " + prekiu_sarasas[i].preke_modelis;
                    lbl.Location = new Point(240 + width, 210 + height);
                    lbl.Font = new Font("Arial", 16, FontStyle.Bold);
                    lbl.AutoSize = false;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.AutoSize = false;
                    lbl.Size = new Size(250, 35);
                    lbl.Visible = true;
                    Controls.Add(lbl);

                    var lbl2 = new Label();
                    labels2[i] = lbl2;
                    lbl2.Name = Convert.ToString(("lbl2_" + i));
                    lbl2.Text = prekiu_sarasas[i].preke_garantijos_instrukcija + "\nGarantija galioja iki: " + prekiu_sarasas[i].preke_garantijos_galiojimo_laiko_baigimo_data;
                    lbl2.Location = new Point(450 + width, 350 + height);
                    lbl2.Font = new Font("Arial", 9, FontStyle.Bold);
                    lbl2.AutoSize = false;
                    lbl2.Size = new Size(125, 250);
                    lbl2.Visible = true;
                    Controls.Add(lbl2);

                    Button button = new Button();
                    button.Name = Convert.ToString(i);
                    button.Text = "Užsakyti";
                    button.Location = new Point(245 + width, 570 + height);
                    button.Size = new Size(100, 35);
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Arial", 10, FontStyle.Bold);
                    button.Visible = true;
                    button.Click += new EventHandler(button_Click);
                    Controls.Add(button);

                    Button button1 = new Button();
                    button1.Name = Convert.ToString(i);
                    button1.Text = "+";
                    button1.Location = new Point(350 + width, 570 + height);
                    button1.Visible = true;
                    button1.TextAlign = ContentAlignment.MiddleCenter;
                    button1.Size = new Size(17, 17);
                    button1.Font = new Font("Arial", 9, FontStyle.Bold);
                    button1.Click += new EventHandler(button1_Click);
                    Controls.Add(button1);

                    Button button2 = new Button();
                    button2.Name = Convert.ToString(i);
                    button2.Text = "-";
                    button2.Location = new Point(350 + width, 587 + height);
                    button2.Visible = true;
                    button2.TextAlign = ContentAlignment.MiddleCenter;
                    button2.Size = new Size(18, 18);
                    button2.Font = new Font("Arial", 9, FontStyle.Bold);
                    button2.Click += new EventHandler(button2_Click);
                    Controls.Add(button2);

                    var lbl3 = new Label();
                    labels3[i] = lbl3;
                    lbl3.Name = Convert.ToString(("lbl2_" + i));
                    lbl3.Text = "0";
                    lbl3.Location = new Point(370 + width, 578 + height);
                    lbl3.Font = new Font("Arial", 10, FontStyle.Bold);
                    lbl3.AutoSize = false;
                    lbl3.Size = new Size(25, 25);
                    lbl3.Visible = true;
                    Controls.Add(lbl3);

                    var picture = new PictureBox();
                    pic[i] = picture;
                    picture.Image = Image.FromFile(@"C:\Users\12349\Desktop\2praktinis_failai\mobilieji_irenginiai\" + prekiu_sarasas[i].preke_paveikslelis + ".jpg");
                    picture.Location = new Point(150 + width, 250 + height);
                    picture.Name = Convert.ToString(("pic_") + i);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Size = new Size(300, 300);
                    Controls.Add(picture);
                    height = height + 450;
                    width = 0;
                }
                j++;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            prekes.set_prekiu_sarasas();
            List<preke> prekiu_sarasas = prekes.get_prekiu_sarasas();
            Button btn = sender as Button;
            string name = prekiu_sarasas[Convert.ToInt32(btn.Name)].preke_gamintojas + " " + prekiu_sarasas[Convert.ToInt32(btn.Name)].preke_modelis;
            double kaina = prekiu_sarasas[Convert.ToInt32(btn.Name)].preke_kaina;
            int dabartinis = Convert.ToInt32(labels3[Convert.ToInt32(btn.Name)].Text);
            if (dabartinis > 0)
            {
                krepseliosarasas.Add(new Krepselis(name, kaina, dabartinis));
                krepseliocountnumber++;
                labels3[Convert.ToInt32(btn.Name)].Text = "0";
            }
            countnumber = 0;
            label3.Text = krepseliocountnumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int count = Convert.ToInt32(labels3[Convert.ToInt32(btn.Name)].Text);
            count++;
            labels3[Convert.ToInt32(btn.Name)].Text = count.ToString();
            countnumber = count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int count = Convert.ToInt32(labels3[Convert.ToInt32(btn.Name)].Text);
            if (count > 0)
            {
                count--;
                countnumber = count;
            }
            labels3[Convert.ToInt32(btn.Name)].Text = count.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace koleksiyonkullaniciform0712
{
    public partial class Form3 : Form
    {

        //public List<string> musteriler = new List<string>();

        public List<Musteriler> musteriler = new List<Musteriler>();


        //Ana ekrandan ne geliyosa Form3 ekranında o var
        public Form3(List<Musteriler> must)
        {
            InitializeComponent();
            this.musteriler = must;

            //Form2 deki musteriler1 burdaki musteriler de
            //Form3 te girdiğin tümbilgiler Form2 ye gidiyor
            //Form4 listeleme <-- bütün müşteriler listelenecek

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler c = new Musteriler();
            c.Name = textBox1.Text;
            c.Surname = textBox2.Text;
            c.Telefon = textBox3.Text;
            c.Tarih = Convert.ToDateTime(dttxt.Text);
            c.Il = comboBox1.SelectedItem.ToString();
            c.Ilce = comboBox2.SelectedItem.ToString();
            c.Il2 = comboBox3.SelectedItem.ToString();
            c.Ilce2 = comboBox4.SelectedItem.ToString();

            musteriler.Add(c);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dttxt.Clear();

            textBox1.Select();
        }

        string[] IstIlceler = { "Kadıköy", "Sancaktepe", "Üsküdar", "Beşiktaş", "Fatih" };
        string[] AnkaraIlceler = { "Akyurt", "Altındağ", "Ayaş", "Balâ", "Beypazarı" };
        string[] TokatIlceler = { "Almus", "Turhal", "Zile", "Niksar", "Erbaa" };
        string[] SivasIlceler = { "Suşehri", "Yıldızeli", "Kangal", "Zara", "Gürün" };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (comboBox1.SelectedIndex == 0)
                    comboBox2.Items.Add(IstIlceler[i]);

                else if (comboBox1.SelectedIndex == 1)
                    comboBox2.Items.Add(AnkaraIlceler[i]);
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (comboBox3.SelectedIndex == 0)
                    comboBox4.Items.Add(TokatIlceler[i]);

                else if (comboBox3.SelectedIndex == 1)
                    comboBox4.Items.Add(SivasIlceler[i]);
            }
        }
    }
}

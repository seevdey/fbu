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
    public partial class Form4 : Form
    {
        public Form4(List<Musteriler> must)
        {
            InitializeComponent();
            this.musteriler = must;
        }

        //public List<string> musteriler = new List<string>();
        List<Musteriler> musteriler = new List<Musteriler>() { };

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (Musteriler mm in musteriler)
            {
                string[] satir = { mm.Name, mm.Surname, mm.Telefon, mm.Tarih.ToString(), mm.Il + "," + mm.Ilce, mm.Il2 + "," + mm.Ilce2 };
                ListViewItem item = new ListViewItem(satir);
                listView1.Items.Add(item);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            var musteriler2 = from o in musteriler
                              where o.Tarih.Year < int.Parse(textBox1.Text)
                              select o;


            foreach (Musteriler mm in musteriler2)
            {
                string[] satir = {mm.Name, mm.Surname, mm.Telefon, mm.Tarih.ToString(), mm.Il + "," + mm.Ilce, mm.Il2 + "," + mm.Ilce2 };
                ListViewItem item = new ListViewItem(satir);
                listView1.Items.Add(item);

            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //if (e.NewValue == CheckState.Checked)
            //{
            //    listView1.Items.Add(checkedListBox1.SelectedItem.ToString());
            //}
            //else
            //{
            //    //listView1.Items.Remove(checkedListBox1.SelectedItem.ToString());

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            var musteriler2 = from o in musteriler
                              where o.Il == comboBox1.Text && o.Ilce == comboBox2.Text || o.Il2 == comboBox1.Text && o.Ilce2 == comboBox2.Text
                              select o;


            foreach (Musteriler mm in musteriler2)
            {
                string[] satir = { mm.Name, mm.Surname, mm.Telefon, mm.Tarih.ToString(), mm.Il +","+ mm.Ilce, mm.Il2 +","+ mm.Ilce2 };
                ListViewItem item = new ListViewItem(satir);
                listView1.Items.Add(item);

            }


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

                else if (comboBox1.SelectedIndex == 2)
                    comboBox2.Items.Add(TokatIlceler[i]);

                else if (comboBox1.SelectedIndex == 3)
                    comboBox2.Items.Add(SivasIlceler[i]);
            }
        }
    }
}

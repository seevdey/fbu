using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek2211
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int baslangic, bitis;


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();

            baslangic = Convert.ToInt32(textBox1.Text);
            bitis = Convert.ToInt32(textBox2.Text);

            int[] baslangicdizi = new int[baslangic];
            int[] bitisdizi = new int[bitis];

            listBox1.Items.Add("5 e Bölünebilenler Listesi");


            for (int i = baslangicdizi.Length; i < bitisdizi.Length; i++)
            {
                if (i % 5 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("5 e Bölünebilen 7 ' ye Bölünemeyenler Listesi");


            baslangic = Convert.ToInt32(textBox1.Text);
            bitis = Convert.ToInt32(textBox2.Text);

            int[] baslangicdizi = new int[baslangic];
            int[] bitisdizi = new int[bitis];


            for (int i = baslangicdizi.Length; i < bitisdizi.Length; i++)
            {
                if (i % 5 == 0 && i % 7 != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            int val2;

            int txt2 = Convert.ToInt32(textBox2.Text);

            if (!Int32.TryParse(textBox2.Text, out val2) || txt2 < 0)
            {
                textBox2.Select();
                textBox2.Clear();
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int val;

            int txt1 = Convert.ToInt32(textBox1.Text);

            if (!Int32.TryParse(textBox1.Text, out val) || txt1 < 0)
            {
                textBox1.Select();
                textBox1.Clear();

            }
        }

        
    }
}

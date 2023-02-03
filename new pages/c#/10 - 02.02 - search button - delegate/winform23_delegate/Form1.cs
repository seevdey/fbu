using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform23_delegate
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.postaci += new Form2.Postaci(gelenVeri);
            frm2.Show();
            textBox1.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            button2.Location = new Point(290, 243);

        }
        string post1;
        string post2;
        public void gelenVeri(object sender)
        {
           post1 = sender.ToString();
            textBox1.Text = post1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.postaci2 += new Form3.YeniPostaci(gelenVeri2);

            f3.Show();
        }

        public void gelenVeri2(object sender)
        {
            post2 = sender.ToString();
        }

        private void yazdir(string a, string b)
        {
            textBox1.Text = a + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yazdir(post1,post2);
        }
    }
}

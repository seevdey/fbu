using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koleksiyonkullaniciform0712
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string skulladi = "admin";
        string ssifre = "123";

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == skulladi && textBox2.Text == ssifre)
            {
                Form2 form2 = new Form2();
                form2.WindowState = FormWindowState.Maximized; //form ekranı full açılsın
                form2.Show();
                this.Hide(); //kendi ekranımı gizliyorum
            }
            else
                MessageBox.Show("Kullanıcı giriş bilgileri hatalıdır");


            //Müşteri listesi 1 kere açılsın daha açılmasın
        }
    }
}

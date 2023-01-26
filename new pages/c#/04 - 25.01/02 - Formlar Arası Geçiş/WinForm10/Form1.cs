using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm10
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32( txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);


            Form2 frm2 = new Form2(sayi1, sayi2);
            
            frm2.Show();
            this.Hide();

        }
    }
}

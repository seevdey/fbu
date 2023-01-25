using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm09
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
            string deger = textBox1.Text;
            Form2 frm2 = new Form2(deger);
            frm2.Show();
            this.Hide();

            /*
             * Show() ve ShowDialog() Arasındaki Fark
             * Açılan formdan diğer forma geçişe izin verilecekse .Show() eğer izin verilmeyecekse .ShowDialog() kullanırız.
             * Show formu açar. (Diğer forma geçilebilir)
             * ShowDialog --> Yaplan işlemden sonra kapanıp diğer ekranın açılması gerekir
                showdialog ise diğer forma geçişi engeller.
                    
            */

            //Form1 den iki sayısal değer girilsin Form2 de cevap yazsın
        }
    }
}

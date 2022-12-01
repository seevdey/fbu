using oop3form0112.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop3form0112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void degistirbtn_Click(object sender, EventArgs e)
        {
            using (Oyuncu o1 = new Oyuncu()) //parametresiz nesne oluşturunca parametresiz metot çalışacak
            {
                //label8.Text = o1.BilgiVer(this);
            }

            using (Oyuncu o2 = new Oyuncu(textBox1.Text, textBox3.Text, textBox2.Text))//parametreli nesne oluşturunca parametreli metot çalışacak
            {
                label8.Text = o2.BilgiVer(this);

                o2.takimdegistir("Gs", this);
                yenilbl.Text = o2.BilgiVer(this);
            }
        }
    }
}

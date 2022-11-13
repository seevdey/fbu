using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            //sınav notunu giriniz
            //100-85 ise A
            //80-70 ise B
            //70-55 ise C
            //55-45 ise D
            //45< ise F

            byte not;
            not = Convert.ToByte(nottxt.Text);
            sonuclbl.Show();
            sonuclbl.Text = (not <= 100 && not >= 85) ? "A - Geçtiniz" :
                          (not < 85 && not >= 70) ? "B - Geçtiniz" :
                          (not < 70 && not >= 55) ? "C - Geçtiniz" :
                          (not < 55 && not >= 45) ? "D - Kaldınız" : "F - Kaldınız";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

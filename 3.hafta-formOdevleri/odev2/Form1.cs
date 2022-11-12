using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen bir sayı eğer 5-10 arasında ise girilen sayının karesini alıp gösteren, eğer 5’ten küçük ise faktöriyelini alan, 10’dan büyük ise sayıyı 2’ye bölüp bir eksiğini yazan algoritma

            int sayi = Convert.ToInt32(sayitxt.Text);
            int sonuc = 0;

            if (sayi >= 5 && sayi <= 10)
            {
                sonuclbl.Text = Convert.ToString(sayi * sayi);
            }
            else if (sayi > 10)
            {
                sonuc = (sayi / 2) - 1;
                sonuclbl.Text = Convert.ToString(sonuc);

            }
            else if (sayi < 5){

                int faktoriyel = 1;
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel *= i;
                }
                sonuclbl.Text = Convert.ToString(faktoriyel);
            }
            
        }

        private void sayitxt_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(sayitxt.Text, out int val))
            {
                sayitxt.Clear();
                sayitxt.Select();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            //girilen sayıyı ikilik tabana çevirme
            string sayi = Convert.ToString(sayitxt.Text);
            string sonuc = " ";
            int sayi2 = int.Parse(sayi);

            for (; sayi2 > 0; sayi2/=2)
            {
                sonuc = sayi2 % 2 + sonuc; //sonucu başa yazarsan 10 un karşılığı 1010 yerin 0101 yazdırır
            }
            sonuclbl.Text = $"{sonuc}";
        }
    }
}

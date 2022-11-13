using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //girilen sayının mükemmel sayı olup olmadığı kontrolü

            int toplam = 0;

            int sayi = Convert.ToInt32(sayitxt.Text);

            for (int sayac = 1; sayac < sayi; sayac++)
            {
                if (sayi % sayac == 0)
                {
                    toplam += sayac;
                }
            }
            
            if (sayi == toplam)
            {
                sonuclbl.Show();
                sonuclbl.Text = "Sayı mükemmel sayıdır";
                //sayitxt.Clear();
            }
            else
            {
                sonuclbl.Show();
                sonuclbl.Text = "Sayı mükemmel sayı değildir";
                //sayitxt.Clear();
            }


        }

        private void sonuclbl_Click(object sender, EventArgs e)
        {

        }
    }
}

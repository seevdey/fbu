using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL den fazla ise, 
            //2. üründen %25 indirim yaparak ödenecek tutarı gösteren uygulama

            //

            int fiyat1 = Convert.ToInt32(urun1txt.Text);
            int fiyat2 = Convert.ToInt32(urun2txt.Text);

            if ((fiyat1+fiyat2) >= 200)
            {
                fiyat2 = fiyat2 - ((fiyat2 * 25) / 100);
                sonuclbl.Text = $"{fiyat1 + fiyat2}";
            }
            else
            {
                sonuclbl.Text = $"{fiyat1 + fiyat2}";
            }

        }
    }
}

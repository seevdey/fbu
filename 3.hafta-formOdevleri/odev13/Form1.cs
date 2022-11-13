using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para birimi 1.USD, 2. EURO, 3-STERLIN, 4.TL
            //Para miktarı
            //Kur
            //Dönüşecek para birimi
            //Sonuç

            //1 para birimi için 3 farklı kur var

            float usd = 0.0f;
            float euro = 0.0f;
            float sterlin = 0.0f;
            float tl = 0.0f;

            switch (parabirimicmbx.Text)
            {
                case "USD": //USD
                    euro = 15.3f;
                    sterlin = 15.4f;
                    tl = 11.8f;
                    break;
                case "EURO"://EURO
                    usd = 20.2f;
                    sterlin = 13.9f;
                    tl = 14.5f;
                    break;
                case "STERLIN"://STERLIN
                    usd = 15.1f;
                    euro = 16.76f;
                    tl = 15.3f;
                    break;
                case "TL"://TL
                    usd = 12.9f;
                    euro = 16.3f;
                    sterlin = 13.8f;
                    break;
                default:
                    break;
            }

            float miktar = Convert.ToSingle(paratxt.Text);
            float sonuc = 0;

            switch (dparabirimicmbx.Text)
            {
                case "USD":
                    sonuc = miktar / usd;
                    sonuclbl.Text = $"{sonuc}";
                    break;
                case "DOLAR":
                    sonuc = miktar / euro;
                    sonuclbl.Text = $"{sonuc}";
                    break;
                case "STERLIN":
                    sonuc = miktar / sterlin;
                    sonuclbl.Text = $"{sonuc}";
                    break;
                case "TL":
                    sonuc = miktar / tl;
                    sonuclbl.Text = $"{sonuc}";
                    break;
                default:
                    break;
            }
        }

        private void parabirimicmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

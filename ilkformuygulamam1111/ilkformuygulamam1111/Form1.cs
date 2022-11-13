using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilkformuygulamam1111
{
    //Form 1 class ı
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //benim mouse ile oluşturduğum şey hazır larak gelen
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(sayi1txt.Text);
            int sayi2 = int.Parse(sayi2txt.Text);

            switch (islemtipcmbx.Text)
            {
                case "Toplama":
                    int toplama = sayi1 + sayi2;
                    sonuclbl.Text = toplama.ToString();
                    break;
                case "Çıkarma":
                    int cikarma = sayi1 - sayi2;
                    sonuclbl.Text = cikarma.ToString();
                    break;
                case "Çarpma":
                    int carpma = sayi1 * sayi2;
                    sonuclbl.Text = carpma.ToString();
                    break;
                case "Bölme":
                    int bolme = sayi1 / sayi2;
                    sonuclbl.Text = bolme.ToString();
                    break;
                default:
                    break;
            }
        }

        //leave 
        //event lar anlık olay
        //TextBox ı kaydettiğin yerin event ı

        private void sayi1txt_Leave(object sender, EventArgs e)
        {
           
            if (!Int32.TryParse(sayi1txt.Text, out int c)){
                sayi1txt.Select();
                sayi1txt.Clear();
            }
        }

        private void sayi2txt_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(sayi2txt.Text, out int val))
            {
                sayi2txt.Select();
                sayi2txt.Clear();
            }
        }
    }
}

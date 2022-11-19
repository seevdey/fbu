using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdiziler
{
    public partial class Form1 : Form
    {
        //ÖDEV
        //1 ile 1000 arasında 5 e bölünebilen sayıların listesi ve adedi
        //5 e bölünebilen 7 ye bölünemeyen sayıların listesi ve adetleri 

        public Form1()
        {
            InitializeComponent();
        }

        int buyuk = 0, kucuk = 0;
        int sayacf = 0, sayacd = 0, sayacc = 0;
        int boyut = 3;

        #region geçti kaldı örneği

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;

        }

        private void nothesaplabtn_Click(object sender, EventArgs e)
        {
            //Notları girdi soru sorsun sınıftaki en yüksek mi en düşük notu mu getirmek istiyorsun?
            //yüksek seçerse en yükseği, düşük seçerse en düşük not görünsün

            listBox1.Items.Add($"{sayacf / 6} kişi F aldı");
            listBox1.Items.Add($"{sayacd / 6} kişi D aldı");
            listBox1.Items.Add($"{sayacc / 6} kişi C aldı");
        }

        int sayac = 0;   

        private void eklebtn_Click(object sender, EventArgs e)
        {

            string[] not = new string[boyut * 2];
            int x = boyut * 2;

            for (int i = 0; i < x; i += 2)
            {
                string adi = isimtxt.Text;
                not[i] = adi;

                string not2 = isimtxt.Text;
                not[i + 1] = not2;
            }

            int val;

            foreach (string s in not)
            {
                if (Int32.TryParse(s, out val)) //girilen değerin int e dönüşüp dönüşmediğini kontrol ediyoruz
                {
                    if (int.Parse(s) < 45)
                        sayacf++;

                    else if (int.Parse(s) >= 45 && int.Parse(s) < 55)
                        sayacd++;

                    else if (int.Parse(s) >= 55 && int.Parse(s) < 65)
                        sayacc++;
                }
            }

            sayac++;

            isimtxt.Clear();

            if (sayac % 2 == 0)
                isimlbl.Text = "İsim giriniz : ";

            else
                isimlbl.Text = "Not giriniz : ";

            if (sayac == 6)
            {
                isimtxt.Enabled = false;
                eklebtn.Enabled = false;
            }
        }

        #endregion

        #region Yüksek-Düşük Not Bulma Örneği

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

        }

        private void yuksekbtn_Click(object sender, EventArgs e)
        {
            yukseklbl.Visible = true;
            yukseklbl2.Visible = true;

            dusuklbl.Visible = false;
            dusuklbl2.Visible = false;

            yukseklbl.Text = $"{buyuk}";
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dusukbtn_Click(object sender, EventArgs e)
        {
            dusuklbl.Visible = true;
            dusuklbl2.Visible = true;

            yukseklbl.Visible = false;
            yukseklbl2.Visible = false;

            dusuklbl.Text = $"{kucuk}";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void eklebtn2_Click(object sender, EventArgs e)
        {
            string[] not = new string[boyut * 2];
            int x = boyut * 2;

            for (int i = 0; i < x; i += 2)
            {
                string adi = nottxt.Text;
                not[i] = adi;

                string not2 = nottxt.Text;
                not[i + 1] = not2;
            }


            for (int j = 0; j < x; j += 2)
            {
                int sayi = int.Parse(not[j + 1]);

                if (j == 0)
                {
                    buyuk = sayi;
                    kucuk = sayi;
                }

                if (sayi > buyuk)
                    buyuk = sayi;

                if (sayi < kucuk)
                    kucuk = sayi;
            }

            sayac++;

            nottxt.Clear();

            if (sayac % 2 == 0)
                notlbl.Text = "İsim giriniz : ";

            else
                notlbl.Text = "Not giriniz : ";

            if (sayac == 6)
            {
                nottxt.Enabled = false;
                eklebtn2.Enabled = false;
            }
        }

        #endregion

        #region 1 ile 1000 arasında 5 e bölünebilen sayıların listesi ve adedi

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;


        }

        private void hesaplabtn3_Click(object sender, EventArgs e)
        {
            short sayac = 0;
            int [] dizi  = new int[60];


            for (short i = 1; i < dizi.Length; i++)
            {
                if (i % 5 == 0)
                {
                    dizi[i] = i;
                    listbox2.Items.Add(dizi[i]);
                    sayac++;
                }
            }
            adetlbl.Text = $"{sayac}";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 5 e bölünebilen 7 ye bölünemeyen sayıların listesi ve adetleri 

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
        }

        

        private void hesaplabtn4_Click(object sender, EventArgs e)
        {
            int sayac2 = 0;

            int[] dizi2 = new int[60];

            for (int i = 1; i < dizi2.Length; i++)
            {
                if (i % 5 == 0 && i % 7 != 0)
                {
                    dizi2[i] = i;
                    listBox3.Items.Add(i);
                    sayac2++;
                }
            }

            adetlbl4.Text = $"{sayac2}";
        }

        

        #endregion

        #region kullanıcı girişi faz-1

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;

        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            string[,] kullanici_ismi = new string[,] { { "0", "user", "pass" }, { "1", "usern", "passw" } };

            int boyut = 1;
            string[] dizi = new string[boyut * 2];
            int x = boyut * 2;

            for (int i = 0; i < x; i += 2)
            {
                string kadi = kaditxt.Text;
                dizi[i] = kadi;

                string sifre = sifretxt.Text;
                dizi[i + 1] = sifre;
            }


            bool isFound = false;

            for (int i = 0; i < kullanici_ismi.GetLength(0); i += 2) //satır
            {
                for (int j = 0; j < kullanici_ismi.GetLength(0); j += 2)
                {
                    if (dizi[i] == kullanici_ismi[i, j + 1] && dizi[i + 1] == kullanici_ismi[i, j + 2])
                    {
                        MessageBox.Show("Kullanıcı girişi başarılı");
                        isFound = true;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı girişi başarısız");
                        yenigirislbl.Visible = true;
                        evetbtn.Visible = true;
                        hayirbtn.Visible = true;
                        kaditxt.Enabled = false;
                        sifretxt.Enabled = false;
                    }
                }
            }

            kaditxt.Clear();
            sifretxt.Clear();
        }

        private void evetbtn_Click(object sender, EventArgs e)
        {
            // Restart current application, with same arguments/parameters
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        private void hayirbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion
    }
}

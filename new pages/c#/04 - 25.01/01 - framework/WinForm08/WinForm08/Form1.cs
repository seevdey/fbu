using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matematik;

namespace WinForm08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //constant
            //const : sabit demek

            //DDL --> Dynamic-link library
            //Math sınıfı, işlemi tekrar yürütmesi için static olarak tanımlanır

            //Sınıf static olarak tanımlanabilir. Örnek; Math sınıfı

            /*
                Main metodu, hep static olarak tanımlanmıştır. 
                Bunun sebebi şudur, Uygulama başlatıldığında, henüz sınıflardan herhangi bir 
                obje oluşturulmadığında, Main metodu uygulamanın, programın yürütülmesini sağlamak
                için çağırılmaktadır. Main metodu aslında uygulamanın giriş metodudur. 
                Böylelikle yani main metodunu static olarak oluşturarak, herhangi bir sınıftan 
                örnek yani instance almadan programın yürütmesini sağlayabilmemiz amaçlanır.  
            */

            //Math.Pow(3, 2);

            //References --> Add References --> Matematik

            //using Matematik;
            //DortIslem d = new DortIslem();

            //double sonuc = DortIslem.Toplam(5, 6);
            //MessageBox.Show(sonuc.ToString()); //11

            ////DDl dosyaları ve Frameworkler doğrudan çalıştırılamazlar.Benim UI tarafına ihtiyacım var
            ////Burda Matematik DLL ini doğrudan çalıştıramazsın

            //double sonuc2 = DortIslem.Cikarma(10, 5);
            //MessageBox.Show(sonuc2.ToString()); //5

            //double sonuc3 = DortIslem.Carpma(10, 5);
            //MessageBox.Show(sonuc3.ToString()); //50

            //double sonuc4 = DortIslem.Bolme(10, 5);
            //MessageBox.Show(sonuc4.ToString()); //2

        }

       
        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);

            lblSonuc.Text = DortIslem.Toplam(sayi1, sayi2).ToString();
            Temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);

            lblSonuc.Text = DortIslem.Cikarma(sayi1, sayi2).ToString();
            Temizle();
        }

        private void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) //çarpma
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);

            lblSonuc.Text = DortIslem.Carpma(sayi1, sayi2).ToString();
            Temizle();
        }

        private void button4_Click(object sender, EventArgs e) //bölme
        {
            double sayi1 = Convert.ToDouble(txtSayi1.Text);
            double sayi2 = Convert.ToDouble(txtSayi2.Text);

            double sonuc = DortIslem.Bolme(sayi1, sayi2);

            if (sonuc == 0)
            {
                lblSonuc.Text = "Sayı tanımsız";
            }
            else
            {
                lblSonuc.Text = sonuc.ToString();
            }
            Temizle();
        }
    }
}

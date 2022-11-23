using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userpassteacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //iki boyutlu dizi tanımladık
        //2 satır 3 sütun
        //2 adet kullanıcı tanımlanabilir

        string[,] kullanicilar = new string[2, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
            //Uygulama ekrana yüklendiğinde çalışan bölüm
            kaydetbtn.Visible = false;
            listBox1.Visible = false;
        }

        //yeni kullanıcı girişi
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            onaylabtn.Visible = false;
            kaydetbtn.Visible = true;
            listBox1.Visible = false;
        }

        //kullanıcı dizisine kaydetme işlemi yaptım

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            int kulid = 0;
            //kullanıcı dizisinin içinin boş olup olmadığını kontrol ettim

            for (int i = 0; i < kullanicilar.GetLength(0); i++)
            {
                if (kullanicilar[i, 0] != null) //kullanici id null dan farlıysa yani boş değilse idizde kayıt var mı diye kontrol ediyoruz
                    kulid = int.Parse(kullanicilar[i, 0]); //kullanıcı id ye ata
            }
            if (kulid == 0)
            {
                kullanicilar[0, 0] = "1";
                kullanicilar[0, 1] = textBox1.Text;
                kullanicilar[0, 2] = textBox2.Text;
            }

            else if (kulid == 1)
            {
                kullanicilar[kulid, 0] = (kulid+1).ToString();
                kullanicilar[kulid, 1] = textBox1.Text;
                kullanicilar[kulid, 2] = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Tanımlanabilir kullanıcı sayısını aştınız!!!");
                kaydetbtn.Visible = false;
                onaylabtn.Visible = true;
                return; //bundan sonrası çalışmayacak.
                //kodun devam etmesini istemiyorsak return koyarız.
                //return tamamen durduruyor

                //break --> döngüden çıkıp devam ediyor
            }

            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Select();
            MessageBox.Show("KAyıt Başarılı Oldu");
            kaydetbtn.Visible = false;
            onaylabtn.Visible = true;
            linkLabel1.Visible = false;
        }

        //Giriş onayla butonu

        private void onaylabtn_Click(object sender, EventArgs e)
        {
            bool buldumu = false;
            for (int i = 0; i < kullanicilar.GetLength(0); i++) //2 satırı alıyor
            {
                if (kullanicilar[i,1] == textBox1.Text && kullanicilar[i,2] == textBox2.Text)
                {
                    buldumu = true;
                    MessageBox.Show("Geçerli Kullanıcı");
                    break;
                }
            }

            if (!buldumu)//true
            {
                MessageBox.Show("Böyle bir kullanıcı yoktur");
                linkLabel1.Visible = true; //Yeni kayıtı true yaptık
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.Add("Kullanıcı Adı" + "\t" + "Şifresi");
            listBox1.Items.Add("--------------------------------");
            for (int i = 0; i < kullanicilar.GetLength(0); i++)
            {
                if (kullanicilar[i,0] != null)
                {
                    listBox1.Items.Add(kullanicilar[i, 1] + "\t\t" + kullanicilar[i, 2]);
                }
            }
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace koleksiyonogrenciform061
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Formda öğrenci adı, öğrencinin soyadı ve numarası
        //3 alana göre max 2 öğrenci girebiliyosun. Sonrasında hata al
        //ogrenci diye arraylist oluştur içinde ad soyad no var 

        ArrayList ogrenci = new ArrayList();

        private void eklebtn_Click(object sender, EventArgs e)
        {

       
            if (ogrenci.Count < 7)
            {
                listBox1.Items.Clear();

                ogrenci.Add(adtxt.Text);
                ogrenci.Add(soyadtxt.Text);
                ogrenci.Add(notxt.Text);

                adtxt.Clear();
                soyadtxt.Clear();
                notxt.Clear();
            }
            else
            {
                adtxt.Clear();
                soyadtxt.Clear();
                notxt.Clear();
                MessageBox.Show("2 adetten fazla öğrenci girilemez !");

            }

            if (ogrenci.Count < 7)
            {
                listBox1.Items.Add("ÖĞRENCİ BİLGİLERİ");
                listBox1.Items.Add("Adı \t Soyad \t  Numara");

                for (int i = 0; i < ogrenci.Count; i+=3)
                {
                    listBox1.Items.Add(string.Format("{0} \t {1} \t  {2} \t", ogrenci[i], ogrenci[i + 1], ogrenci[i + 2]));
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ÖĞRENCİ BİLGİLERİ");
            listBox1.Items.Add("Adı \t Soyad \t  Numara" );

            for (int i = 0; i < ogrenci.Count; i+=3)
            {
                listBox1.Items.Add(string.Format("{0} \t  {1} \t {2} \t", ogrenci[i], ogrenci[i+1], ogrenci[i+2]));
            }
        }
    }
}

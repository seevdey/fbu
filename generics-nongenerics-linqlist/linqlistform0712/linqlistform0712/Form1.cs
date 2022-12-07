using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqlistform0712
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Ogrenci
        {
            public string Adi;
            public DateTime DogumTarihi;
            public int Numarasi;

            public Ogrenci(string adi, DateTime dogumTarihi, int numara)
            {
                Adi = adi;
                DogumTarihi = dogumTarihi;
                Numarasi = numara;
            }

            public Ogrenci()
            {
                Adi = "deneme";
                DogumTarihi = Convert.ToDateTime("09.03.2000");
                Numarasi = 1000;
            }

        }

        List<Ogrenci> ogrenciler = new List<Ogrenci>() { };

        private void listelebtn_Click(object sender, EventArgs e)
        {

            //Ogrenci o0 = new Ogrenci();
            //Ogrenci o1 = new Ogrenci(adtxt.Text, monthCalendar1.SelectionStart, int.Parse(numaratxt.Text));
            //Ogrenci o2 = new Ogrenci(adtxt.Text, monthCalendar1.SelectionStart, int.Parse(numaratxt.Text));
            //Ogrenci o3 = new Ogrenci(adtxt.Text, monthCalendar1.SelectionStart, int.Parse(numaratxt.Text));
            //Ogrenci o4 = new Ogrenci(adtxt.Text, monthCalendar1.SelectionStart, int.Parse(numaratxt.Text));


            var sorgu = from o in ogrenciler
                        where o.DogumTarihi.Year < 1999
                        select o.Adi + " / " + o.Numarasi.ToString() + " / " + o.DogumTarihi.Year;

            listBox1.Items.Add("--------Tüm öğrencileriniz-------");
            foreach (Ogrenci o in ogrenciler)
                listBox1.Items.Add(o.Adi + " / " + o.Numarasi.ToString() + " / " + o.DogumTarihi.Year);


            listBox1.Items.Add("-------Doğum tarihi 99 dan küçük olan öğrencileriniz---");
            foreach (var o in sorgu)
                listBox1.Items.Add(o);
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                string vad = adtxt.Text;
                int vno = int.Parse(numaratxt.Text);
                DateTime vv = Convert.ToDateTime(dttxt.Text);

                Ogrenci o3 = new Ogrenci(vad, vv, vno);
                ogrenciler.Add(o3);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop8formabstract0512
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public abstract class Kisi
        {
           
            public String AdSoyad; 
            public abstract string Meslek
            {
                get;
            }
            public virtual void Yaz(Form1 formnesnesi)
            {
                formnesnesi.listBox1.Items.Add("Adı Soyadı : " + AdSoyad);
                formnesnesi.listBox1.Items.Add("Mesleği : " + Meslek);
            }
        }

        public class Ogrenci : Kisi
        {
            public int Sınıf;
            public override string Meslek
            {
                get { return "Öğrenci"; }
            }

            public virtual void Yaz(Form1 formnesnesi)
            {
                formnesnesi.listBox1.Items.Add("ÖĞRENCİ\n");
                formnesnesi.listBox1.Items.Add("Adı Soyadı : " + AdSoyad);
                formnesnesi.listBox1.Items.Add("Mesleği : " + Meslek);
                formnesnesi.listBox1.Items.Add("Sınıfı : " + Sınıf);
            }
        }

        public class Ogretmen : Kisi
        {
            public string Brans;
            public override string Meslek
            {
                get { return "Öğretmen"; }
            }

            public virtual void Yaz(Form1 formnesnesi)
            {
                formnesnesi.listBox1.Items.Add("ÖĞRETMEN\n");
                formnesnesi.listBox1.Items.Add("Adı Soyadı : " + AdSoyad);
                formnesnesi.listBox1.Items.Add("Mesleği : " + Meslek);
                formnesnesi.listBox1.Items.Add("Branş : " + Brans);
            }
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.AdSoyad = adtxt.Text;
                ogrenci.Sınıf = int.Parse(siniftxt.Text);
                ogrenci.Yaz(this);
            }
            else if (radioButton2.Checked)
            {
                Ogretmen ogretmen = new Ogretmen();
                ogretmen.Brans = branstxt.Text;
                ogretmen.AdSoyad = adtxt.Text;
                ogretmen.Yaz(this);
            }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            branstxt.Visible = false;
            branslbl.Visible = false;
            siniftxt.Visible = true;
            soyadlbl.Visible = true;

            adtxt.Clear();
            branstxt.Clear();
            siniftxt.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            branstxt.Visible = true;
            branslbl.Visible = true;
            siniftxt.Visible = false;
            soyadlbl.Visible = false;

            adtxt.Clear();
            branstxt.Clear();
            siniftxt.Clear();

        }

        private void listelebtn2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

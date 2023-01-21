using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Projeyi çalıştırdığım anda ne çalıştırmak istersem onu yazıyorum
            //Çalışma anında karşıma çıkmasını istediğim bir yer
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            k.KitapAdi = txtKitapAdi.Text;
            k.Yazar = txtYazar.Text;
            k.ISBN = txtISBN.Text;
            k.Tur = txtTur.Text;
            k.Yayinevi = txtYayinevi.Text;
            k.YayinTarihi = dateTimePicker1.Value;
            //k.SayfaSayisi = (int)numericUpDown1.Value;
            k.SayfaSayisi = Convert.ToInt32(numericUpDown1.Value);

            //büyük tipten küçük tipe giderken cast i kullanabilirsin
            //küçük tipten yukarı giderken dikkatli ol

            lstKitaplar.Items.Add(k.ToString());
            
            Temizle();
            //Sınıflar özelleşmiş koleksiyonlardır
        }

        private void Temizle()
        {
            //txtKitapAdi.Clear();
            //txtYazar.Clear();
            //txtISBN.Clear();
            //txtTur.Clear();
            //txtYayinevi.Clear();
            //dateTimePicker1.ResetText();
            //numericUpDown1.ResetText();

            foreach (var item in this.Controls) //tüm hepsine item diyorum
            {
                if (item is TextBox) //bu item lardan TextBox olanlar için
                {
                    //tip karşılama önemli bir şey
                    TextBox txt = (TextBox)item;//gelen şeylerin Textbox tipinde olduğunu belirt

                    txt.Clear();
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    //dtp.ResetText();
                    dtp.Value = DateTime.Now;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nu = (NumericUpDown)item;
                    nu.Value = numericUpDown1.Value;
                }
            }
        }
    }
}

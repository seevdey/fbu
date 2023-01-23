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
        private void Form1_Load(object sender, EventArgs e)
        {
            // Projenin çalıştığı anda bir şey olmasını istemiyorsak Form_Load a bir şey yazmıyoruz.
            // Proje çalıştığında karşımıza çıkmasını istediğimiz bir şey varsa onu Form_Load  içinde yazıyoruz.

            //Projeyi çalıştırdığım anda ne çalıştırmak istersem onu yazıyorum
            //Çalışma anında karşıma çıkmasını istediğim bir yer

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap k = new Kitap();
            k.KitapAdi = txtKitapAdi.Text;
            k.Yazar = txtYazar.Text;
            k.ISBN = txtISBN.Text;
            k.Turu = txtTuru.Text;
            k.YayinEvi = txtYayinEvi.Text;
            k.YayinTarihi = dateTimePicker.Value;
            //k.SayfaSayisi = ((int)numericUpDown.Value);
            k.SayfaSayisi = Convert.ToInt32(numericUpDown.Value);

            //büyük tipten küçük tipe giderken cast i kullanabilirsin
            //küçük tipten yukarı giderken dikkatli ol

            lstKitaplar.Items.Add(k);

            Temizle();
            //Sınıflar özelleşmiş koleksiyonlardır
        }

        private void Temizle()
        {
            // UZUN YÖNTEM

            //txtKitapAdi.Clear();
            //txtYazar.Clear();
            //txtISBN.Clear();
            //txtTuru.Clear();
            //txtYayinEvi.Clear();
            //dateTimePicker.ResetText();
            ////dateTimePicker.Value = DateTime.Now;
            //numericUpDown.ResetText();
            ////numericUpDown.Value = 0;

            foreach (var item in this.Controls) //tüm hepsine item diyorum
            {
                if (item is TextBox) //bu item lardan TextBox olanlar için
                {
                    //tip karşılama önemli bir şey
                    TextBox txt = (TextBox)item; //gelen şeylerin Textbox tipinde olduğunu belirt
                    txt.Clear();
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    // dtp.ResetText();
                    dtp.Value = DateTime.Now;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nu = (NumericUpDown)item;
                    nu.Value = 0;
                }
            }
        }
        //Hem liste, hem arraylist yerine kullanılabilir
        Kitap secili;
        private void lstKitaplar_DoubleClick(object sender, EventArgs e)
        {
            //SelectedItem --> seçili olan nesneler
            secili = (Kitap)lstKitaplar.SelectedItem; // sadece Kitap modelime ait olanları aldık
            // yoksa listbox kendi bilgileri de gelir

            txtKitapAdi.Text = secili.KitapAdi; //Collection dan kitap adı geldi
            txtYazar.Text = secili.Yazar;
            txtISBN.Text = secili.ISBN;
            txtTuru.Text = secili.Turu;
            txtYayinEvi.Text = secili.YayinEvi;
            dateTimePicker.Value = secili.YayinTarihi;
            numericUpDown.Value = secili.SayfaSayisi;
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            //Eski indexteki datayı uçurup yerine yeni datayı eklemem gerek
            //Remove, RemoveAt  --> Entity tipinde kabul ederken diğeri index tipinde kabul ediyor

            if (lstKitaplar.SelectedIndex != -1)
            {
                txtKitapAdi.Text = secili.KitapAdi;
                txtYazar.Text = secili.Yazar;
                txtISBN.Text = secili.ISBN;
                txtTuru.Text = secili.Turu;
                txtYayinEvi.Text = secili.YayinEvi;
                dateTimePicker.Value = secili.YayinTarihi;
                numericUpDown.Value = secili.SayfaSayisi;

                int index = lstKitaplar.SelectedIndex;
                lstKitaplar.Items.RemoveAt(index);
                lstKitaplar.Items.Insert(index, secili);

                //Add diyine bir sonraya ekler.
                //aynı indexe ekleyebilmek için Insert e ihtiyacım var
                Temizle();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedIndex != -1)
            {
                int index = lstKitaplar.SelectedIndex;
                lstKitaplar.Items.RemoveAt(index);

                Temizle();
                MessageBox.Show("Kayıt silindi");
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız");
            }
        }

        //sil olayını double click ten ayır 
        //sadece click içinde 
        //seçili bir nesne olması gerekiyor
    }
}

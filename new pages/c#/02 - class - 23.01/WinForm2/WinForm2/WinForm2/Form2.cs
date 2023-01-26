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
    public partial class Form2 : Form
    {
        public Form2()
        {
            //Form2 yüklendiğinde
            InitializeComponent(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = btnsil.Enabled = false;
        }


        //TabIndex için : formdaki tüm elemanları seç --> View --> TabOrder
        //MultiSelect true olmaması lazım

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun yeni = new Urun();
            //Bunlar RAM de tutuluyor. Sürekli bu yüzden yeni nesne tanımlamıyorum
            //kullandığın textlere vs modele bu bilgileri aktarmış oldum
            //Bunlar her tipi barındırabilen diziler
            yeni.UrunKodu = txtUrunKodu.Text;
            yeni.UrunAdi = txtUrunAdi.Text;
            yeni.Fiyati = nuFiyati.Value;
            yeni.StokMiktari = (int)nuStok.Value;
            yeni.UretimTarihi = dateTimePicker1.Value;
            yeni.GarantiSuresi = (int)nuGaranti.Value;

            //kolon bilgisi var ve o kolon bilgisine göre datayı girmem gerekiyor
            //hangi kolona hangi datanın geleceğine dikkat etmem gerekiyor
            //kolon başlıklarına dikkat et

            //burda tanım yaparken soldan sağa girmen gerekiyor
            string[] satirBilgisi = { yeni.UrunKodu, yeni.UrunAdi, yeni.Fiyati.ToString(), yeni.StokMiktari.ToString(), yeni.UretimTarihi.ToString(), yeni.GarantiSuresi.ToString() };

            //List tanımlarsam sınırı belli olmaz
            //Bu component için geliştirilmiş <-- ListViewItem
            //ListViewItem dizi bilgisi istiyor(key value mantığında bu eşleştirmeyi yapıyor)
            ListViewItem lvi = new ListViewItem(satirBilgisi); //içerde string bir dizi istiyor
            //satır bilgisi gönder

            //Tag -> datayla birlikte bunları eşleştirmesini sağlıyor
            lvi.Tag = yeni; //header ve satır arasındaki birleşmeyi sağlayacak
            lstUrunListesi.Items.Add(lvi); //dataları ona göre Initialize et ona göre satırları doldur
            //İlgili kolonun ilgili satırına datayı bas
            Temizle();

            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnsil.Enabled = true;
        }


        //event kullanırken dikkat et
        //bir eventta bir işlem olmalı <-- SOLID prensipi 1. kural
        private void lstUrunListesi_DoubleClick(object sender, EventArgs e)
        {
            secili = (Urun)lstUrunListesi.SelectedItems[0].Tag; //içinde ürün tipinde olanları istiyorum
            //bu işlemler mapping oluyor
            //ürün sınıfından diğer taraftan gelen nesneyle map ettik

            txtUrunKodu.Text = secili.UrunAdi;
            txtUrunAdi.Text = secili.UrunKodu;
            nuFiyati.Value = secili.Fiyati;
            nuStok.Value = secili.StokMiktari;
            dateTimePicker1.Value = secili.UretimTarihi;
            nuGaranti.Value = secili.GarantiSuresi;
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
                else if (item is DateTimePicker)
                {
                    DateTimePicker datetime = (DateTimePicker)item;
                    datetime.Value = DateTime.Now;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nupdown = (NumericUpDown)item;
                    nupdown.Value = 0;
                }

                //else if (item is ListView)
                //{
                //    ListView lvw = (ListView)item;
                //    lvw.SelectedItems.Clear();
                //}
            }
        }

        //full row selected true yapıyoruz --> tüm satırı seç

        Urun secili;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secili.UrunKodu = txtUrunKodu.Text;
            secili.UrunAdi = txtUrunAdi.Text;
            secili.Fiyati = nuFiyati.Value;
            secili.StokMiktari = (int)nuStok.Value;
            secili.UretimTarihi = dateTimePicker1.Value;
            secili.GarantiSuresi = (int)nuGaranti.Value;

            string[] satirBilgisi = { secili.UrunKodu, secili.UrunAdi, secili.Fiyati.ToString(), secili.StokMiktari.ToString(), secili.UretimTarihi.ToString(), secili.GarantiSuresi.ToString() };

            ListViewItem lvi = new ListViewItem(satirBilgisi);
            lvi.Tag = secili;

            int index = lstUrunListesi.SelectedItems[0].Index;
            lstUrunListesi.Items.RemoveAt(index);
            lstUrunListesi.Items.Insert(index, lvi);
            Temizle();
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = lstUrunListesi.Enabled = false;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (lstUrunListesi.Items.Count > 0) // listView1.SelectedItems[0].Index != -1
            {
                int index = lstUrunListesi.SelectedItems[0].Index;
                lstUrunListesi.Items.RemoveAt(index);
                Temizle();
                MessageBox.Show("Ürün silindii");
                btnKaydet.Enabled = true;
                btnGuncelle.Enabled = btnsil.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçiniz");
            }

        }

        private void lstUrunListesi_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
            btnGuncelle.Enabled = true;
            btnsil.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm01.Classes;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //yazdığın kodu mantık sırasına göre düzenle
        private void Form1_Load(object sender, EventArgs e)
        {
            //string isim = "Ahmet";

            //object o = isim; //boxing

            ////cast tip dönüşümü
            //string isim2 = (string)o; //unboxing

            Insan i = new Insan();
            i.Isim = "  sevde    ";
            i.SacRengi = Color.Red;

            //i.Boy = 3.5;
            //MessageBox.Show(i.Boy.ToString());
            //i.Kilo = 10;
            //MessageBox.Show(i.Kilo.ToString());

            //MessageBox.Show(i.Isim);
            //MessageBox.Show(i.SacRengi.ToString());
            //MessageBox içine string bir şey ister değer farklı tipteyse ToString() kullan

            //CTRL + SHIFT + B --> derle

            Telefon t = new Telefon();
            t.Marka = "Samsung";
            t.Model = "S22";
            t.KamerasiVarMi = true;
            t.Agirlik = 168;
            t.EkranBoyutu = 6.5m;
            t.Renk = Color.Pink;
            t.TusSayisi = 12;

            //MessageBox.Show(t.Marka + "-" + t.Model);
            //MessageBox.Show(t.Isim);

            //Ondalıklı sayıların default tipi double dır
            //m double ı temsil eder
            //Default ondalıklı sayı tipi double dır
            //float tipinde olursa f eklemen gerekiyor


            //Form1.Design ve burdaki buton aynı şey değil
            
            //Load tetiklendiği anda tetiklenecek buton
            Button btn = new Button();
            btn.BackColor= Color.YellowGreen;
            btn.Location = new Point(200, 200);
            btn.Size = new Size(100,100);
            btn.Text = "Cansu";

            this.Controls.Add(btn); //form1 e butonu ekliyoruz

            //kendi eventhandlerını çağırabilirsin, metod çağırabilirsin
            //btn.Click += Btn_Click; 

            //başka bir eventı tetiklemek
            //btn.Click += new EventHandler(button1_Click);

            //farklı bir metod tanımlamak
            btn.Click += new EventHandler(MesajGonder);


            //Urun u = new Urun();
            //u.UrunAdi = "atmaca";
            //u.UrunKodu = "777";
            //u.Stok = 666;
            //u.Fiyat = 34;
            //u.SatisiDevamEdiyorMu = false;
            //u.Kategori = "katgori";
            //u.UretimTarihi = DateTime.Now;
            //u.Sat();
            //u.Agirlik = 5.5;
            

            //Siparis s = new Siparis();
            //s.SiparisKodu = "123";
            //s.SiparisTarihi = DateTime.Now;
            //s.Adres = "Giresun";
            //s.Urunler = {u.UrunAdi}, { u.UrunKodu};
            //MessageBox.Show(s.ToplamUrunSayisi.ToString());
        
        }

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MesajGonder(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop9interfaceform0512
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface IAracOzellikleri
        {
            //Yemeğin malzemeleri - malzeme listesi
            //Yani ihtiyaçlar
            string Marka { get; } //Sen marka ve modele değer atamazsın dışardan. Yani marka ve model tanımlı
            string Model { get; } //Yani model tanımlı

            int Hız { get; set; } //Arabanın hızıyla oynarım bu yüzden get set kullandım. Değiştirilebilir
            int Fiyat { get; set; }
            int Gosterge(int deger);

            void Bilgiler(Form1 formnesnesi);

        }

        public interface IAracPuan
        {
            double AracPuani(double puan);
        }

        public class Mercedes : IAracOzellikleri
        {
            public string marka;

            public string Marka
            {
                //interface tanımında ne varsa class ta onu kullanmakla yükümlüyüz
                //Bu özellikte sadece get olduğu için classta yazarken sadece get kullandık
                get
                {
                    return "Mercedes";
                }
                
            }

            public string Model
            {
                get
                {
                    return "C Serisi";
                }
            }

            private int hiz;

            public int Hız
            {
                get { return hiz; }
                set { hiz = value; }
            }

            private int fiyat;

            public int Fiyat
            {
                get { return fiyat; }
                set { fiyat = value; }
            }


            public void Bilgiler(Form1 formnesnesi)
            {
                formnesnesi.listBox1.Items.Add($"Marka : {Marka} \nModel : {Model} \nFiyat : {Fiyat} \nHız : {Hız} \nGösterge : {Gosterge(300)}");
            }

            public int Gosterge(int deger)
            {
                return (deger + 50);
            }

          
        }

        public class Bmw : IAracOzellikleri, IAracPuan
        {
            public string marka = "";
            public string model = "3.40";
            private int hiz;
            private int fiyat;

            public string Marka { get { return marka; } }

            public string Model { get { return model; } }

            public int Hız
            {
                get { return hiz; }
                set { hiz = value; }
            }

            public int Fiyat
            {
                get { return fiyat; }
                set { fiyat = value; }

                //istediğim gibi değiştirebilmek için get  set tanımladım
            }

            //get-set kullanmamın sebebi iş kuralı tanımlayabilmek

            //public void Bilgiler(Form1 formnesnesi)
            //{
            //    formnesnesi.listBox1.Items.Add($"Marka : {Marka} \nModel : {Model} \nFiyat : {Fiyat} \nHız : {Hız} \nGösterge : {Gosterge(300)} \nPuan : {AracPuani(2000)}");
            //}


            public double AracPuani(double puan)
            {
                return puan * 3.6;
            }

            public int Gosterge(int deger)
            {
                return deger;
            }

            public void Bilgiler(Form1 formnesnesi)
            {
                formnesnesi.listBox1.Items.Add($"Marka : {Marka} \nModel : {Model} \nFiyat : {Fiyat} \nHız : {Hız} \nGösterge : {Gosterge(300)} \nPuan : {AracPuani(2000)}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Mercedes mm = new Mercedes();
                mm.Fiyat = int.Parse(textBox1.Text);
                mm.Hız = int.Parse(textBox2.Text);
                mm.marka = radioButton1.Text;
                mm.Bilgiler(this);
            }


            else if (radioButton2.Checked)
            {
                Bmw bmw = new Bmw();
                bmw.Fiyat = int.Parse(textBox1.Text);
                bmw.Hız = int.Parse(textBox2.Text);
                bmw.marka = radioButton2.Text;
                bmw.Bilgiler(this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}

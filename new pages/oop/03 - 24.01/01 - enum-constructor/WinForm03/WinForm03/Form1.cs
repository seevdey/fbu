using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //doğrudan parametresiz constructor sınıf oluştuğu anda kullanılır

            Ayakkabi a = new Ayakkabi();
            a.Tipi = Tip.Bot;
            a.Cinsiyeti = Cinsiyet.Erkek;
            a.Malzemesi = Malzeme.Deri;

            //MessageBox.Show(a.AyakkabiNo.ToString());

            Ayakkabi a2 = new Ayakkabi(42, Tip.SporAyakkabi);
            //MessageBox.Show(a2.AyakkabiNo.ToString());

            Bebek b = new Bebek();
            MessageBox.Show(b.DogumTarihi.ToString());

            //nesne tanımlarken using kullanırsan son satıra gelince hafızadan silinir.
            
            /*
             * 24.01
                Internal +
                Enum +
                Constructor +
                Desctructor +
                using + 
                GC
                Inheritance +
                Overloading +
                Override +
                void + 
                Methods
                Abstract + 
                Sealed +
                Virtual + 
                Polimorfizm + (hem kalıtım hem overriding) KediSesi, KopekSesi
            */
        }
    }
}

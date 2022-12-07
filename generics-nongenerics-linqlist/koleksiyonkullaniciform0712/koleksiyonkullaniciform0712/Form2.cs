using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koleksiyonkullaniciform0712
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //müşteri girişi, ana ekran
        //IsMdiContainer true yap ekrandan çıkmaması için

        public List<string> musteriler1 = new List<string>();
        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(musteriler1); //bütün ekranlar bunun içinde olacak
            //müşteriye eklediğin kaydı müşteri 
            form3.MdiParent = this; //MdiParent in Form2. this derken Form2 yi kastetiyor
            form3.Show();
        }

        private void müşteriListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(musteriler1);
            form4.MdiParent = this;
            form4.Show();
        }

        //buna benzer bir uygulama 
        //linq ekle, search ekle
        //99 dan küçük olanlar gelsin
        //listede arama yap form4 te
    }
}

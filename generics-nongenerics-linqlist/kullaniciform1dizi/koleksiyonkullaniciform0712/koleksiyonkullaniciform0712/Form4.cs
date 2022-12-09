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
    public partial class Form4 : Form
    {
        public Form4(List<string> must)
        {
            InitializeComponent();
            this.musteriler = must;
        }

        public List<string> musteriler = new List<string>();

        private void Form4_Load(object sender, EventArgs e)
        {
            int y = 0;
            //gelen müşteriler listesini listview e doldurmam lazım
            for (int i = 0; i < musteriler.Count()/3; i++) //her 3 tanesi 1 kayıt olacak
            {
                string ad, soyad, tel;
                ad = musteriler[i+y];
                soyad = musteriler[i+y+1];
                tel = musteriler[i+y+2];
                y = y + 2; //bloğu kaydır

                string[] satir = { ad, soyad, tel }; //üçünü satır yap
                ListViewItem item = new ListViewItem(satir);
                listView1.Items.Add(item);
            }
        }
    }
}

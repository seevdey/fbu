using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UrunBilgisi()
        {
            //ürün bligisi bunun içinde
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        //Form1 den güncellenecek veya eklenecek veriyi göndweriyorum
        private void Form1_Load(object sender, EventArgs e)
        {
             //metotla gönderiyorum
            UrunBilgisi();
            listBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.UrunEkle += new Form2.UrunEkleEventHandler(UrunBilgisi);
            frm2.Show();

        }

        //menustrip guncelle
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form2 frm2 = new Form2((DataRowView)listBox1.SelectedItem, "Güncelle"); //constructor da DataRowView tipinde olduğu için burda cast ettik
                frm2.UrunGuncelle += new Form2.UrunGuncelleEventHandler(UrunBilgisi);
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Sanki bir şey seçmen gerekiyor ama sen bilirsin");
            }

        }

        //menustrip sil
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Form2 frm2 = new Form2((DataRowView)listBox1.SelectedItem, "Sil");
                frm2.UrunSil += new Form2.UrunSilEventHandler(UrunBilgisi);
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Sanki bir şey seçmen gerekiyor ama sen bilirsin");
            }

        }
    }
}

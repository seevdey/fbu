using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TelRehberiDBEntities db = new TelRehberiDBEntities();
        private void btnGetir_Click(object sender, EventArgs e)
        {
            KisileriGetir();
        }

        private void KisileriGetir()
        {
            //bu şekilde yazdığımızda kolonlara istediğimiz ismi vermiş oluyoruz
            dataGridView1.DataSource = db.Kisiler.Select(k => new
            {
                KisiId = k.KisiId,
                KisiAdi = k.KisiAdi,
                KisiSoyadi = k.KisiSoyadi,
                TelefonNo = k.TelNo
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //1.YOL
            ////Boş olması lazım çünkü yeni kayıt oluşturacağım
            //Kisiler k = new Kisiler();
            //k.KisiAdi = txtAd.Text;
            //k.KisiSoyadi = txtSoyad.Text;
            //k.TelNo = txtTelefon.Text;

            ////Model datayı üstüne alır ama veritabanına yollamadık
            //db.Kisiler.Add(k);

            ////db.SaveChanges ile veri tabanına kaydeder
            //db.SaveChanges();


            //2.YOL
            //Kisiler k = new Kisiler
            //{
            //    KisiAdi = txtAd.Text,
            //    KisiSoyadi = txtSoyad.Text,
            //    TelNo = txtTelefon.Text

            //};
            //db.Kisiler.Add(k);
            //db.SaveChanges();


            //3.YOL
            db.Kisiler.Add(new Kisiler
            {
                KisiAdi = txtAd.Text,
                KisiSoyadi = txtSoyad.Text,
                TelNo = txtTelefon.Text
            });
            db.SaveChanges();

            KisileriGetir();
            Temizle();
        }


        private void Temizle()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox )
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        Kisiler guncellenecek;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = db.Kisiler.Find(id);

                txtAd.Text = guncellenecek.KisiAdi;
                txtSoyad.Text = guncellenecek.KisiSoyadi;
                txtTelefon.Text = guncellenecek.TelNo;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncellenecek.KisiAdi = txtAd.Text;
            guncellenecek.KisiSoyadi = txtSoyad.Text;
            guncellenecek.TelNo = txtTelefon.Text;

            //Modelde değişiklik yaparsan db.SaveChanges demen yeterli
            db.SaveChanges();

            KisileriGetir();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //db.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            db.Kisiler.Remove(db.Kisiler.Find(id));

            db.SaveChanges();
            KisileriGetir();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Contains --> içeren
            //StarstWith --> başlayan 
            dataGridView1.DataSource = db.Kisiler.Where(k => k.KisiAdi.StartsWith(textBox1.Text) || k.KisiSoyadi.StartsWith(textBox1.Text)).ToList();

            //k => k.KisiAdi.StartsWith(textBox1.Text) >>> başlayan ifadeler 'metin%'
            //k => k.KisiAdi.Contains(textBox1.Text) >>> içeren ifadeler '%metin%'
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

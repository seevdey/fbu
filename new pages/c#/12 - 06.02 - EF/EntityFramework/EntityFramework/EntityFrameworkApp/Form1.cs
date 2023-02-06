using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TelRehberDBEntities db = new TelRehberDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            KisileriGetir();
        }

        // ctrl r+m ile bu kod kısmını method olarak oluşturduk
        private void KisileriGetir()
        {
            dataGridView1.DataSource = db.Kisilers.Select(k => new
            {
                // datagridviewdaki kolonlara isim de verdi, sol taraftakiler kolon ismi.
                KisiId = k.KisiId, // güncelleme için id bilgisi lazım o yüzden ekledik ama
                // datagridviewda görünmesini engelledik
                KisiAdi = k.KisiAdi,
                KisiSoyadi = k.KisiSoyadi,
                TelefonNo = k.TelNo

            }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // yeni kayıt doldurucağımız için boş instance lazım btnGetirdeki gibi dolu değil
                Kisiler k = new Kisiler();
                k.KisiAdi = txtAd.Text;
                k.KisiSoyadi = txtSoyad.Text;
                k.TelNo = txtTelefon.Text;
                db.Kisilers.Add(k); // model bu datayı üstüne alır ama veritabanına göndermez,
                                    // bu bilgi şurda modele aktarıldı, modelde değişiklik yapıldı ama veritabanına aktarılmadı.

                if (db.Kisilers != null)
                {
                    db.SaveChanges();// veritabanına aktarılması için kaydet diyoruz yoksa göndermez
                    KisileriGetir();
                    Temizle();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    guncellenecek.KisiAdi = txtAd.Text;
                    guncellenecek.KisiSoyadi = txtSoyad.Text;
                    guncellenecek.TelNo = txtTelefon.Text;

                    db.SaveChanges();
                    KisileriGetir();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Güncellenicek kayıt seçiniz");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata");
            }

        }
        Kisiler guncellenecek;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // double click event'inde e.rowindex diyince geliyor
            // burda sadece butonun argumentlarına erişiyor o yüzden e.rowindex erişilemiyor

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                guncellenecek = db.Kisilers.Find(id);

                txtAd.Text = guncellenecek.KisiAdi;
                txtSoyad.Text = guncellenecek.KisiSoyadi;
                txtTelefon.Text = guncellenecek.TelNo;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            if(id > 0)
            {
                db.Kisilers.Remove(db.Kisilers.Find(id));

                db.SaveChanges();
                KisileriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silinecek kayıt seçiniz");
            }

        }
    }
}

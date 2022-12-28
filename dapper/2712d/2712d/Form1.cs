using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace _2712d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection SqlCon = new SqlConnection(@"Data Source=216-03\SQLEXPRESS;Initial Catalog=Musteriler;User ID=sa; Password=Fbu123456");
        int id = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FillDataGridView()
        {
            //dapper kullanmamızın en büyük sebebi DynamicParameters sınıfını kullanabilmek
            //hiç sql kodu yok tamamen security
            DynamicParameters param = new DynamicParameters();
            param.Add("@Aramametni", searchtxt.Text.Trim());
            List<MusteriBilgileri> list = SqlCon.Query<MusteriBilgileri>("MusteriArama", param, commandType: CommandType.StoredProcedure).ToList();
            dgvmusteri.DataSource = list;
            dgvmusteri.Columns[0].Visible = false; //id yi kimsenin görmesine ihtiyaç yok bu yüzden kapattım
            dgvmusteri.Columns[3].Visible = false; //sil sütununu kapattım

        }

        void Clear()
        {
            adtxt.Clear();
            soyadtxt.Clear();
            adrestxt.Clear();
            id = 0;
            btnsave.Text = "Kaydet";
            btndelete.Enabled = false;
        }


        class MusteriBilgileri
        {
            //buradaki isimler veritabanı ile aynı olmak zorunda
            public int id { get; set; }
            public string Adı { get; set; }
            public string Soyadı { get; set; }
            public bool sil { get; set; }
            public string Adres { get; set; }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                param.Add("@Adı", adtxt.Text.Trim());
                param.Add("@Soyadı", soyadtxt.Text.Trim());
                param.Add("@sil", false);
                param.Add("@Adress", adrestxt.Text.Trim());
                SqlCon.Execute("MusteriEkleveDuzenle", param, commandType: CommandType.StoredProcedure);
                if (id==0)
                {
                    toolStripStatusLabel1.Text = "Yeni kayıt oldu";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Güncelleme oldu";

                }
                FillDataGridView();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally //ne olursa olsun son blok çalışsın
            {
                SqlCon.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                {
                    SqlCon.Open();
                }
                DynamicParameters param = new DynamicParameters();
                param.Add("@id", id);
                SqlCon.Execute("MusteriSilYeni", param, commandType: CommandType.StoredProcedure);

                FillDataGridView();
                toolStripStatusLabel1.Text = "Silme başarılı oldu";
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally //ne olursa olsun son blok çalışsın
            {
                SqlCon.Close();
            }
        }

        private void dgvmusteri_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvmusteri.CurrentRow.Index != -1 ) //farklı ise seçildi demektir
                {
                    id = int.Parse(dgvmusteri.CurrentRow.Cells[0].Value.ToString());
                    adtxt.Text = dgvmusteri.CurrentRow.Cells[1].Value.ToString();
                    soyadtxt.Text = dgvmusteri.CurrentRow.Cells[2].Value.ToString();
                    //3 te sil var
                    adrestxt.Text = dgvmusteri.CurrentRow.Cells[4].Value.ToString();
                    btndelete.Enabled = true;
                    btnsave.Text = "Düzenle";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Form1_Load(this, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            //silinende de arama yapıyoruz
            param.Add("@Aramametni", searchtxt.Text.Trim());
            List<MusteriBilgileri> list = SqlCon.Query<MusteriBilgileri>("MusteriAramaSil", param, commandType: CommandType.StoredProcedure).ToList();
            dgvmusteri.DataSource = list;
            dgvmusteri.Columns[0].Visible = false; 
            dgvmusteri.Columns[3].Visible = false;

        }
    }
}

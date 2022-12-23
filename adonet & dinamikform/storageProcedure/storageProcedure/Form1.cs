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

namespace storageProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string baglantiCumlesi = "Data Source=216-03\\SQLEXPRESS;Initial Catalog=Northwind;User ID=sa; Password=Fbu123456";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region Veri Listeleme

                string komut = "";
                komut = "select * from Customers";

                //önce veri tabanına bağlanıyorum
                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = baglantiCumlesi;
                    using (SqlCommand listelemekomut = new SqlCommand(komut, baglanti)) //içerde ayriyeten bir şey olmayacağı için sorguda sadece tablo çektiğimiz için parametre olarak komut ve baglantiyi verdik
                    {
                        baglanti.Open();
                        using (DataTable datatablosu = new DataTable())
                        {
                            //tablo oluşturma
                            datatablosu.Columns.Add("Müşteri Adı");
                            datatablosu.Columns.Add("Firma Adı");
                            datatablosu.Columns.Add("Yetkili Kişi");
                            datatablosu.Columns.Add("Ülkesi");

                            using (SqlDataReader okuyucu = listelemekomut.ExecuteReader())
                            {
                                while (okuyucu.Read()) //döngüyle okuyucunun içinde okuyabildiğim sürece döncem. Okumayı satır satır yapacağım ve bunun için geçici satır oluşturacağım
                                {
                                    //DataRow sınıfını kullanmamam gerekiyor. Ben burda datatablosunu kullanıyorum
                                    //datatablosundan yeni bir satırı DataRow'a al
                                    //tablodaki satırları kendi satırlarımla değerleri eşitlemiş oldum
                                    DataRow row = datatablosu.NewRow();
                                    row["Müşteri Adı"] = okuyucu["CustomerID"];
                                    row["Firma Adı"] = okuyucu["CompanyName"];
                                    row["Yetkili Kişi"] = okuyucu["ContactName"];
                                    row["Ülkesi"] = okuyucu["Country"];
                                    datatablosu.Rows.Add(row);
                                    //okuyucuyu satır bazında oku rowa eşitle sağdakini sola atıyorsun. bu rowu gel atatablosundaki her satırı ekle
                                    //okuyucudaki bilgiyi data tablosuna ekledim
                                }

                                dataGridView1.DataSource = datatablosu;
                            }
                        }
                        baglanti.Close();
                    }

                    //connectiondan sonra bağlantı açık mı değil mi kontrol etmem gerekiyor


                  

                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //herhangi bir sql sorgusu yok. %100 security

            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş kayıt yapılamaz!!!");
                textBox1.Select();
                return;
            }

            using (SqlConnection cn = new SqlConnection(baglantiCumlesi))
            {
                //benimprosedurum --> sql de oluşturduğum procedure ün ismi
                using (SqlCommand cmd = new SqlCommand("benimprosedurum", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@CustomerID1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@CompanyName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ContactName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Country", textBox4.Text);
                    cn.Open(); //bağlantı açma
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            Form1_Load(this, null);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e) //UPDATE
        {
            //if (textBox1.Text == "")
            //{
            //    MessageBox.Show("Boş kayıt yapılamaz!!!");
            //    textBox1.Select();
            //    return;
            //}

            using (SqlConnection cn = new SqlConnection(baglantiCumlesi))
            {
                //benimprosedurum --> sql de oluşturduğum procedure ün ismi
                using (SqlCommand cmd = new SqlCommand("benimprosedurum", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Update");
                    cmd.Parameters.AddWithValue("@CustomerID1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@CompanyName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ContactName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Country", textBox4.Text);
                    cn.Open(); //bağlantı açma
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            Form1_Load(this, null);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button4_Click(object sender, EventArgs e) //DELETE
        {
            //if (textBox1.Text == "")
            //{
            //    MessageBox.Show("Boş kayıt yapılamaz!!!");
            //    textBox1.Select();
            //    return;
            //}

            using (SqlConnection cn = new SqlConnection(baglantiCumlesi))
            {
                //benimprosedurum --> sql de oluşturduğum procedure ün ismi
                using (SqlCommand cmd = new SqlCommand("benimprosedurum", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Delete");
                    cmd.Parameters.AddWithValue("@CustomerID1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@CompanyName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@ContactName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Country", textBox4.Text);
                    cn.Open(); //bağlantı açma
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            Form1_Load(this, null);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //hücre bazında 
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}

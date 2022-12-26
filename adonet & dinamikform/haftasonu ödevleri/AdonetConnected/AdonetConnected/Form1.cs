using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace AdonetConnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string baglantiCumlesi = "Data Source=SEVDE;Initial Catalog=Northwind;Integrated Security=True";

        //UserID = sa; Password=Fbu123456
        //integrated security () kullanıcı adı şifre yok. herkes benim  sistemime connected olabilir


        //ÖDEV -- professional indir. teams indir. öğren

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region Veri Listeleme
                string komut = "select * from Employees";

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
                            datatablosu.Columns.Add("PersonelKimlikNo");
                            datatablosu.Columns.Add("Adı");
                            datatablosu.Columns.Add("Soyadı");

                            using (SqlDataReader okuyucu = listelemekomut.ExecuteReader())
                            {
                                while (okuyucu.Read()) //döngüyle okuyucunun içinde okuyabildiğim sürece döncem. Okumayı satır satır yapacağım ve bunun için geçici satır oluşturacağım
                                {
                                    //DataRow sınıfını kullanmamam gerekiyor. Ben burda datatablosunu kullanıyorum
                                    //datatablosundan yeni bir satırı DataRow'a al
                                    //tablodaki satırları kendi satırlarımla değerleri eşitlemiş oldum
                                    DataRow row = datatablosu.NewRow();
                                    row["PersonelKimlikNo"] = okuyucu["EmployeeID"];
                                    row["Adı"] = okuyucu["FirstName"];
                                    row["Soyadı"] = okuyucu["LastName"];
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


                    if (baglanti.State == System.Data.ConnectionState.Closed)
                        toolStripStatusLabel1.Text = "Bağlantı Kapalı";
                    else
                        toolStripStatusLabel1.Text = "Bağlantı Açık";

                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * ADO çok hızlı
         * ADO nun kötü yanı security değil
         * ADO için hep valudation exception yazmak zorunda oluyorsun
         * Daha fazla kod yazmış oluyorsun ama Dopper a göre daha fazla
         * En az kodu Ef te yazıyorsun
         * En çok Security EF, tablo saysı arttıkça yavaşlıyor
         * Dopper, EF ve ADO nun ortası
         */

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                #region Veri Ekleme

                using(SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = baglantiCumlesi;
                    baglanti.Open();

                    using (SqlCommand eklekomut = new SqlCommand())
                    {
                        eklekomut.Connection= baglanti;
                        eklekomut.CommandType = CommandType.Text;
                        eklekomut.CommandText = "Insert into Employees(FirstName, LastName) values(@FirstName, @LastName)";
                        eklekomut.Parameters.AddWithValue("@FirstName", textBox1.Text);
                        eklekomut.Parameters.AddWithValue("@LastName", textBox2.Text);
                        bool karakter = false;

                        //Textbox a rakam atarsak hata verdirecek. charisLetter ile kontrol sağlıyoruz

                        for (int i = 0; i < (textBox1.Text).Length; i++)
                        {
                            if (char.IsLetter(Convert.ToChar((textBox1.Text).Substring(i, 1))))
                                karakter = true;
                            else
                            {
                                karakter = false;
                                break;
                            }
                        }
                        if (karakter)
                        {
                            eklekomut.ExecuteNonQuery();
                            MessageBox.Show("Kayıt başarılı");
                        }
                        else
                            MessageBox.Show("Kayıt olmadı çünkü adı alanında nümerik değer var");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Select();
                    }
                    baglanti.Close();
                }
                Form1_Load(this, null); //ekleme yaptıktan sonra dataGridView de ekleme yaptığım değeri görmek için  bunu yazıyorum


                //güncelle, sil, tüm liste ve ara butonlarını sen yap

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                #region Veri Güncelleme

                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = baglantiCumlesi;
                    baglanti.Open();

                    using (SqlCommand veriguncelleme = new SqlCommand())
                    {
                        veriguncelleme.Connection = baglanti;
                        veriguncelleme.CommandType = CommandType.Text;
                        veriguncelleme.CommandText = "update Employees set FirstName = @FirstName, LastName = @LastName where EmployeeID = @EmployeeID";

                        veriguncelleme.Parameters.AddWithValue("@FirstName", textBox1.Text);
                        veriguncelleme.Parameters.AddWithValue("@LastName", textBox2.Text);
                        veriguncelleme.Parameters.AddWithValue("@EmployeeID", textBox3.Text);

                        bool update = false;
                        bool update2 = false;
                        for (int i = 0; i < (textBox1.Text).Length; i++)
                        {
                            if (char.IsLetter(Convert.ToChar((textBox1.Text).Substring(i, 1))))
                                update = true;
                            else
                            {
                                update = false;
                                break;
                            }
                        }
                        for (int i = 0; i < (textBox2.Text).Length; i++)
                        {
                            if (char.IsLetter(Convert.ToChar((textBox2.Text).Substring(i, 1))))
                                update2 = true;
                            else
                            {
                                update2 = false;
                                break;
                            }
                        }
                        if (update && update2)
                        {
                            veriguncelleme.ExecuteNonQuery();
                            MessageBox.Show("Güncelleme Başarılı");
                        }
                        else
                            MessageBox.Show("Güncelleme Başarısız nümerik değer var");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox1.Select();

                    }
                    baglanti.Close();
                }
                Form1_Load(this, null);

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells["Adı"].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells["Soyadı"].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells["PersonelKimlikNo"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string command = "select * from deletedEmployees";
            //Burada silinen değerleri dataGridView de görüntülemek için önce tablo oluşturduk. Sonra trigger yazdık
            /*
             CREATE TABLE deletedEmployees 
            (
                EmployeeID int primary key identity(1,1) not null,
                LastName nvarchar(20) not null,
                FirstName nvarchar(10) not null,
            )
            go
            create Trigger deleteEmployee
            ON Employees
            AFTER DELETE 
            AS 
            set identity_insert deletedEmployees on;
            INSERT INTO deletedEmployees(EmployeeID, LastName, FirstName) 
            SELECT EmployeeID, LastName, FirstName FROM deleted
            */

            if (textBox1.Text != "")
            {
                try
                {
                    #region Veri Silme

                    using (SqlConnection baglanti = new SqlConnection())
                    {
                        using (SqlCommand verisilme = new SqlCommand())
                        {
                            baglanti.ConnectionString = baglantiCumlesi;
                            baglanti.Open();

                            verisilme.Connection = baglanti;
                            verisilme.CommandType = CommandType.Text;
                            verisilme.CommandText = "delete from Employees where EmployeeID = @EmployeeID";

                            verisilme.Parameters.AddWithValue("@EmployeeID", textBox3.Text);

                            verisilme.ExecuteNonQuery();

                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox1.Select();

                        }

                        using (SqlCommand listdelcommand = new SqlCommand(command, baglanti))
                        {
                            using (DataTable datatablosu = new DataTable())
                            {
                                datatablosu.Columns.Add("PersonelKimlikNo");
                                datatablosu.Columns.Add("Adı");
                                datatablosu.Columns.Add("Soyadı");

                                using (SqlDataReader okuyucu = listdelcommand.ExecuteReader())
                                {
                                    while (okuyucu.Read())
                                    {

                                        DataRow row = datatablosu.NewRow();
                                        row["PersonelKimlikNo"] = okuyucu["EmployeeID"];
                                        row["Adı"] = okuyucu["FirstName"];
                                        row["Soyadı"] = okuyucu["LastName"];
                                        datatablosu.Rows.Add(row);
                                    }

                                    dataGridView1.DataSource = datatablosu;
                                }
                            }
                        }

                        baglanti.Close();
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz satırı seçiniz");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                #region Tüm Liste
                string komut = "select * from Employees";

                //önce veri tabanına bağlanıyorum
                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = baglantiCumlesi;
                    using (SqlCommand listelemekomut = new SqlCommand(komut, baglanti)) 
                    {
                        baglanti.Open();
                        using (DataTable datatablosu = new DataTable())
                        {
                            datatablosu.Columns.Add("PersonelKimlikNo");
                            datatablosu.Columns.Add("Adı");
                            datatablosu.Columns.Add("Soyadı");

                            using (SqlDataReader okuyucu = listelemekomut.ExecuteReader())
                            {
                                while (okuyucu.Read()) 
                                {
                                    DataRow row = datatablosu.NewRow();
                                    row["PersonelKimlikNo"] = okuyucu["EmployeeID"];
                                    row["Adı"] = okuyucu["FirstName"];
                                    row["Soyadı"] = okuyucu["LastName"];
                                    datatablosu.Rows.Add(row);
                                   
                                }

                                dataGridView1.DataSource = datatablosu;
                            }
                        }
                        baglanti.Close();
                    }

                    if (baglanti.State == System.Data.ConnectionState.Closed)
                        toolStripStatusLabel1.Text = "Bağlantı Kapalı";
                    else
                        toolStripStatusLabel1.Text = "Bağlantı Açık";

                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        SqlDataReader dreader;
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                #region Veri Arama

                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = baglantiCumlesi;
                    baglanti.Open();

                    using (SqlCommand search = new SqlCommand())
                    {
                        search.Connection = baglanti;
                        search.CommandType = CommandType.Text;
                        search.CommandText = "select * from Employees where EmployeeID = @EmployeeID or FirstName = @FirstName or LastName = @LastName";
                        search.Parameters.AddWithValue("@FirstName", textBox1.Text);
                        search.Parameters.AddWithValue("@LastName", textBox2.Text);
                        search.Parameters.AddWithValue("@EmployeeID", textBox3.Text);

                        using (DataTable datatablosu = new DataTable())
                        {
                            datatablosu.Columns.Add("PersonelKimlikNo");
                            datatablosu.Columns.Add("Adı");
                            datatablosu.Columns.Add("Soyadı");

                            using (SqlDataReader okuyucu = search.ExecuteReader())
                            {
                                //if (okuyucu.Read())
                                //{

                                    while (okuyucu.Read())
                                    {
                                        DataRow row = datatablosu.NewRow();
                                        row["PersonelKimlikNo"] = okuyucu["EmployeeID"];
                                        row["Adı"] = okuyucu["FirstName"];
                                        row["Soyadı"] = okuyucu["LastName"];
                                        datatablosu.Rows.Add(row);

                                    }

                                    dataGridView1.DataSource = datatablosu;
                                //}
                                //else
                                //{
                                //    MessageBox.Show("Böyle bir kayıt yok");
                                //}
                            }
                        }
                        search.ExecuteNonQuery();
                       
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Select();
                    }
                    baglanti.Close();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

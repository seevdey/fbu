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

namespace WinForm19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //MultipleActiveResultSets Örneği

        //MultipleActiveResultSets --> default ta false olarak gelir
        //Birden fazla şeyi açıp kapatmak için MultipleActiveResultSets e ihtiyacın var


        //DataReader bir bağlantıda 1 tane DataReader çalışır

        SqlConnection conn = new SqlConnection("Server = SEVDE; Database=Northwind;Trusted_Connection=true; MultipleActiveResultSets = true");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu1 = "select CategoryName, Description from Categories";
            string sorgu2 = "select ProductName, UnitPrice, UnitsInStock from Products";

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                MessageBox.Show("İşlem Başarılı");
            }
            else
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Insert-Connected
        {
            string sorgu1 = "select CategoryName, Description from Categories";
            string sorgu2 = "insert Categories (CategoryName, Description) values (@catName, @desc)";

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            cmd2.Parameters.AddWithValue("@catName", textBox1.Text);
            cmd2.Parameters.AddWithValue("@desc", textBox2.Text);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd2.ExecuteNonQuery();

                SqlDataReader dr = cmd1.ExecuteReader();
                DataTable dt = new DataTable();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //DataRow row = dt.NewRow();
                        //row["Kategori Adı"] = dr["@catName"];
                        //row["Açıklama"] = dr["@desc"];
                        //dt.Rows.Add(row);
                    }

                    dt.Load(dr); //dr yi dt ye  yükledin //Fill ile ters çalışır

                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                conn.Close();
            }

        }

        SqlDataAdapter dap;
        private void button1_Click_1(object sender, EventArgs e) //Insert-Disconnected
        {
            //İşlem sırasına dikkat etmen gerekiyor. Önce insert sonra 

            /*
             *  BENİM YAPTIĞIM
            string sorgu1 = "select CategoryName, Description from Categories";
            string sorgu2 = "insert Categories (CategoryName, Description) values (@catName, @desc)";

            dap = new SqlDataAdapter(sorgu1, conn);

            SqlCommand cmd = new SqlCommand(sorgu2, conn);

            dap.InsertCommand = cmd;
            dap.InsertCommand.Parameters.AddWithValue("@catName", textBox1.Text);
            dap.InsertCommand.Parameters.AddWithValue("@desc", textBox2.Text);

            conn.Open();
            dap.InsertCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dap.Fill(dt);
            conn.Close();
            */

            //Hocanın yaptığı
            //2. bir sorgu çlıştıracaksan bağlantıyı açıp kapatmaya zprluyor
            //Bağlantı sonsuza kadar açık olamaz
            string sorgu1 = "select CategoryName, Description from Categories";
            string sorgu2 = "insert Categories (CategoryName, Description) values (@catName, @desc)";

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            cmd2.Parameters.AddWithValue("@catName", textBox1.Text);
            cmd2.Parameters.AddWithValue("@desc", textBox2.Text);


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd2.ExecuteNonQuery(); //veri kaydı yapıldı
                MessageBox.Show("İşlem başarılı");
            }
            else
            {
                conn.Close();
            }

            //önce veriyi insert et sonra select işlemi yap yani tabloyu göster
            dap = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            dap.Fill(dt); //Fill başka bir nesneyi doldurur. Load kendi nesnesini doldurur
            dataGridView1.DataSource = dt;

            //Kendisinin bu bilgiyi üzerine almasını istersen Load kullan

        }

        List<String> lst = new List<string>();

        private void button4_Click(object sender, EventArgs e) //Insert-List
        {
            string sorgu1 = "select CategoryName, Description from Categories";
            string sorgu2 = "insert Categories (CategoryName, Description) values (@catName, @desc)";

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            cmd2.Parameters.AddWithValue("@catName", textBox1.Text);
            cmd2.Parameters.AddWithValue("@desc", textBox2.Text);



            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd2.ExecuteNonQuery();
                SqlDataReader dr = cmd1.ExecuteReader();

                dataGridView1.Columns.Add("CategoryName", "Kategoriler"); //Veri tabanındaki CategoryName i al ismi Kategoriler olsun

                if (dr.HasRows)//satır varsa
                {
                    while (dr.Read()) //satır bazlı okuma
                    {
                        //her buraya geldiğinde ilk durummuş gibi davran 
                        lst.Add(dr[0].ToString()); //Veriyi list içerisine bastı, 2. veriyi okudu........... hep 0. durum 
                        //Bu her satır için yapıldı ve bitti
                    }

                    //Artık listemde kategorilerin ismi var. Bunları göstermem lazım
                    foreach (var item in lst)
                    {
                        //lst deki verileri dataGridView1 e aktarıyorum
                        //1. elemanı 1. satıra, 2. elemanı 2. satıra... ekle
                        dataGridView1.Rows.Add(item);
                    }
                    MessageBox.Show("İşlem başarılı");
                }
            }
            else
            {
                conn.Close();
            }

            /*
                Add ve Insert in çalışma mantıkları farklı
                Add her daim dizinin sonuna ekler
                Insert belirli indexe eklemeyi sağlar
            */
        }

        private void button5_Click(object sender, EventArgs e) //2 Kolonu DataGridView a yazdırma - List kullanmadan
        {
            string sorgu1 = "select CategoryName, Description from Categories";
            string sorgu2 = "insert Categories (CategoryName, Description) values (@catName, @desc)";

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            cmd2.Parameters.AddWithValue("@catName", textBox1.Text);
            cmd2.Parameters.AddWithValue("@desc", textBox2.Text);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd2.ExecuteNonQuery();
                SqlDataReader dr = cmd1.ExecuteReader();

                dataGridView1.Columns.Add("CategoryName", "Kategoriler"); 
                dataGridView1.Columns.Add("Description", "Açıklamalar"); 

                if (dr.HasRows)
                {
                    while (dr.Read()) 
                    {
                        string kategori = dr[0].ToString();
                        string aciklama = dr[1].ToString();
                        dataGridView1.Rows.Add(kategori, aciklama);
                    }
                    MessageBox.Show("İşlem başarılı");
                }
            }
            else
            {
                conn.Close();
            }
        }


        List<Kategoriler> katList = new List<Kategoriler>();
        private void button6_Click(object sender, EventArgs e) //Class kullanarak 
        {
            string sorgu1 = "select CategoryName, Description from Categories";
            string sorgu2 = "insert Categories (CategoryName, Description) values (@catName, @desc)";

            SqlCommand cmd1 = new SqlCommand(sorgu1, conn);
            SqlCommand cmd2 = new SqlCommand(sorgu2, conn);

            cmd2.Parameters.AddWithValue("@catName", textBox1.Text);
            cmd2.Parameters.AddWithValue("@desc", textBox2.Text);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd2.ExecuteNonQuery();
                SqlDataReader dr = cmd1.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Kategoriler k = new Kategoriler()
                        {
                            //satır satır okuma yapar
                            KatName = dr[0].ToString(),
                            KatAciklama = dr[1].ToString()
                        };
                        katList.Add(k);

                    }
                    dataGridView1.DataSource = katList;

                    //sorguda katId gelmediği için 0 gözükmesin diye gizledik. IndexOutofRange hatası alırsın
                    //ID kolonunu gizleme
                    dataGridView1.Columns[0].Visible = false;

                    MessageBox.Show("İşlem başarılı");
                }
            }
            else
            {
                conn.Close();
            }
        }
    }
}
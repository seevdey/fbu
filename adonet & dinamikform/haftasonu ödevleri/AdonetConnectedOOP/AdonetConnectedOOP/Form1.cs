using AdonetConnectedOOP.Sınıflar;
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

namespace AdonetConnectedOOP
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create();
            read();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update();
            read();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete();
            read();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        public void read()
        {
            dataGridView1.DataSource = null;
            crud.read_data();
            dataGridView1.DataSource = crud.dt;
        }

        public void create()
        {
            crud.customerID = textBox1.Text;
            crud.companyname = textBox2.Text;
            crud.contactname = textBox4.Text;
            crud.insert_data();
        }

        public void update()
        {
            crud.customerID = textBox1.Text;
            crud.companyname = textBox2.Text;
            crud.contactname = textBox4.Text;
            crud.update_data();
        }

        public void delete()
        {
            crud.customerID = textBox1.Text;
            crud.companyname = textBox2.Text;
            crud.contactname = textBox4.Text;
            crud.delete_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        string baglantiCumlesi = "Data Source=SEVDE;Initial Catalog=Northwind;Integrated Security=True";

        private void button4_Click(object sender, EventArgs e)
        {
            #region Veri Listeleme
            string komut = "select * from Customers";

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
                        datatablosu.Columns.Add("ID");
                        datatablosu.Columns.Add("Company");
                        datatablosu.Columns.Add("Contact");

                        using (SqlDataReader okuyucu = listelemekomut.ExecuteReader())
                        {
                            while (okuyucu.Read()) //döngüyle okuyucunun içinde okuyabildiğim sürece döncem. Okumayı satır satır yapacağım ve bunun için geçici satır oluşturacağım
                            {
                                //DataRow sınıfını kullanmamam gerekiyor. Ben burda datatablosunu kullanıyorum
                                //datatablosundan yeni bir satırı DataRow'a al
                                //tablodaki satırları kendi satırlarımla değerleri eşitlemiş oldum
                                DataRow row = datatablosu.NewRow();
                                row["ID"] = okuyucu["CustomerID"];
                                row["Company"] = okuyucu["CompanyName"];
                                row["Contact"] = okuyucu["ContactName"];
                                datatablosu.Rows.Add(row);
                                //okuyucuyu satır bazında oku rowa eşitle sağdakini sola atıyorsun. bu rowu gel atatablosundaki her satırı ekle
                                //okuyucudaki bilgiyi data tablosuna ekledim
                            }

                            dataGridView1.DataSource = datatablosu;
                        }
                    }
                    baglanti.Close();
                }

            }
            #endregion

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace storagedProcedureTekrari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string baglantiCumlesi = "Data Source=SEVDE;Initial Catalog=Northwind;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Boş kayıt yapılamaz!!!");
                textBox2.Select();
                return;
            }

            

            using (SqlConnection cn = new SqlConnection(baglantiCumlesi))
            {
                using (SqlCommand cmd = new SqlCommand("benimprosedurumodev", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    //cmd.Parameters.AddWithValue("@ProductID1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ProductName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", textBox3.Text);
                    cmd.Parameters.AddWithValue("@UnitsInStock", textBox4.Text);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }

            Form1_Load(this, null);

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                #region Veri Listeleme

                string komut = "";
                komut = "select * from Products";

                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = baglantiCumlesi;
                    using (SqlCommand komutlisteleme = new SqlCommand(komut, baglanti))
                    {
                        baglanti.Open();
                        using (DataTable datatablosu = new DataTable())
                        {
                            //tablo oluşturma
                            datatablosu.Columns.Add("Ürün ID");
                            datatablosu.Columns.Add("Ürün Adı");
                            datatablosu.Columns.Add("Ürün Fiyatı");
                            datatablosu.Columns.Add("Ürün Stok Adedi");

                            using (SqlDataReader okuyucu = komutlisteleme.ExecuteReader())
                            {
                                while (okuyucu.Read())
                                {
                                    DataRow row = datatablosu.NewRow();
                                    row["Ürün ID"] = okuyucu["ProductID"];
                                    row["Ürün Adı"] = okuyucu["ProductName"];
                                    row["Ürün Fiyatı"] = okuyucu["UnitPrice"];
                                    row["Ürün Stok Adedi"] = okuyucu["UnitsInStock"];
                                    datatablosu.Rows.Add(row);
                                }

                                dataGridView1.DataSource = datatablosu;
                            }
                        }
                        baglanti.Close();
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //hücre bazında 
            //textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(baglantiCumlesi))
            {
                using (SqlCommand cmd = new SqlCommand("benimprosedurumodev", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Update");
                    cmd.Parameters.AddWithValue("@ProductID1", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ProductName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", textBox3.Text);
                    cmd.Parameters.AddWithValue("@UnitsInStock", textBox4.Text);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            Form1_Load(this, null);
        }
    }
}

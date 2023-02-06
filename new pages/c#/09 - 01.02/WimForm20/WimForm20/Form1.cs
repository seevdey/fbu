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

namespace WimForm20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server = .; Database=Northwind;Trusted_Connection=true;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
        * SQL KISMI -  View 
           create view vw_MusterileriGetir
           as
           select c.CompanyName, c.City, c.Country, c.Phone from Customers c

           select * from vw_MusterileriGetir
       */

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("select * from vw_MusterileriGetir", conn);


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataReader dr = cmd1.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                conn.Close();
            }
        }


        /*            
           
        SQL KISMI - STORE PROCEDURE
            create proc sp_MusterileriGetir
            as
            select c.CompanyName, c.City, c.Country, c.Phone from Customers c

            exec sp_MusterileriGetir
        
         */
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("sp_MusterileriGetir", conn);


            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                cmd1.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd1.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            else
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e) //Store Procedure kullanarak Insert
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriEkle", conn);
            SqlCommand cmd2 = new SqlCommand("select CategoryName, Description from Categories", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@catName", textBox1.Text);
            cmd.Parameters.AddWithValue("@desc", textBox2.Text);

            conn.Open();
            cmd2.ExecuteReader();


            SqlDataReader dr = cmd2.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView1.DataSource = dt;
                MessageBox.Show("Kategori Bilgisi Eklendi");
            }
            else
            {
                MessageBox.Show("Data Yok");
            }
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //Store Procedure kullanarak Transaction kullanma
        {

            conn.Open();
            SqlTransaction tran = conn.BeginTransaction(); //hangi bağlantı üzerinden çalıştığını söylemek gerekiyor

            //cmd.Transaction = tran;
            //cmd2.Transaction = tran;

            //İçerde çalışan komutlar var
            SqlCommand cmd = new SqlCommand("sp_KategoriEkle", conn, tran); //tanımladığın transaction da çalış
            SqlCommand cmd2 = new SqlCommand("select CategoryName, Description from Categories", conn, tran);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@catName", textBox1.Text);
            cmd.Parameters.AddWithValue("@desc", textBox2.Text);

            try
            {
                cmd.ExecuteReader();

                SqlDataReader dr = cmd2.ExecuteReader();

                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    dataGridView1.DataSource = dt;
                    //Bu işlem başarılı ise mesajı ekrana yazdır
                    MessageBox.Show("Kategori Bilgisi Eklendi");

                    tran.Commit(); //İşlemin başarılı oluyor
                }
                else
                {
                    MessageBox.Show("Data Yok");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hatayla karşılaşıldı");
                tran.Rollback();

            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e) //Store Procedure kullanarak Transaction kullanımı 2
        {
            using (SqlConnection conn2 = new SqlConnection("Server = .; Database=Northwind;Trusted_Connection=true;"))
            {
                if (conn2.State == ConnectionState.Closed)
                {
                    conn2.Open();
                    SqlTransaction tran = conn2.BeginTransaction();

                    SqlCommand cmd = new SqlCommand("sp_KategoriEkle", conn2, tran);
                    SqlCommand cmd2 = new SqlCommand("select CategoryName, Description from Categories", conn2, tran);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@catName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@desc", textBox2.Text);

                    try
                    {
                        cmd.ExecuteReader();


                        SqlDataReader dr = cmd2.ExecuteReader();

                        if (dr.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);

                            dataGridView1.DataSource = dt;
                            //Bu işlem başarılı ise mesajı ekrana yazdır
                            MessageBox.Show("Kategori Bilgisi Eklendi");

                            tran.Commit(); //İşlemin başarılı oluyor
                        }
                        else
                        {
                            MessageBox.Show("Data Yok");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmedik bir hatayla karşılaşıldı");
                        tran.Rollback();

                    }
                }
                else
                {
                    conn2.Close();

                }
            }
        }
    }
}

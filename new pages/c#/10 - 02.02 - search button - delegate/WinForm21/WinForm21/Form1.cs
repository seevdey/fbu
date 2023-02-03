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

namespace WinForm21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=SEVDE;Database=Northwind;Trusted_Connection=true;");

       
        private void button2_Click(object sender, EventArgs e) //GETİR BUTONU
        {
            textBox1.Enabled = true;
            label1.ForeColor = Color.Green;

            SqlCommand cmd = new SqlCommand("select FirstName, LastName  from Employees", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
            else
            {
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e) //ARA BUTONU
        {
            SqlCommand cmd = new SqlCommand("select LastName, Title, BirthDate from Employees where FirstName LIKE '%" + textBox1.Text + "%'", conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;

            }
            else
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) //ÇIKIŞ BUTONU
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //HOCANIN YAPTIĞI
            //SqlCommand cmd = new SqlCommand("select LastName, Title, BirthDate from Employees where FirstName LIKE '%' + @name + '%'", conn);
            //cmd.Parameters.AddWithValue("@name", textBox1.Text);

            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();

            //    DataTable dt = new DataTable();
            //    dt.Load(dr);
            //    dataGridView1.DataSource = dt;

            //}
            //else
            //{
            //    conn.Close();
            //}



            //2.YOL
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;

            //String Format kullanımı 

            //Filter, Source a where koşulu ekler
            //bs.Filter = string.Format("CONVERT(" + dataGridView1.Columns[0].DataPropertyName + ", System.String) LIKE '%" + textBox1.Text + "%'"); //aynı zamanda bunun dönüş tipi 

            //String Format ın Doğru kullanımı 
            //ilk indeksteki parametre {0}
            //Indexi 1 olan 2. parametreyi al
            bs.Filter = string.Format("CONVERT({0}, System.String) LIKE '%{1}%' ", dataGridView1.Columns[0].DataPropertyName, textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
    }
}

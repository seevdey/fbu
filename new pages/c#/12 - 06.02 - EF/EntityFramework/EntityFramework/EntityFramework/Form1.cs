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

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        NorthwindEntities db = new NorthwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection
            //    ("Server=DESKTOP-OEQJFLF\\MSSQLSERVER01;Database=Northwind;Trusted_Connection=True");

            //SqlCommand cmd = new SqlCommand("Select * from Customers", conn);

            //  -------------   CONNECTED  -------------

            //if (conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows)
            //    {
            //        while(dr.Read())
            //        {
            //            //
            //        }
            //    }
            //}
            //else
            //{
            //    conn.Close();
            //}

            // -------------  DISCONNECTED  -------------

            //SqlDataAdapter dap = new SqlDataAdapter("Select * from Customers", conn);
            //DataTable dt = new DataTable();

            //dap.Fill(dt);
            //dataGridView1.DataSource = dt;

            // -------------  ENTITY FRAMEWORK (EF)  -------------

            // 1. YOL - Navigation Property gizleme (o tablodaki foreign key)

            //dataGridView1.DataSource = db.Customers.ToList();
            //dataGridView1.Columns["Orders"].Visible = false;

            // 2. YOL - Lambda Expression
            // model üzerinden gelicek veriye select çektik
            // c=> gösterimi LAMBDA expression
            // LAMBDA expression ' la new lemek

            //dataGridView1.DataSource = db.Categories.Select(c => new { c.CategoryID, 
            //    c.CategoryName, c.Description, c.Picture }).ToList();

            // 3. YOL - Linq

            var query = from item in db.Categories
                        select new
                        {
                            item.CategoryID,
                            item.CategoryName,
                            item.Description,
                            item.Picture
                        };

            dataGridView1.DataSource = query.ToList();

        }


    }
}

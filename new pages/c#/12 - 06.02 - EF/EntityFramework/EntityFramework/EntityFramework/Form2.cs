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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        // Değerler ne kadar oynuyor, sapma oranı nasıl
        // ef teki sapma oranı daha az
        // globalde tanımlayınca daha hızlı

        SqlConnection conn = new SqlConnection
                ("Server=DESKTOP-OEQJFLF\\MSSQLSERVER01;Database=Northwind;Trusted_Connection=True");
        private void button1_Click(object sender, EventArgs e)
        {
            // CONNECTED
            DateTime baslangic = DateTime.Now;

            //SqlConnection conn = new SqlConnection
            //    ("Server=DESKTOP-OEQJFLF\\MSSQLSERVER01;Database=Northwind;Trusted_Connection=True");
            SqlCommand cmd = new SqlCommand("Select * from Orders",conn);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr["OrderID"]);
                    }
                }
            }
            else
            {
                conn.Close();
            }
            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic;
            label4.Text = fark.TotalMilliseconds.ToString();
        }
        SqlConnection conn2 = new SqlConnection
                ("Server=DESKTOP-OEQJFLF\\MSSQLSERVER01;Database=Northwind;Trusted_Connection=True");
        private void button2_Click(object sender, EventArgs e)
        {
            // DISCONNECTED
            DateTime baslangic = DateTime.Now;

            //SqlConnection conn2 = new SqlConnection
            //    ("Server=DESKTOP-OEQJFLF\\MSSQLSERVER01;Database=Northwind;Trusted_Connection=True");
            SqlDataAdapter dap = new SqlDataAdapter("Select * from Orders", conn2);

            DataTable dt = new DataTable();
            dap.Fill(dt);
            listBox2.DataSource = dt;
            listBox2.DisplayMember = "OrderID";

            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic;
            label5.Text = fark.TotalMilliseconds.ToString();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void button3_Click(object sender, EventArgs e)
        {
            // EF
            DateTime baslangic = DateTime.Now;

            //NorthwindEntities db = new NorthwindEntities();
            listBox3.DataSource = db.Orders.Select(o => o.OrderID).ToList();
            listBox3.DisplayMember = "OrderID";

            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslangic;
            label6.Text = fark.TotalMilliseconds.ToString();
        }
    }
}

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

namespace WinForm16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Execute Reader, ExeceuteNonQuery, ExecuteScala arasındaki fark
        }

        SqlConnection conn = new SqlConnection("Server=SEVDE;Database=Northwind;Trusted_Connection=true;");


        //Garbage Collector u nasıl çağırırsın

        private void btnGetir_Click(object sender, EventArgs e)
        {
            //RAM i efektif kullandığın için proje hızlı çalışır. Burda en optimum şekilde yazıyorum
            using (SqlCommand cmd = new SqlCommand("select ProductID, ProductName, UnitPrice from Products ", conn)) //nesneyle işin bitince direkt GC gelir
            //using içinde yazdığın nesnerlerin Dispose metodu olma zorunluluğu var
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open(); //bağlantı açma

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        //SqlDataAdapter --> Disconnected mimarisi nesnesidir

                        //okunacak data kadar dön
                        while (dr.Read())
                        {
                            int id = ((int)dr["ProductID"]);
                            string name = dr[1].ToString();
                            decimal price = (decimal)dr["UnitPrice"];

                            listBox1.Items.Add(id.ToString() + " - " + name + " >> " + price.ToString());
                        }
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("BAĞLANTI KAPANDI");
                }
            }
        }
    }
}

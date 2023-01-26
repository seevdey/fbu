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

namespace WinForm15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //CONNECTED
        SqlConnection conn = new SqlConnection("Server=SEVDE;Database=Northwind;Trusted_Connection=true;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed) //Bağlantı kapalı ise
            {
                conn.Open(); //Bağlantıyı aç

                SqlCommand cmd = new SqlCommand("select ProductID, ProductName, UnitPrice from Products ", conn);
                //Veriyi okuma
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem lvi = new ListViewItem(((int)dr["ProductID"]).ToString());

                    //ilk Text alıp sonra SubItems ile devam etmemizin sebebi --> Text te ilk sütun için değer karşılama yağıyoruz
                    //lvi.Text = ((int)dr["ProductID"]).ToString(); //ilk tipi karşıla(int), sonra çevir --> ToString()
                    lvi.SubItems.Add((string)dr["ProductName"].ToString());
                    lvi.SubItems.Add(Convert.ToDecimal(dr["UnitPrice"]).ToString());


                    listView1.Items.Add(lvi);
                }
            }
            else
            {
                conn.Close();
                MessageBox.Show("Bağlantı kapatıldı");

            }
        }
    }
}

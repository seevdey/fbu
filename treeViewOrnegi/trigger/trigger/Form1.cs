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

namespace trigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = "Data Source=SEVDE;Initial Catalog=Northwind;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string komut = "";
                komut = "select * from Categories";
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add("Kategoriler");

                using (SqlConnection baglanti = new SqlConnection())
                {
                    baglanti.ConnectionString = baglantiCumlesi;
                    using (SqlCommand listelemekomut = new SqlCommand(komut, baglanti))
                    {
                        baglanti.Open();
                        using (SqlDataReader okuyucu = listelemekomut.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                treeView1.Nodes[0].Nodes.Add(okuyucu[0].ToString() + "-" + okuyucu[1].ToString());
                            }
                        }
                        baglanti.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //metoda al, parametreye göre çağır

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str = treeView1.SelectedNode.Text; //seçildiği zaman str ye al
            dataGridView1.Rows.Clear();
            if (str == "Kategoriler") //ilk açıldığında kategorilere göre çalıştır
            {
                try
                {
                    string komut = "";
                    komut = "select ProductName, UnitPrice, UnitsInStock from Products";
                    using (SqlConnection baglanti = new SqlConnection())
                    {
                        baglanti.ConnectionString = baglantiCumlesi;
                        using (SqlCommand listelemekomut = new SqlCommand(komut, baglanti))
                        {
                            baglanti.Open();
                            using (SqlDataReader okuyucu = listelemekomut.ExecuteReader())
                            {
                                while (okuyucu.Read())
                                {
                                    dataGridView1.Rows.Add(okuyucu[0], okuyucu[1], okuyucu[2]);

                                }
                            }
                            baglanti.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else //seçilmiş noda göre çalıştır
            {
                string code = str.Split('-')[0];
                try
                {
                    string komut = "";
                    //satır bazında ekleme yaptık
                    komut = "select ProductName, UnitPrice, UnitsInStock from Products where CategoryID = '" + code + "'";
                    using (SqlConnection baglanti = new SqlConnection())
                    {
                        baglanti.ConnectionString = baglantiCumlesi;
                        using (SqlCommand listelemekomut = new SqlCommand(komut, baglanti))
                        {
                            baglanti.Open();
                            using (SqlDataReader okuyucu = listelemekomut.ExecuteReader())
                            {
                                while (okuyucu.Read())
                                {
                                    //okuyucu
                                    dataGridView1.Rows.Add(okuyucu[0], okuyucu[1], okuyucu[2]);

                                }
                            }
                            baglanti.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}

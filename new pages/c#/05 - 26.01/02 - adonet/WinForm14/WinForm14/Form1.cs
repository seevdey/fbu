using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection("Server=SEVDE;Database=Northwind;Trusted_Connection=true;"); //Windows Server

        //SqlConnection con = new SqlConnection("Server=.;Database=Northwind;UID=sa;PWD=9876541"); //Sql Server
        //SQL Server dersen başka bilgisayara bağlanmış olursun
        private void Form1_Load(object sender, EventArgs e)
        {
            //ADO --> ActiveX Data Objects

            //Sorguları parametreli yapıyosun SQL Injection a uğramamak için
        
            //string baglantiCumlesi = "Data Source=SEVDE;Database=Northwind;Integrated Security=True";
            //Integrated Security=True --> kullama, güvenlik kısıtları var
        }

        //Class ile SQL bağlantısı
        //SqlConnection con = new SqlConnection(ERP4.ConnectionString);

        //App.config içerisinde SQL Bağlantısı
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Fenerbahce"].ConnectionString);
        //Tek 1 tane connectionStrgin tanımla ve her yerde kullan .Eğer hepsine ayrı tanımlarsan yavaş çalışır.
        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) //Bağlantı kapalı ise
            {
                con.Open(); //Bağlantıyı aç
                MessageBox.Show("Bağlantı açıldı");
            }
            else
            {
                con.Close();
                MessageBox.Show("Bağlantı kapandı");

            }
        }
    }
}

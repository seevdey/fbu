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

namespace WinForm18
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server = SEVDE; Database=Northwind;Trusted_Connection=true;");
        private void Form2_Load(object sender, EventArgs e)
        {
            //DataAdapter içinde iki adet sorgu kullanma
            SqlDataAdapter dap = new SqlDataAdapter("select CustomerId, CompanyName from Customers; select ShipperId, CompanyName from Shippers ",conn);

            //dap.SelectCommand 
            //dap.InsertCommand  = new SqlCommand("insert .......",conn);
            //dap.UpdateCommand
            //dap.DeleteCommand

            DataSet ds = new DataSet();
            dap.Fill(ds);

            //!!!!!!!!!!!!!!!!!!!!!!!!!
            ds.Tables[0].TableName = "Musteriler";
            ds.Tables[1].TableName = "Kargocular";

            //ÖDEV
            //her sorguyu DataTable a aktar.
            //Data table ı dataset içerisine at

            listBox1.DataSource = ds.Tables[0]; //Customers tablosu
            listBox1.DisplayMember = "CompanyName";
            listBox1.ValueMember = "CustomerId";

            comboBox1.DataSource = ds.Tables["Kargocular"];
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "ShipperId";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select (CONVERT(nvarchar(20), OrderId) + ' >> ' + CONVERT(nvarchar(11), OrderDate)) as ERP4 from Orders where CustomerId = @Cid AND ShipVia = @Sid", conn);

            dap.SelectCommand.Parameters.AddWithValue("@cid", listBox1.SelectedValue);
            dap.SelectCommand.Parameters.AddWithValue("@sid", comboBox1.SelectedValue);

            DataTable dt = new DataTable();
            dap.Fill(dt); //dap taki bilgileri dt ye doldur

            listBox2.DataSource = dt;
            //listBox2.DisplayMember = "OrderDate";
            listBox2.DisplayMember = "ERP4";
        }

        //ilgili CustomerName i güncelle listenin son hali 2. listboxta görünsün
        //2 listbox var, 2 texbox var, textbox ın birine id gelsin, id bilgisi değiştiremesin
        //update sorgunun içinde Customer var
        //readonly
    }
}

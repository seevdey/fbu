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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //Var olan dataları değiştirmek için Disconnected kullanır

        /*
         * 1. listboxta müşteriler tablosu var. 
         * 1. listbox ta herhangi bir veriye 2 kez tıklayınca seçilen verileri textboxa yazdırır
         * sadece companyname kısmı değiştirilebilir
         * değiştirdikten sonra update butonuna bas 
         * değişikliği göstermek için göster butonuna bas
        */
        SqlConnection conn = new SqlConnection("Server = SEVDE; Database=Northwind;Trusted_Connection=true;");
        SqlDataAdapter dap;
        private void Form3_Load(object sender, EventArgs e)
        {

            dap = new SqlDataAdapter("select CustomerId, CompanyName from Customers", conn);

            DataSet ds = new DataSet();
            dap.Fill(ds);

            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "CompanyName";
            listBox1.ValueMember = "CustomerId";

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedValue.ToString();

            textBox2.Text = listBox1.GetItemText(listBox1.SelectedItem);

            //textbox2 yi doldurma -- 2. YOL
            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            textBox2.Text = drv["CompanyName"].ToString();
        }

        private void button1_Click(object sender, EventArgs e) //UPDATE
        {
            //SqlDataAdapter dap = new SqlDataAdapter("UPDATE Customers set CompanyName = @Cname where CustomerID = @id", conn);

            //string sql = null;
            //sql = "UPDATE Customers set CompanyName = @Cname where CustomerID = @id";

            SqlCommand cmd = new SqlCommand("UPDATE Customers set CompanyName = @Cname where CustomerID = @id", conn);
          
            dap.UpdateCommand = cmd;

            dap.UpdateCommand.Parameters.AddWithValue("@id", textBox1.Text);
            dap.UpdateCommand.Parameters.AddWithValue("@Cname", textBox2.Text);

            conn.Open();
            dap.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show("İşlem başarılı");
            conn.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dap = new SqlDataAdapter("select CustomerId, CompanyName from Customers", conn);

            DataSet ds = new DataSet();
            dap.Fill(ds);

            listBox2.DataSource = ds.Tables[0];
            listBox2.DisplayMember = "CompanyName";
            listBox2.ValueMember = "CustomerId";
        }
    }
}

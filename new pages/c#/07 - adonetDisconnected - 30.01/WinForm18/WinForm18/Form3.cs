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
             dap = new SqlDataAdapter("select CustomerId, CompanyName from Customers", conn);

            DataSet ds = new DataSet();
            dap.Fill(ds);

            listBox2.DataSource = ds.Tables[0];
            listBox2.DisplayMember = "CompanyName";
            listBox2.ValueMember = "CustomerId";

            //Kolon başlıklarını oluşturma
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Name",150); //genişliğini 150 yap

            //listView1.Columns[1].Width = 150;

            //listbox2 deki tüm kayıtları ekleme
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    ListViewItem lvi = new ListViewItem();
            //    lvi.Text = item["CustomerId"].ToString();
            //    lvi.SubItems.Add(item["CompanyName"].ToString());
            //    listView1.Items.Add(lvi);
            //}
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            //seçili listbox2 kaydını listview a ekleme
            ListViewItem lvi = new ListViewItem();
            lvi.Text = listBox2.SelectedValue.ToString();
            DataRowView drv = (DataRowView)listBox2.SelectedItem;
            lvi.SubItems.Add(drv["CompanyName"].ToString());
            listView1.Items.Add(lvi);
        }
    }
}

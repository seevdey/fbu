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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SQL de max kullanma --> Index atarsa sıkıntı oluyor. MAx alana script gömüp patlatabilir sizi
        //insteance alabildiğim dispose olan her nesne için using kullanabilirim. GC ye diyor ki işim bitince gel beni burdan dal
        //Yoksa DataReader için sürekli aç, kapa yapmak zorunda kalırsın

        /*
         * DISCONNECTED
            DATA çekilir RAM e alınır. RAM üzerinden hareket edilir
            Avantajı: DahA hızlı İşlem yaparsınız
            canlı verde patlatır
            RAM e çektiğiniz haliyle duruyor
            Sistem ihtiyaçlarını karşılayan bşr yapı var
            Nesnelere dikkat et

            DataReader--> Connected mimari
            DataAdapter --> Disconnected yapıda
        */


        //Connected ya da Disconnected olması farketmez bağlantıyı yapmak zorundasın
        SqlConnection conn = new SqlConnection("Server=SEVDE;Database=Northwind;Trusted_Connection=true;");
        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable --> bir tabloyu içinde bulunduran yapıdır
            //Dataset --> birden fazla tabloyu içinde barındırır. Birden fazla tablo kullanırsan DataSet kullan
            //

            //İhtiyacınız olan kadar kolonları seç
            //select * from ile sorguyu bırakma
            SqlDataAdapter dap = new SqlDataAdapter("SELECT CategoryId, CategoryName FROM Categories", conn);

            DataTable dt = new DataTable();
            dap.Fill(dt); //dap taki bilgiyi DataTable a dolduruyorum

            comboBox1.DataSource = dt;

            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId"; //ID ler doğrudan gösterilmez arkada tutulur

            //list özelliği gösteren bütün nesnelerde DataSource özelliği vardır
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Connected mimaride SqlCommand cmd = new SqlCommand() kullandık

            //Disconected
            SqlDataAdapter dap = new SqlDataAdapter("select UnitPrice, ProductName from Products where CategoryId = @id", conn);

            //SelectCommand ile parametrelerden hangisini kullanmak istediğini seç
            //Item dersen değeri yakalarsın(ön tarafta gördüğün değer), Value dersen arka taraftaki değerini yakalarsın
            dap.SelectCommand.Parameters.AddWithValue("@id", comboBox1.SelectedValue);

            DataSet ds = new DataSet();
            dap.Fill(ds); 
            
            //Birden fazla tablo barındırdığı için ds yi yazıp bırakamazsın. Nu yüzden aşağıdaki satırı yazıyourz
            listBox1.DataSource = ds.Tables[0]; //ilk indexteki tablo Categories tablosu olarak yazdık

            //Tablo adını da yazabilirsin
            //Birden fazla tablo kullanırsan 0. index yerine tablonun adını yaz

            listBox1.DisplayMember = "ProductName";
            listBox1.ValueMember = "UnitPrice"; //Burda sadece ID tutulmaz istediğin herhangi bir kolonu alabilirsin
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                MessageBox.Show(listBox1.SelectedValue.ToString()); ;
            }
        }
    }
}

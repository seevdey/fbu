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

namespace dinamikadodisconnected
{
    public partial class Form1 : Form
    {
        //nesnelerin tanımlanması
        private DataGridView dataGridView1 = new DataGridView();
        private BindingSource bindingSource1 = new BindingSource(); //Arada bağlantı kuruyoruz //veri ile database arasında bağlantı kurmak
        private SqlDataAdapter dataAdapter = new SqlDataAdapter(); //Datanın Disconnected ile alakalı olması. bağlantı olması yok. Adapter ile alıyoruz. Open ve Close yok
        private Button reloadButton = new Button();
        private Button submitButton = new Button();

        public Form1()
        {
            InitializeComponent();
            //tanımladığım nesnelerin ekrana koyulması
            reloadButton.Text = "Yenileme";
            submitButton.Text = "Kaydet";

            //clickler event
            reloadButton.Click += new System.EventHandler(reloadButton_Click);
            submitButton.Click += new System.EventHandler(submitButton_Click);

            //panel ekleme ve  özellikleri ekleem
            FlowLayoutPanel panel = new FlowLayoutPanel(); //otomatik olarak yan yana sıralar. kendin location vermek zorunda kalmazsın. //her şeyi yan yana alabilmesi
            panel.Dock = DockStyle.Top; //panel en tepede olsun 
            panel.AutoSize = true;
            dataGridView1.Dock = DockStyle.Fill; //nesnenin altına tabloyu yerleştiriyorum

            //metotlar
            panel.Controls.AddRange(new Control[] { reloadButton, submitButton }); //panelin içine butonları ekliyorum. Birden fazla olduğu için AddRange kulllandım
            this.Controls.AddRange(new Control[] { panel, dataGridView1 }); //form kontrolü. Ana formda panel ve panleden sonra datagridview i ekledim
            this.Load += new System.EventHandler(Form1_Load);
            this.Text = "Listelenen verilerin yenilenmesi ve kaydedilmesi";

  
        }

        //3 adet metod tanımlamam gerekiyor 
        //1.reloadButton_Click, 2.submitButton_Click 3.Form1_Load
        private void reloadButton_Click(Object sender, EventArgs e)
        {
            //MessageBox.Show("Göktuğ artık sınıfımızın kurabiye canavarıdır :D");
            GetData(dataAdapter.SelectCommand.CommandText); //dataadapter içine sql komutun neyse onu ekliyosun
        }

        private void submitButton_Click(Object sender, EventArgs e)
        {
            dataAdapter.Update((DataTable)bindingSource1.DataSource); //bindingsoruce un data kaynağını al datatable a çevirip dataadapterın güncelleme metoduna aktarıyoruz
            //yani grid in içini değiştirdiğimde 
        }

        private void GetData(string selectCommand)
        {
            try
            {
                //ben bağlantı kurmuyorum ama bu kurala göre bağlantıyapıyotum
                //DataAdapter  a şu şekilde bağlan demem gerekiyor

                //select*from employes dataadapter ın içinde

                string connection = "Data Source=216-03\\SQLEXPRESS;Initial Catalog=Northwind;User ID=sa; Password=Fbu123456";
                //veri tabanındaki tüm bilgi dataAdapter da tutulur
                //bağlanıyo alıyo ve bağlantıyı kesiyo. Bu yüzden open ve close yok. Network oluşturmuyor. Ama devamlı bağlantı olmadığı için başka tarafta güncelleme olursa burda sıkıntı yaşarım
                //anlık işlem yapan operatör kısmında herekete düşürür
                //anlık hareketi kaçırır
                //muhasabede, yöneticide, başhekimlikte, bilgi işlemde kullanırım çünkü anlık olarak görmek zorunda değilim
                //adoda ister connect ister connected kullan texboxt ın validationları yok. bütün textboxlara validation yazıyosun
                //DOPPER daha effective
                //Ef tablo sayısına göre orta ve küçük ölçekliyse EF kullanabilirsin ama bir bankaya EF kullanmamalısın
                dataAdapter = new SqlDataAdapter(selectCommand, connection); //gelen veriyi dataadapter ile çekiyorum 
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter); //eğer oluşturmazsam burdaki dataadapter ım çalışmıyor
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture; //türkçe karakter sorununu çözmek için kullanıyorum
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);//dataGridViewi küçültüp büyüttüğümde kendini resize edebilmesi için ayzdığım kod

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(Object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = bindingSource1;
            GetData("Select * from Employees");
        }

    }
}

//yetkiye göre özel ekran
//kullanıcı yetkinlikleri tut kullanıcı bilgileri olduğu zaman  o kullanıcıda ekranda gözükmesi geerken bilgiler varsa kullanıcıya özel giriŞ oluştur

//dünki ödevi oopta düzenle

//buna benzer uygulama yap
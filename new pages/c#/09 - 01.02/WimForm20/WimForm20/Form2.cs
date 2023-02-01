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

namespace WimForm20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection("Server=SEVDE;Database=Northwind;Trusted_Connection=true;");
        BindingSource bs;


        /*
            BindingSource' u veri kaynağına (datasource) bağlayarak ve ardından formdaki denetimleri de
            bindingsource'a bağlayarak gezinme, sıralama, filtreleme ve güncelleme de dahil, 
            verilerle tüm işlemlerimizi gerçekleştirebiliriz. 
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Categories", conn);
            conn.Open();

            bs = new BindingSource(); //Geriye kalan ne kadar işlem varsa bunun için bs nesnesi tanımladık
            SqlDataReader dr = cmd.ExecuteReader();
            bs.DataSource = dr;
            dataGridView1.DataSource = bs;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            bs.MoveFirst(); //ilk satıra götür
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.MoveLast(); //son satıra götürür
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bs.MovePrevious(); //satır satır geri alır
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bs.MoveNext(); //satır satır ileri alır
        }
    }
}

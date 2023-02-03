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

namespace WinForm25
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        DataRowView _gelen;
        public Form2(DataRowView gelen, string islem)
        {
            InitializeComponent();
            _gelen = gelen;
            if (islem == "Güncelle")
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (islem == "Sil")
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WinForm25.Properties.Settings.NorthwindConnectionString"].ConnectionString);

        public delegate void UrunEkleEventHandler();
        public event UrunEkleEventHandler UrunEkle;

        public delegate void UrunGuncelleEventHandler();
        public event UrunGuncelleEventHandler UrunGuncelle;

        public delegate void UrunSilEventHandler();
        public event UrunSilEventHandler UrunSil;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.northwindDataSet1.Categories);


            if (_gelen != null)//Gelen veri boş değilse
            {
                //Güncelleme/Sil işlemi
                textBox1.Text = _gelen["ProductName"].ToString();
                textBox2.Text = _gelen["UnitPrice"].ToString();
                textBox3.Text = _gelen["UnitsInStock"].ToString();
                textBox4.Text = _gelen["UnitsOnOrder"].ToString();

                comboBox1.SelectedValue = _gelen["CategoryId"];
            }
            else
            {
                MessageBox.Show("Lütfen kategori seçiniz!!");
            }

        }

        private void button2_Click(object sender, EventArgs e) //Ekle - Güncelle Butonu
        {
            if (_gelen != null) //gelen veri null deiğlse güncelleme işlemi
            {
                //güncelle
                string sorguGuncelle = "update Products set ProductName = @name, UnitPrice = @price, UnitsInStock = @stock, UnitsOnOrder = @order, CategoryId = @catId where ProductId = @id ";
                using (SqlCommand cmd = new SqlCommand(sorguGuncelle, conn))
                {
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@price", textBox2.Text);
                    cmd.Parameters.AddWithValue("@stock", textBox3.Text);
                    cmd.Parameters.AddWithValue("@order", textBox4.Text);

                    cmd.Parameters.AddWithValue("@catId", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@id", _gelen["ProductId"]);

                    try
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            UrunGuncelle();
                            MessageBox.Show("Kayıt başarıyla güncellendi"); //combobox ın dropdownstyle ını dropdownlist seçtik
                            this.Close();
                        }
                        else
                        {
                            conn.Close();

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmedik bir hata alındı. B002");
                    }
                }
            }
            else //ekle işlemi
            {
                string sorguInsert = "Insert into Products(ProductName, UnitPrice, UnitsInStock , UnitsOnOrder, CategoryId) values (@name, @price, @stock, @order, @catId)";


                using (SqlCommand cmd = new SqlCommand(sorguInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@price", textBox2.Text);
                    cmd.Parameters.AddWithValue("@stock", textBox3.Text);
                    cmd.Parameters.AddWithValue("@order", textBox4.Text);

                    cmd.Parameters.AddWithValue("@catId", comboBox1.SelectedValue);

                    try
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Kayıt başarıyla oluşturuldu");
                            UrunEkle();
                            this.Close();
                        }
                        else
                        {
                            conn.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmedik bir hata alındı. B003");

                    }
                }
                
                

                
            }
        }

        private void button1_Click(object sender, EventArgs e) //Sil Butonu
        {
            if (_gelen != null) //gelen veri null deiğlse güncelleme işlemi
            {
                string sorguDelete = "delete from Products where ProductId = @id";

                using (SqlCommand cmd = new SqlCommand(sorguDelete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", _gelen["ProductId"]);

                    try
                    {
                        DialogResult res = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (res == DialogResult.OK)
                        {
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                if (UrunSil != null)
                                {
                                    UrunSil();
                                    MessageBox.Show("Ürün başarıyla silindi!");
                                }
                                this.Close();
                            }
                            else
                            {
                                conn.Close();
                            }
                        }
                        if (res == DialogResult.Cancel)
                        {
                            Form1 f1 = new Form1();
                            f1.Show();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmedik bir hata alındı. B001");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek ürünün Id si boş. Kontrol ediniz");
            }

        }
    }
}

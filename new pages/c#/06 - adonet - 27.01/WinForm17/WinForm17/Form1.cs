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

namespace WinForm17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //update, delete, insert işlemlerini aynı ekranda yapma. TabControl kullanabilirsin

        //QUERY ekranı açık ve kaydedilmemişse SQL e bağlantı sıkıntı olur
        //SQL i kapat --> RAM full kapasite çalışır

        SqlConnection conn = new SqlConnection("Server=SEVDE;Database=Northwind;Trusted_Connection=true;");

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Bu kullanım SQL Injection dan saldırıya sebep olur
            //SqlCommand cmd = new SqlCommand("INSERT Categories(CategoryName, Description) values('" + txtKategori.Text + "','" + txtKategori.Text + "')", conn);


            //nesneleri parametre bazlı kullanmamız gerekiyor
            using (SqlCommand cmd = new SqlCommand("INSERT Categories(CategoryName, Description) values(@name, @desc)", conn))  //nesneleri parametre bazlı kullanmamız gerekiyor
            {
                //bilgileri nereden alacağını yazıyoruz
                cmd.Parameters.AddWithValue("@name", txtKategori.Text);
                cmd.Parameters.AddWithValue("@desc", txtAciklama.Text);

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        int etkilenen = cmd.ExecuteNonQuery();

                        //if (etkilenen > 0)
                        //{
                        //    MessageBox.Show("Kayıt Başarıyla EKLENDİ");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Başarısız Kayıt ekleme işlemi!!!!";
                        //}

                        MessageBox.Show(etkilenen > 0 ? "Kayıt Başarıyla EKLENDİ" : "Başarısız Kayıt ekleme işlemi!!!!");//ternary id
                    }
                    else
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message); //hata içeriğini doğrudan burda paylaşır
                    //MessageBox.Show("HATA : " + ex.Message); 

                    //Hataları çıplak bir şekilde ekrana basmak yanlış bir şey. Bu kullanım en doğrusu
                    MessageBox.Show("Beklenmedik bir hata alındı. B001");
                }
            }

        }

         //Ekran kartı çift line da daha hızlı çalışır
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //ID si 9 olan verinin CategoryName ini güncelle
            using (SqlCommand cmd = new SqlCommand("UPDATE Categories set CategoryName = @name, Description = @desc where CategoryID = 9", conn))
            {
                cmd.Parameters.AddWithValue("@name", txtKategori.Text);
                cmd.Parameters.AddWithValue("@desc", txtAciklama.Text);

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        int etkilenen = cmd.ExecuteNonQuery();

                        MessageBox.Show(etkilenen > 0 ? "Kayıt Başarıyla GÜNCELLENDİ" : "Başarısız GÜNCELLEME işlemi!!!!");
                    }
                    else
                    {
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    conn.Close();//Bağlantıyı açık bırakmaması için yazıyoruz
                    MessageBox.Show("Beklenmedik bir hata alındı. B002");

                }
            }
        }

        //INSERT varsa ID yi disable yaparsın
        //UPDATE, DELETE için enable yaparsın, işlem bitince disable yaparsın --> Kontrolleri sağlaman gerekiyor

        //İlgili satırın ID sini yakala
        //DataGridView daha çok admin kullanıcılarına gösterilen bir ekrandır. Eğer müşteri isterse kullanabilirsin.

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //silerken benzersiz alanı seç ve sil

            //CategoryID si 10 olan kolonu sil
            using (SqlCommand cmd = new SqlCommand("DELETE from Categories where CategoryID = 10", conn))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        int etkilenen = cmd.ExecuteNonQuery();

                        MessageBox.Show(etkilenen > 0 ? "Kayıt Başarıyla SİLİNDİ" : "Başarısız SİLME işlemi!!!!");
                    }
                    else
                    {
                        conn.Close();
                    }
                }
                catch (Exception)
                {
                    conn.Close();
                    MessageBox.Show("Beklenmedik bir hata alındı. B003");
                }
            }
        }
    }
}

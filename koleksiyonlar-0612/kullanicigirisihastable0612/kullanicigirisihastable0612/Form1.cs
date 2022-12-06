using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace kullanicigirisihastable0612
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable kullanici = new Hashtable();
        private void eklebtn_Click(object sender, EventArgs e)
        {
            if (!kullanici.ContainsKey(kaditxt.Text))
            {
                if (!kullanici.ContainsValue(sifretxt.Text))
                {
                    kullanici[kaditxt.Text] = sifretxt.Text;
                }
            }
            else
            {
                MessageBox.Show("Kayıtlı Kullanıcı");
                eklebtn.Visible = false;
                girisyapbtn.Visible = true;
            }
        }
        private void listelebtn_Click(object sender, EventArgs e)
        {
            foreach (DictionaryEntry de in kullanici)
            {
                listBox1.Items.Add($"Key : {de.Key} \t Value : {de.Value}");

            }
        }

        private void girisyapbtn_Click(object sender, EventArgs e)
        {
            if (kullanici.ContainsKey(kaditxt.Text))
            {
                if (kullanici.ContainsValue(sifretxt.Text))
                {
                    MessageBox.Show("Giriş Başarılı.....");
                    kaditxt.Clear();
                    sifretxt.Clear();
                    girisyapbtn.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok");
                eklebtn.Visible = true;
                girisyapbtn.Visible = false;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kullanici.Add("sevde", "123");
            kullanici.Add("göktuğ", "1234");
        }
    }
}

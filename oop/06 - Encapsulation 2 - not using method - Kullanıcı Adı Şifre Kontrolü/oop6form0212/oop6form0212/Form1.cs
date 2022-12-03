using oop6form0212.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop6form0212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool sifredrm = false;
        string Kullad = "";

        private void uyeolbtn_Click(object sender, EventArgs e)
        {
			try
			{
				using (Uye uu = new Uye())
				{
					if (!sifredrm)
					{
						Kullad = kulladtxt.Text;
					}

					string sifre = sifretxt.Text;

					uu.KullaniciAdi = Kullad;
					uu.Sifre = sifre;
					label3.Text = $"Uye Adınız :{uu.KullaniciAdi} \nŞifre : {uu.Sifre}";

					yenigirislbl.Visible = true;
					evetbtn.Visible = true;
					hyrbtn.Visible = true;

				}
			}
			catch (ArgumentException ex)
			{
				if (ex.Message == "Kullanıcı Şifresi 8 karakterden fazla olamaz")
				{
					MessageBox.Show(ex.Message);
					sifredrm = true;
					kulladtxt.Enabled = false;
					sifretxt.Clear();
				}
				else
					MessageBox.Show(ex.Message);
			}
		}

        private void hyrbtn_Click(object sender, EventArgs e)
        {
			Environment.Exit(0);
        }
    }
}


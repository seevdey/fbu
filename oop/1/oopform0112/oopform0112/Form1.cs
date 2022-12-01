using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopform0112
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Nokta : IDisposable
        {
            public int x;
            public int y;

            public void topla(Form1 formnesnesi)
            {
                sonuclbl.Text = (x + y).ToString();
            }

            public void cikarma(Form1 formnesnesi)
            {
                formnesnesi.sonuclbl.Text = (x - y).ToString();
            }

            public void carpma(Form1 formnesnesi)
            {
                formnesnesi.sonuclbl.Text = (x * y).ToString();
            }

            public void bolme(Form1 formnesnesi)
            {
                formnesnesi.sonuclbl.Text = (x / y).ToString();
            }

            public string ikiyecarpma(Form1 formnesnesi)
            {
                string nesne = (x * y * 2).ToString();
                formnesnesi.sonuclbl.Text = nesne;
                return nesne;
            }

            public void Dispose() //Bu sınıftan nesne oluşturup bu nesne işi bittiği anda direkt olarak burası çalışır
            {
                //En son Dispose a geliyor
                //istediğin kadar çalıştır hafızada askıda kalır

                //throw new NotImplementedException();

            }
        }


        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            using (Nokta nokta = new Nokta())
            {
                nokta.x = int.Parse(xtxt.Text);
                nokta.y = int.Parse(ytxt.Text);

                if (islemtipicmbx.Text == "Topla")
                {
                    nokta.topla(this);
                }

                else if (islemtipicmbx.Text == "Çıkarma")
                {
                    nokta.cikarma(this);
                }

                else if (islemtipicmbx.Text == "Çarpma")
                {
                    nokta.carpma(this);
                }

                else if (islemtipicmbx.Text == "Bölme")
                {
                    nokta.bolme(this);
                }

                else if (islemtipicmbx.Text == "x*y*2")
                {
                    nokta.ikiyecarpma(this);
                }
            }
        }
    }




}

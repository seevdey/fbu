using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev8
{
    public partial class evetbtn : Form
    {
        public evetbtn()
        {
            InitializeComponent();
        }
        //button1.Click += Button1_Click;

        byte sayac = 1;
        byte sayi = 7;
        byte tahmin;

        private void tahminbtn_Click(object sender, EventArgs e)
        {
            tahmin = Convert.ToByte(tahmintxt.Text);

            if (tahmin >= 1 && tahmin <= 10 )
            {
                if (sayac >= 3)
                {
                    sonlbl.Show();
                    if (sayi == tahmin)
                    {
                        sonuclbl.Show();
                        sonuclbl.Text = $"Tebrikler bildiniz {sayac} kerede!";
                    }
                    sonlbl.Text = "Tahmin hakkınız bitti!";

                    tahmintxt.Clear();
                    tahmintxt.Enabled = false;

                    metinlbl.Show();
                    button1.Show();//Evet butonu
                    hayirbtn.Show();

                    tahminbtn.Enabled = false;

                }
                else
                {
                    if (sayi > tahmin)
                    {
                        sayac++;
                        sonuclbl.Show();
                        sonuclbl.Text = "Girdiğiniz sayı tuttuğunuz sayıdan küçüktür. Tekrar sayı giriniz!";
                        tahmintxt.Clear();
                    }
                    if (sayi < tahmin)
                    {
                        sayac++;
                        sonuclbl.Show();
                        sonuclbl.Text = "Girdiğiniz sayı tuttuğunuz sayıdan büyüktür. Tekrar sayı giriniz!";
                        tahmintxt.Clear();

                    }
                    else if (sayi == tahmin)
                    {
                        sonuclbl.Show();
                        sonuclbl.Text = $"Tebrikler bildiniz {sayac} kerede!";

                        tahmintxt.Clear();
                        tahmintxt.Enabled = false;

                        metinlbl.Show();
                        button1.Show();//Evet butonu
                        hayirbtn.Show();

                        tahminbtn.Enabled = false;
                    }
                }
                
            }
            else
            {
                tahmintxt.Clear();
                MessageBox.Show("Belirlenen aralık dışında sayı giriyorsunuz. Tekrar sayı giriniz!");
            }


        }

        private void tahminbtn_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            //Environment.Exit(0);


            // Restart current application, with same arguments/parameters
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);

            //Application.Restart();
            //Environment.Exit(int errorcode);


        }

        private void hayirbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metinlbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sonuclbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sonlbl_Click(object sender, EventArgs e)
        {

        }

        private void tahmintxt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

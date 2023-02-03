using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //declare kısmı - tanımlama yaptığın kısım
        public delegate void MesajGonder(object sender);

        //değişken tanımladığın kısım
        public MesajGonder mesajGonder;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox içine veri girilmediği sürece buton aktifleşmesin kontrolü de yapabilirsin

            if (mesajGonder != null)
            {
                mesajGonder(textBox1.Text);
            }
            //1 sn açık kalsın sonra kapansın
            System.Threading.Thread.Sleep(1000);
            this.Close();


            //Ben veriyi nerden gönderiyorum --> Form2 den bu yüzden delegate i Form2 ye yazıyorum
        }
    }
}

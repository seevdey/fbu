using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Girilen 3 adet kenar değerlerinden üçgenin eşkenar, ikizkenar, çeşitkenar üçgen olup olmadığını bulan algoritma
            byte kenar1 = Convert.ToByte(kenar1txt.Text);
            byte kenar2 = Convert.ToByte(kenar2txt.Text);
            byte kenar3 = Convert.ToByte(kenar3txt.Text);

            if (kenar1 == kenar2 && kenar2 == kenar3)
            {
                sonuclbl.Text = "Eşkenar üçgen";
            }
            else if ((kenar1 == kenar2 && kenar2 != kenar3) || (kenar2 == kenar3 && kenar2 != kenar1) || (kenar1 == kenar3 && kenar3 != kenar2))
            {
                sonuclbl.Text = "İkizkenar üçgen";
            }
            else
                sonuclbl.Text = "Çeşitkenar üçgen";
        }

        private void sifirlabtn_Click(object sender, EventArgs e)
        {
            kenar1txt.Clear();
            kenar2txt.Clear();
            kenar3txt.Clear();
            sonuclbl.Text = String.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

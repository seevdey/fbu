using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Klavyeden girilen a ve b sayısı 50’den büyük olduğunda c=a+b işlemi yapan değilse bu sayılar uygun değil yazdıran program
        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(atxt.Text);
            int c;

            if (a>50)
            {
                int b = Convert.ToInt32(btxt.Text);

                if (b>50)
                {
                    c = a + b;
                    sonuclbl.Text = Convert.ToString(c);
                }
            }
            else
                sonuclbl.Text = "Sayılar uygun değil";
        }

        private void sonuclbl_Leave(object sender, EventArgs e)
        {

            if (!Int32.TryParse(atxt.Text, out int val))
            {
                atxt.Select();
                atxt.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btxt_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(btxt.Text, out int val))
            {
                btxt.Select();
                btxt.Clear();
            }
        }
    }
}

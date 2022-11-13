using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(sayitxt.Text);
            int faktoriyel = 1;

            if (yontemcmbx.Text == "For")
            {
                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel = faktoriyel * i;
                }
                sonuclbl.Show();
                sonuclbl.Text = $"{faktoriyel}";
            }
            else if (yontemcmbx.Text == "While")
            {
                int j = 1;
                while (j <= sayi)
                {
                    faktoriyel = faktoriyel * j;
                    j++;
                }
                sonuclbl.Show();
                sonuclbl.Text = $"{faktoriyel}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(ntxt.Text);

            int r;
            r = Convert.ToInt32(rtxt.Text);

            //P (n,r) = n! / (n-r)!
            if (secimcmbx.Text == "Permütasyon")
            {
                int faktoriyel = 1;
                for (int i = 1; i <= n; i++)
                    faktoriyel = faktoriyel * i;

                int faktoriyel2 = 1;
                for (int i = 1; i <= n - r; i++)
                    faktoriyel2 = faktoriyel2 * i;

                int permutasyon = faktoriyel / faktoriyel2;
                sonuclbl18.Text = $"{permutasyon}";
            }
            if (secimcmbx.Text == "Kombinasyon")
            {
                int faktoriyel3 = 1;
                for (int i = 1; i <= n; i++)
                    faktoriyel3 = faktoriyel3 * i;

                int faktoriyel4 = 1;
                for (int i = 1; i <= n - r; i++)
                    faktoriyel4 = faktoriyel4 * i;

                int faktoriyel5 = 1;
                for (int i = 1; i <= r; i++)
                    faktoriyel5 *= i;

                int kombinasyon = faktoriyel3 / (faktoriyel4 * faktoriyel5);
                sonuclbl18.Text = $"{kombinasyon}";

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

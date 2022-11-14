using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte toplam = 0;
            byte toplam2 = 0;

            for (byte i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    toplam += i;
                else
                    toplam2 += i;

            }

            teklbl.Text = $"{toplam2}";
            ciftlbl.Text = $"{toplam}";

        }
    }
}

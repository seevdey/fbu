using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            //Bir otoparkın ücret tarifesi şöyledir:
            //0 – 3 saat: 4 TL
            //3 – 7 saat: 3 TL
            //7 – 12 saat: 2 TL
            //12 ve üzeri: 1 TL’dir.
            //Buna göre girilen saate göre otoparka ödenecek ücreti hesaplayıp ekrana yazan programı oluşturunuz.

            byte saat = Convert.ToByte(saattxt.Text);

            if (saat > 0 && saat < 3)
            {
                sonuclbl.Text = "4 TL";
            }
            else if (saat >= 3 && saat < 7)
            {
                sonuclbl.Text = "3 TL";
            }
            else if (saat >= 7 && saat < 12)
            {
                sonuclbl.Text = "2 TL";
            }
            else
                sonuclbl.Text = "1 TL";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

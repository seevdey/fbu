using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm10
{
    public partial class Form2 : Form
    {
        int _gelendata1, _gelendata2;
        public Form2(int gelendata1, int gelendata2)
        {
            InitializeComponent();

            _gelendata1 = gelendata1;
            _gelendata2 = gelendata2;
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(_gelendata1);
            int sayi2 = Convert.ToInt32(_gelendata2);
            int sonuc = sayi1 + sayi2;
            label1.Text = sonuc.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}

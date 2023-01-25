using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(numericUpDown1.Value);
            int g = Convert.ToInt32(numericUpDown2.Value);
            int b = Convert.ToInt32(numericUpDown3.Value);

            //1. YOL
            //Parametresiz kullanım
            //Form2 frm2 = new Form2();
            //frm2.BackColor = Color.FromArgb(r, g, b);
            //frm2.Show();

            //2. YOL
            //Parametreli kullanım
            //Form2 frm2 = new Form2(r, g, b);
            //frm2.Show();

            //3. YOL
            Color renk = Color.FromArgb(r, g, b);
            Form2 frm2 = new Form2(renk);
            frm2.Show();

            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

            MaviYaka my = new MaviYaka();
            my.Para();
            MessageBox.Show(my.Pozisyon);

            BeyazYaka by = new BeyazYaka();
            by.Para();
            MessageBox.Show(by.Pozisyon);
        }
    }
}

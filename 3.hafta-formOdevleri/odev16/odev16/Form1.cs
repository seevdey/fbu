using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            byte us = Convert.ToByte(ustxt.Text);
            byte taban = Convert.ToByte(tabantxt.Text);

            int sonuc = 1;

            for (byte i = 1; i <= taban; i++)
            {
                sonuc *= us;
            }

            sonuclbl.Text = $"{sonuc}";
        }

        private void ustxt_Leave(object sender, EventArgs e)
        {
            //if (!Int32.TryParse(ustxt.Text, out int c))
            //{
            //    ustxt.Select();
            //    ustxt.Clear();
            //}
        }

        private void tabantxt_Leave(object sender, EventArgs e)
        {
            //if (!Int32.TryParse(tabantxt.Text, out int c))
            //{
            //    tabantxt.Select();
            //    tabantxt.Clear();
            //}
        }
    }
}

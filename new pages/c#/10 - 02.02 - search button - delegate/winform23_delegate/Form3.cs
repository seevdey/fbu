using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform23_delegate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public delegate void YeniPostaci(object sender);

        public YeniPostaci postaci2;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (postaci2 != null)
            {
                postaci2(textBox1.Text);
            }
            System.Threading.Thread.Sleep(1000);

            this.Close();
        }
    }
}

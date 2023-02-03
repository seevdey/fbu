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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public delegate void Postaci(object sender);

        public Postaci postaci;
      
  
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (postaci !=null)
            {
                postaci(textBox1.Text);
            }
            System.Threading.Thread.Sleep(1000);
           
            this.Close();
        }
       
      
    }
}

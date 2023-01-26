using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hayvan hayvan = new Hayvan(); 
            //class abstract olduğu için insteance almama izin vermiyor

            Kedi k = new Kedi();
            //k.SesCikar();
            MessageBox.Show(k.SesCikar());

        }
    }
}

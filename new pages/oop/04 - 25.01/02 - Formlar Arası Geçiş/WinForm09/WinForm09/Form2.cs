using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm09
{
    public partial class Form2 : Form
    {
        string _gelenData;

        public Form2(string gelenData)
        {
            InitializeComponent();

           _gelenData = gelenData; //diğer formdan gelen datayı gönderdim

        }

        //constructor üzerinden data karşılama

        //iki yerde InitializeComponent kullanama
        //Load ın tetiklenmesine dikkat etmen gerekiyor

        //public Form2(string gelenData)
        //{
           //InitializeComponent();
            //_gelenData = gelenData; /
        //}

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
        //Form yüklenirsen yazılmasına ihtiyaç yoksa butona bağlayabilirsin
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = _gelenData;
        }


    }
}

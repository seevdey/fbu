using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinamikform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox tt1 = new TextBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            tt1.Location = new Point(185, 52); //x ve y koordinatını verdim
            tt1.Size = new Size(100, 20);
            tt1.Click += new EventHandler(ekle);
            Controls.Add(tt1);

            Button b = new Button();
            b.Location = new Point(182, 82);
            b.Text= "OK";
            b.Click += new EventHandler(mesaj);
            Controls.Add(b);
        }

        private void mesaj(object sender, EventArgs e)
        {
            MessageBox.Show("Bu sınıf başarır mı ?");
        }

        private void ekle(object sender, EventArgs e)
        {

            //dinamik bir textbox tasarlamış olduk
            tt1.Text = "Merhaba"; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hayvan sınıfındaki özellikleri hem Kopek hem de Kedi sınıfına aktarmış oldum
            Kopek kopek = new Kopek();

            Kedi kedi = new Kedi();

            //default olarak ne verirsen o çalışır. Ama eğer kendi sınıfında bu metodu ezersen onun için çalışır
            MessageBox.Show(kopek.SesCikar()); 
            MessageBox.Show(kedi.SesCikar());


        }
    }
}

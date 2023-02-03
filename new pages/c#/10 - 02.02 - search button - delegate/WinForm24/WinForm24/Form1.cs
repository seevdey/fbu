using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void Form2dekiLabelaDataGonder(string metin);
        public Form2dekiLabelaDataGonder form2dekiLabelaDataGonder;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tetiklenmesi için en az 1 kere çalışması gerekiyor. Bunun için load ın içine yazdık

            Form2 frm2 = new Form2();
            //değişkenin üzerine değer gelince burayı tetikle. Tetiklenince metot çalışır. Otomatik olarak datayı burda gösterir
            this.form2dekiLabelaDataGonder += new Form2dekiLabelaDataGonder(frm2.Form2_Form1denDataGelmis);
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            //this.form2dekiLabelaDataGonder += new Form2dekiLabelaDataGonder(frm2.Form2_Form1denDataGelmis);

            ////Veri ataması
            //form2dekiLabelaDataGonder(textBox1.Text);
            //frm2.Show();

            form2dekiLabelaDataGonder(textBox1.Text);
           
        }



    }
}

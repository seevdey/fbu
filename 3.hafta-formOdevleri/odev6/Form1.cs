using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            /*
            kullanıcı 3 adet sayı girer: a,b,c. bu sayılara göre ikinci dereceden denklemin (ax^{2}+bx+c=0)
            köklerini hesapla. kökleri eşitse eşit. kökler imaginary ise çözümsüz. kökler farklı ise ekrana
            belirt.
             */

            float val1, val2, val3;
            float root1, root2;

            val1 = Convert.ToSingle(number1txt.Text);
            val2 = Convert.ToSingle(number2txt.Text);
            val3 = Convert.ToSingle(number3txt.Text);

            float delta = (val2 * val2) - (4 * val1 * val3);

            if (delta > 0)
            {
                resultlbl.Show();
                result2lbl.Show();
                result2lbl.Text = "The roots are different. There are two different roots";

                root1 = Convert.ToSingle(((-1) * val2 - Math.Sqrt(delta)) / (2 * val1));
                root2 = Convert.ToSingle(((-1) * val2 + Math.Sqrt(delta)) / (2 * val1));

                root11lbl.Show();
                root12lbl.Show();
                root12lbl.Text = Convert.ToString(root1);

                root21lbl.Show();
                root22lbl.Show();
                root22lbl.Text = Convert.ToString(root2);
            }
            else if (delta == 0)
            {
                resultlbl.Show();
                result2lbl.Show();
                result2lbl.Text = "The roots are equals. There is one root.";

                root1 = Convert.ToSingle(-val2 / (2 * val1));

                root11lbl.Show();
                root12lbl.Show();
                root12lbl.Text = Convert.ToString(root1);
            }
            else
            {
                resultlbl.Show();
                result2lbl.Show();
                result2lbl.Text = "There is not root";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

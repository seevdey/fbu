using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm13
{
    public class Bmw : Araba, IBenzin, IElektrik, IOtomatik, IManuel
    {

        public void Benzin_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Bmw Benzinli Araç");

        }

        public void Elektrik_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Bmw Benzinli Araç");
        }

        public override void Hiz()
        {
            System.Windows.Forms.MessageBox.Show("Hızlı ve Öfkeliyim");

        }

        public void Manuel_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Bmw Manuel");

        }

        public void Otomatik_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Bmw Otomatik Vites");

        }


    }
}

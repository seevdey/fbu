using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm13
{
    public class Tesla : Araba, IElektrik, IOtomatik
    {

        public void Elektrik_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Tesla Elektrikli Araç");

        }

        public override void Hiz()
        {
            System.Windows.Forms.MessageBox.Show("Hızlı gidebilirim");

        }

        public void Otomatik_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Tesla Otomatik Vites");

        }



    }
}

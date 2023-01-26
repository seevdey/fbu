using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm13
{
    public class Tofas : Araba, IBenzin, IManuel
    {

        public void Benzin_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Tofas Benzinli Araç");
        }

        public override void Hiz()
        {
            System.Windows.Forms.MessageBox.Show("At arabasından hallice");
        }

        public void Manuel_Interface()
        {
            System.Windows.Forms.MessageBox.Show("Tofas Manuel");
        }

    }
}

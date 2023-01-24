using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm06
{
    class BeyazYaka : Personel
    {
        public override void Para()
        {
            System.Windows.Forms.MessageBox.Show("BeyazYaka Maaşı : Para GANİ");
        }

        public override string Pozisyon
        {
            get { return "Pozisyon : Beyaz Yaka"; }
        }
    }
}

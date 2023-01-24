using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm06
{
    class MaviYaka : Personel
    {
        public override void Para()
        {
            System.Windows.Forms.MessageBox.Show("MaviYaka Maaşı : PARA HANİ");
        }

        public override string Pozisyon
        {
            get { return "Pozisyon : Mavi Yaka"; }
        }
    }
}

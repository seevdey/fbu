using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//static sınıflardan, abstract classlardan ve interfacelerden insteance alamzsın
//abstract interface arasınaki fark
//abstract ve virtual arasındaki fark  --> vitrual de sanane, absract ta kullanmak zorundasın

namespace WinForm12
{
    class Insan : IEtcil, IOtcul
    {
        //Birden fazla base class tan kalıtım yapamazsın
        //Interface i çoklu kalıtım için kullanırız
        public void BeslenmeSekli_IEtcil()
        {
            System.Windows.Forms.MessageBox.Show("Ben Etçilim de");
        }
        
        public void BeslenmeSeli_IOtcul()
        { 
            System.Windows.Forms.MessageBox.Show("Ben Otçulum da");
        }
    }
}

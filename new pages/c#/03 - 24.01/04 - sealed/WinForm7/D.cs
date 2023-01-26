using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm7
{
    sealed class D : K//sealed kelimesi kalıtımı engeller
    {
        //sealed sınıfı başka sınıftan kalıtım alabilir
        public int PropertyD { get; set; }
    }
}

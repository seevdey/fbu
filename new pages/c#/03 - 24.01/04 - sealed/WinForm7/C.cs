using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm7
{
    class C : D //D sınıfı sealed olduğu için kalıtım yapamıyoruz
    {
        public int PropertyC { get; set; }
    }
}

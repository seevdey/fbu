using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm04
{
    class Kedi : Hayvan
    {
        public int KalanCanSayisi { get; set; }
        public bool GeceGorusu { get; set; }

        public override string SesCikar()
        {
            return "Kedi Sesi";
        }
    }
}

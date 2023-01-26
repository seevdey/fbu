using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm13
{
    public abstract class Araba //Base Class
    {
       public string Model { get; set; }
       public string Yil { get; set; }
       public bool ESP { get; set; }
       
        public abstract void Hiz();

    }
}

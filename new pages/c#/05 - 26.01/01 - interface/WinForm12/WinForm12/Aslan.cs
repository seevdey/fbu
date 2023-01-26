using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm12
{
    class Aslan : IEtcil
    {
        //Aslan : Etcil
        //public override void BeslenmeSekli_Etcil()
        //{
        //    throw new NotImplementedException();
        //}
        public void BeslenmeSekli_IEtcil()
        {
            System.Windows.Forms.MessageBox.Show("Ben et yerim");
        }
    }
}

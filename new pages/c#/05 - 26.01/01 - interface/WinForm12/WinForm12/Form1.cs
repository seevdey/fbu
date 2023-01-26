using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //abstract class tan insteance alınmaz
            //Otcul o = new Otcul();
            //Etcil e = new Etcil();
           // Error CS0144  Cannot create an instance of the abstract type or interface 'Etcil'


            //Interface ten insteance alınmaz
            //IOtcul ıo = new IOtcul();
            //Error CS0144  Cannot create an instance of the abstract type or interface 'IOtcul'	

            Insan i = new Insan();
            i.BeslenmeSekli_IEtcil();
            i.BeslenmeSekli_IEtcil();

            Inek inek = new Inek();
            inek.BeslenmeSeli_IOtcul();

            Aslan aslan = new Aslan();
            aslan.BeslenmeSekli_IEtcil();

        }
    }
}

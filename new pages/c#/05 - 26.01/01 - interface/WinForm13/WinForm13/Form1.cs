using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Araba a = new Araba(); //abstract class tan insteance alınmaz
        }

        private void btnBmw_Click(object sender, EventArgs e)
        {
            Bmw bmx = new Bmw(); //insteance
            bmx.Model = "A5";
            bmx.Yil = "2020";
            bmx.ESP = true;
            bmx.Benzin_Interface();
            bmx.Manuel_Interface();

        }

        private void btnTesla_Click(object sender, EventArgs e)
        {
            Tesla tesla = new Tesla();
            tesla.Model = "Tesla Model X";
            tesla.Yil = "2022";
            tesla.ESP = true;
            tesla.Otomatik_Interface();
            tesla.Elektrik_Interface();
        }

        private void btnTofas_Click(object sender, EventArgs e)
        {
            Tofas tofas = new Tofas();
            tofas.Model = "Doğan";
            tofas.Yil = "1999";
            tofas.ESP = false;
            tofas.Manuel_Interface();
        }
    }
}

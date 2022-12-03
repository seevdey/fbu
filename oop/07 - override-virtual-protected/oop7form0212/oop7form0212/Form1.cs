using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop7form0212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class Calisan : IDisposable
        {
            private string _ad;

            public string ADI
            {
                get { return _ad; }
                set { _ad = value; }
            }

            private int _sskNo;

            public int SSKNO
            {
                get { return _sskNo; }
                set { _sskNo = value; }
            }

            protected double _maas;

            public double MAAS
            {
                get { return _maas; }
                set { _maas = value; }
            }

            public virtual void zamYap(double zam) 
            {
                //Bu sınıftan kalıtım yoluyla oluşturulan sınıflar tarafından kullananılabilir bir metot olması için virtual kullanıyoruz
                _maas = _maas + zam;
            }

            public virtual void BilgiVer(string ozellik)
            {

            }


            public void Dispose()
            {
                //throw new NotImplementedException();
            }
        }

        class Mudur : Calisan //Mudur class ı Calisan 
        {
            private int departmanKar;

            public int DEPARTMANKAR
            {
                get { return departmanKar; }
                set { departmanKar = value; }
            }

            public override void zamYap(double zam)
            {
                double prim = 0.0;

                if (MAAS > 0)
                {
                    if (departmanKar > 0 && departmanKar < 100)
                    {
                        prim = 1000;
                    }
                    else if (departmanKar > 100 && departmanKar < 1000)
                    {
                        prim = 2000;
                    }
                    else
                    {
                        prim = 3000;
                    }
                    MAAS += zam + prim;
                }

                else
                {
                    return;
                }

            }

        }

        class SatisElemani : Calisan
        {
            private int satisSayisi;

            public int SATISSAYISI
            {
                get { return satisSayisi; }
                set { satisSayisi = value; }
            }

            public override void zamYap(double zam)
            {
                double prim = 0;

                if (MAAS > 0)
                {
                    if (satisSayisi > 0 && satisSayisi < 100)
                    {
                        prim = 100;
                    }
                    else
                    {

                    }
                }
                
            }

            public override void BilgiVer(string ozellik)
            {

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            satislbl.Visible = false;
            satistxt.Visible = false;
            karlbl.Visible = false;
            kartxt.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kartxt.Visible = true;
            karlbl.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            satislbl.Visible = true;
            satistxt.Visible = true;
            karlbl.Visible = false;
            kartxt.Visible = false;
        }
    }
}

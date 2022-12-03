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

            public virtual string BilgiVer(string ozellik)
            {
                if (ozellik is null)
                {
                    return ADI + " / " + SSKNO + " / " + MAAS;

                }

                switch (ozellik)
                {
                    case "ADI":
                        return ADI;
                    case "MAAS":
                        return MAAS.ToString();
                    case "SSKNO":
                        return SSKNO.ToString();
                    default:
                        return "boş";
                }
            }

            public void Dispose()
            {
                //throw new NotImplementedException();
            }
        }

        class Mudur : Calisan //Mudur class ı Calisan 
        {
            private double departmanKar;

            public double DEPARTMANKAR
            {
                get { return departmanKar; }
                set { departmanKar = value; }
            }

            public override void zamYap(double zam)
            {
                double prim = 0;

                if (MAAS > 0)
                {
                    if (departmanKar > 0 && departmanKar < 100)
                        prim = 1000;
                    else if (departmanKar > 100 && departmanKar < 1000)
                        prim = 2000;
                    else
                        prim = 3000;
                }

                else
                {
                    //MessageBox.Show("Maaş Bilgisi Yoktur");
                    //return;
                }
                MAAS += zam + prim;

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
                        prim = 100;
                    else if (satisSayisi >= 100 && satisSayisi < 300)
                        prim = 500;
                    else
                        prim = 1000;

                }
                else
                {
                    //MessageBox.Show("Maaş Bilgisi Yoktur");
                    //return;
                }
                MAAS += zam + prim;

            }

            public override string BilgiVer(string ozellik)
            {
                return base.BilgiVer(ozellik) + " / " + satisSayisi;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    using (Calisan cc = new Calisan())
                    {
                        cc.ADI = adtxt.Text;
                        cc.SSKNO = int.Parse(ssktxt.Text);
                        cc.MAAS = int.Parse(maastxt.Text);
                        cc.zamYap(Convert.ToDouble(zamtxt.Text));
                        listBox1.Items.Add($"Çalışan Bilgileri : \n{cc.BilgiVer(null)}");
                    }
                }

                else if (radioButton2.Checked)
                {
                    using (Mudur mm = new Mudur())
                    {
                        mm.ADI = adtxt.Text;
                        mm.SSKNO = int.Parse(ssktxt.Text);
                        mm.MAAS = int.Parse(maastxt.Text);
                        mm.DEPARTMANKAR = Convert.ToDouble(kartxt.Text);
                        mm.zamYap(Convert.ToDouble(zamtxt.Text));
                        listBox1.Items.Add($"Müdür Bilgileri : \n{mm.BilgiVer("ADI")}");
                    }
                }

                else{
                    using (SatisElemani ss = new SatisElemani())
                    {
                        ss.ADI = adtxt.Text;
                        ss.SSKNO = int.Parse(ssktxt.Text);
                        ss.MAAS = int.Parse(maastxt.Text);
                        ss.SATISSAYISI = Convert.ToInt32(satistxt.Text);
                        ss.zamYap(Convert.ToDouble(zamtxt.Text));
                        listBox1.Items.Add($"Satış Elemanı : \n{ss.BilgiVer(null)}");
                    }
                }

                

                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void Temizle()
        {
            adtxt.Clear();
            ssktxt.Clear();
            maastxt.Clear();
            zamtxt.Clear();
            satistxt.Clear();
            //listBox1.Items.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            satislbl.Visible = false;
            satistxt.Visible = false;
            karlbl.Visible = false;
            kartxt.Visible = false;
            Temizle();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            kartxt.Visible = true;
            karlbl.Visible = true;
            Temizle();


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            satislbl.Visible = true;
            satistxt.Visible = true;
            karlbl.Visible = false;
            kartxt.Visible = false;
            Temizle();



        }
    }
}

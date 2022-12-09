using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switchcaseyapilarform0912
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Yazar
        {
            #region Alan Tanımları

                private string Adi;
                private string Kitap;
                private string Yil;

            #endregion

            #region Get/Set
            public Yazar(string ad, string kitap, string yil)
            {
                ADI = ad;
                KITAP = kitap;
                YIL = yil;
            }

            public string ADI
            {
                get { return Adi; }
                set { Adi = value; }
            }

            public string KITAP
            {
                get { return Kitap; }
                set { Kitap = value; }
            }

            public string YIL
            {
                get { return Yil; }
                set { Yil = value; }
            }
            #endregion

            #region Metot
            public string BilgiVer()
            {
                return ADI + " / " + KITAP + " / " + YIL;

            }
            #endregion

        }
        public enum Renk { red, yellow, green, blue }

        void switchcasedesen(object type, Form1 formnesnesi)
        {
            switch (type)
            {
                case Enum e:
                    switch (e)
                    {
                        #region Enum
                        case Renk.red:
                            formnesnesi.listBox1.BackColor = Color.Red;
                            formnesnesi.listBox1.Items.Clear();
                            formnesnesi.listBox1.Items.Add("Arkaplan Kırmızı");
                            break;
                        case Renk.yellow:
                            formnesnesi.listBox1.BackColor = Color.Yellow;
                            formnesnesi.listBox1.Items.Clear();
                            formnesnesi.listBox1.Items.Add("Arkaplan Sarı");
                            break;
                        case Renk.green:
                            formnesnesi.listBox1.BackColor = Color.Green;
                            formnesnesi.listBox1.Items.Clear();
                            formnesnesi.listBox1.Items.Add("Arkaplan Yeşil");
                            break;
                        case Renk.blue:
                            formnesnesi.listBox1.BackColor = Color.Blue;
                            formnesnesi.listBox1.Items.Clear();
                            formnesnesi.listBox1.Items.Add("Arkaplan Mavi");
                            break;
                        default:
                            break;
                            #endregion
                    }
                    break;

                case Array a:
                    formnesnesi.listBox1.Items.Add($"Dizinin boyutu : {a.Length}");
                    break;

                case IList list:
                    formnesnesi.listBox1.Items.Add($"Listenin eleman sayı adedi : {list.Count}");
                    Yazar x = new Yazar(textBox1.Text, textBox2.Text, textBox3.Text);
                    formnesnesi.listBox1.Items.Add(x.BilgiVer());
                    break;

                default:
                    formnesnesi.listBox1.Items.Add("Bunların dışında");
                    break;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //Enum yapısı
            if (comboBox1.SelectedIndex == 0)
                switchcasedesen(Renk.red, this);

            else if (comboBox1.SelectedIndex == 1) //List Yapısı
            {
                List<Yazar> list = new List<Yazar>();

                switchcasedesen(list, this);
            }

            else if (comboBox1.SelectedIndex == 2)  //Dizi yapısı
            {
                string[] isimler = { "serdar", "mehmet", "yeşim", "veli", "hasan" };
                switchcasedesen(isimler, this);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)   
                groupBox1.Visible = true;
        }
    }
}


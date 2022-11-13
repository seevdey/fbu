using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            string metin = Convert.ToString(metintxt.Text);
            byte sayac = 0;

            for (byte i = 0; i < metin.Length; i++)
            {
                string s = metin.Substring(i, 1);
                switch (s)
                {
                    case "a":
                        sayac++;
                        break;
                    case "e":
                        sayac++;
                        break;
                    case "ı":
                        sayac++;
                        break;
                    case "i":
                        sayac++;
                        break;
                    case "u":
                        sayac++;
                        break;
                    case "ü":
                        sayac++;
                        break;
                    case "o":
                        sayac++;
                        break;
                    case "ö":
                        sayac++;
                        break;
                    default:
                        break;
                }
            }

            sonuclbl.Text = $"{sayac}";
        }
    }
}

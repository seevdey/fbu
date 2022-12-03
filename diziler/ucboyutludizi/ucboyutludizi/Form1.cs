using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucboyutludizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /*
         
         SİNEMA SALONUU
         
         A B ve C katı var 
         her katta  2 salon var
         her salonda 4 koltuk var

        combobox ile;
        kat seç
        salon seç
        kat ve salona göre afiş görseli gelecek

        sonra 4 tane koltuk numarası çıkıyor

        daha önceden alınmışsa xx gelecek kırmızı, boş olanlar yeşil olacak bunlara tıkladığımda kırmızı olacak
        ilk başta hepsi boş gelecek ben bilet aldıkça dolacak

        button ekle --> bilet al
        bilet ala tıklayınca diziye ekleyecek

        2 dizi kullanacaksınız 
        biri 3 boyutlu, biri 2 boyutlu

        */

        string[] ogrenci1 = new string[6];
        string[,] ogrenci2 = new string[2, 3];
        string[,,] ogrenci3 = new string[1, 2, 3];

        int indeks1 = 0, indeks2 = 0, indeks3 = 0;

        string satır = "";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //2 durum varsa 2 boyutlu, 3 durum varsa 3 boyutlu dizi tanımla

        //listeleme butonu
        private void listelebtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                #region Tek Boyutlu

                listBox1.Items.Add("Öğrenci Adı" + "\t" + "Ders Adı" + "\t" + "Ders Notu");
                listBox1.Items.Add("---------------------------------------------------------------");
                for (int i = 0; i < ogrenci1.GetLength(0); i+=3)
                {
                    listBox1.Items.Add(ogrenci1[i] + "\t\t" + ogrenci1[i + 1] + "\t" + ogrenci1[i + 2]);
                }

                #endregion
            }
            else if (radioButton2.Checked)
            {
                #region İki Boyutlu

                string satirtoplam = "";
                listBox1.Items.Add("Öğrenci Adı" + "\t" + "Ders Adı" + "\t" + "Ders Notu");
                listBox1.Items.Add("---------------------------------------------------------------");

                for (int satir = 0; satir < ogrenci2.GetLength(0); satir++)
                {
                    for (int sutun = 0; sutun < ogrenci2.GetLength(1); sutun++)
                    {
                        satirtoplam = satirtoplam + ogrenci2[satir, sutun] + "\t\t";
                    }

                    listBox1.Items.Add(satirtoplam);
                    satirtoplam = "";
                }

                #endregion
            }
            else
            {
                #region Üç Boyutlu Dizi

                for (int i = 0; i < ogrenci3.GetLength(0); i++)
                {
                    for (int j = 0; j < ogrenci3.GetLength(1); j++)
                    {
                        for (int y = 0; y < ogrenci3.GetLength(2); y++)
                        {
                            satır = satır + ogrenci3[i, j, y] + "\t";
                        }
                    }
                    listBox1.Items.Add(satır);
                    satır = "";
                }

                #endregion
            }
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                #region Tek Boyutlu

                if (indeks1 < ogrenci1.GetLength(0))
                {
                    ogrenci1[indeks1] = textBox1.Text;
                    ogrenci1[indeks1 +1] = comboBox1.Text;
                    ogrenci1[indeks1 +2] = textBox2.Text;
                    indeks1 += 3;

                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1; // combo yu sıfırlıyoruz
                    textBox1.Select();

                }
                else
                {
                    MessageBox.Show("Öğrenci Sayısını aştınız");
                }

                #endregion
            }

            else if (radioButton2.Checked)
            {
                #region İki Boyutlu

                if (indeks2 < ogrenci2.GetLength(0)) //sadece 2 öğrenci girmesi için --> 2 olana kadar if in içine gireer
                {
                    ogrenci2[indeks2, 0] = textBox1.Text;
                    ogrenci2[indeks2, 1] = comboBox1.Text;
                    ogrenci2[indeks2, 2] = textBox2.Text;

                    indeks2++;

                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1;
                    textBox1.Select();
                }
                else
                    MessageBox.Show("Öğrenci Sayısını aştınız");

                #endregion
            }

            else if (radioButton3.Checked)
            {
                #region Üç Boyutlu

                if (indeks3 < 2)
                {
                    ogrenci3[0, indeks3, 0] = textBox1.Text; // ad
                    ogrenci3[0, indeks3, 1] = comboBox1.Text; //ders adı
                    ogrenci3[0, indeks3, 2] = textBox2.Text; //not

                    /*
                     
                     0 0 0 / 0  0 1  / 0 0 2

                     0 1 0 / 0 1 1 / 0 1 2
                     
                     */

                    indeks3++;

                    textBox1.Clear();
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1;
                    textBox1.Select();
                }
                else
                    MessageBox.Show("Öğrenci Sayısını aştınız");

                #endregion
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}

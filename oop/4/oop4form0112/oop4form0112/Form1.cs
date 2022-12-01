using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop4form0112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Daire : IDisposable
        {
            public string semti;
            public int odasayisi = 3;

            public Daire(string semti)
            {
                this.semti = semti;
            }

            //Dairede 3 adet oda var

            Oda o = new Oda(50, Oda.OdaCesidi.Salon);
            Oda o1 = new Oda(20, Oda.OdaCesidi.MisafirOdası);
            Oda o2 = new Oda(30, Oda.OdaCesidi.YatakOdası);

            public string BilgiVer()
            {
                return string.Format($"Semti : {semti} - Oda Sayısı : {odasayisi} \nOda Çeşidi : {o.odaCesitAlanı} - Metrekaresi : {o.metrekare} \n" +
                    $"Oda Çeşidi : {o1.odaCesitAlanı} - Metrekaresi : {o1.metrekare} \nOda Çeşidi : {o2.odaCesitAlanı} - Metrekaresi : {o2.metrekare}");
            }

            public void Dispose()
            {
                //throw new NotImplementedException();
            }
        }

        class Oda : IDisposable
        {
            //Eğer ben kullanacağım alanda sabit bilgiler var ve ben bu alana bilgi girmeden sadece seçmek istiyorsam yani combobox gibi düşün 'enum' diye bir keyword yazıyorum
            //enum bunu sabit küme haline getirir
            //içindeki bilgiler sabitse küme şeklinde tutmamızı sağlar

            public enum OdaCesidi
            {
                Salon, ÇocukOdası, MisafirOdası, YatakOdası, OturmaOdası, ÇalışmaOdası //sabit olan değerler bunlar
            }
            public int metrekare;

            public OdaCesidi odaCesitAlanı;

            public Oda(int metrekare, OdaCesidi odaCesitAlanı)
            {
                this.metrekare = metrekare;
                this.odaCesitAlanı = odaCesitAlanı;
            }

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

        }

        private void bilgiverbtn_Click(object sender, EventArgs e)
        {
            using (Daire d1 = new Daire(semttxt.Text))
            {
                listBox1.Items.Add(d1.BilgiVer());
            }
        }
    }
}

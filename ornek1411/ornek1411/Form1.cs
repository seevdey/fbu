using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1411
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        #region ornek1

        #region Örnek1 - Metotlar

        public int sayiKontrolu(int a, int b)
        {
            //dinamik metot
            if (a > 50)
            {
                if (b > 50)
                    sonuclbl.Text = ($"{ToplamaIslemi(a, b)}");
            }
            else
                sonuclbl.Text = "Sayılar uygun değil";

            return 0;
        }


        public int ToplamaIslemi(int a, int b)
        {
            return a + b;
        }
        #endregion

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
        }

        int faktoriyel = 1;


        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen a ve b sayısı 50’den büyük olduğunda c = a + b işlemi yapan değilse bu sayılar uygun değil yazdıran program

            #region Normal

            if (normalradiobtn.Checked == true)
            {
                //metodradiobtn.Checked = false;
                //oopradiobtn.Checked = false;

                int a = Convert.ToInt32(atxt.Text);
                int c;

                if (a > 50)
                {
                    int b = Convert.ToInt32(btxt.Text);

                    if (b > 50)
                    {
                        c = a + b;
                        sonuclbl.Text = Convert.ToString(c);
                    }
                }
                else
                    sonuclbl.Text = "Sayılar uygun değil";
            }
            #endregion

            #region Metod

            else if (metodradiobtn.Checked == true)
            {

                int a = Convert.ToInt32(atxt.Text);
                int b = Convert.ToInt32(btxt.Text);
                sayiKontrolu(a, b);

            }
            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                metodradiobtn.Checked = false;

            }
            #endregion

        }


        #endregion

        #region ornek2

        //Klavyeden girilen bir sayı eğer 5-10 arasında ise girilen sayının karesini alıp gösteren, eğer 5’ten küçük ise faktöriyelini alan, 10’dan büyük ise sayıyı 2’ye bölüp bir eksiğini yazan algoritma

        #region Metotlar - Örnek2

        public int faktoriyelMetot(int sayi) //For
        {
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel = faktoriyel * i;
            }
            return faktoriyel;
        }

        public int faktoriyelMetot2(int sayi) //While
        {
            int i = 1;
            while (i <= sayi)
            {
                faktoriyel = faktoriyel * i;
                i++;
            }
            return faktoriyel;


        }


        #endregion

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                int sayi = Convert.ToInt32(sayitxt.Text);
                int sonuc = 0;

                if (sayi >= 5 && sayi < 10)
                {
                    label4.Text = Convert.ToString(sayi * sayi);
                }
                else if (sayi >= 10)
                {
                    sonuc = (sayi / 2) - 1;
                    label4.Text = Convert.ToString(sonuc);
                }
                else if (sayi < 5)
                {
                    int faktoriyel = 1;
                    for (int i = 1; i <= sayi; i++)
                    {
                        faktoriyel *= i;
                    }
                    label4.Text = Convert.ToString(faktoriyel);
                }
            }
            #endregion

            #region Metot
            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                int sayi = Convert.ToInt32(sayitxt.Text);
                int sonuc = 0;

                if (sayi >= 5 && sayi < 10)
                {
                    label4.Text = ($"{Math.Pow(sayi, 2)}");
                }
                else if (sayi >= 10)
                {
                    sonuc = (sayi / 2) - 1;
                    label4.Text = ($"{sonuc}");

                }
                else if (sayi < 5)
                    label4.Text = Convert.ToString(faktoriyelMetot(sayi));
            }
            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                metodradiobtn.Checked = false;
            }
            #endregion

        }


        #endregion

        #region ornek3
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox4.Visible = true;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
        }

        #region Metot - Örnek 3
        public void ucgenCesidiBulma(int kenar1, int kenar2, int kenar3)
        {
            if (kenar1 == kenar2 && kenar2 == kenar3)
                sonuclbl3.Text = "Eşkenar üçgen";
            else if ((kenar1 == kenar2 && kenar2 != kenar3) || (kenar2 == kenar3 && kenar2 != kenar1) || (kenar1 == kenar3 && kenar3 != kenar2))
                sonuclbl3.Text = "İkizkenar üçgen";
            else
                sonuclbl3.Text = "Çeşitkenar üçgen";
        }
        #endregion

        private void hesaplabtn3_Click(object sender, EventArgs e)
        {
            //Girilen 3 adet kenar değerlerinden üçgenin eşkenar, ikizkenar, çeşitkenar üçgen olup olmadığını bulan algoritma

            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                byte kenar1 = Convert.ToByte(kenar1txt.Text);
                byte kenar2 = Convert.ToByte(kenar2txt.Text);
                byte kenar3 = Convert.ToByte(kenar3txt.Text);

                if (kenar1 == kenar2 && kenar2 == kenar3)
                    sonuclbl3.Text = "Eşkenar üçgen";
                else if ((kenar1 == kenar2 && kenar2 != kenar3) || (kenar2 == kenar3 && kenar2 != kenar1) || (kenar1 == kenar3 && kenar3 != kenar2))
                    sonuclbl3.Text = "İkizkenar üçgen";
                else
                    sonuclbl3.Text = "Çeşitkenar üçgen";
            }
            #endregion

            #region Metot
            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                byte kenar1 = Convert.ToByte(kenar1txt.Text);
                byte kenar2 = Convert.ToByte(kenar2txt.Text);
                byte kenar3 = Convert.ToByte(kenar3txt.Text);
                ucgenCesidiBulma(kenar1, kenar2, kenar3);

            }
            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                metodradiobtn.Checked = false;
            }
            #endregion

        }

        private void sifirlabtn_Click(object sender, EventArgs e)
        {
            kenar1txt.Clear();
            kenar2txt.Clear();
            kenar3txt.Clear();
            sonuclbl3.Text = String.Empty;
        }

        #endregion

        #region ornek4
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }
        private void hesaplabtn4_Click(object sender, EventArgs e)
        {
            //Bir otoparkın ücret tarifesi şöyledir:
            //0 – 3 saat: 4 TL
            //3 – 7 saat: 3 TL
            //7 – 12 saat: 2 TL
            //12 ve üzeri: 1 TL’dir.
            //Buna göre girilen saate göre otoparka ödenecek ücreti hesaplayıp ekrana yazan programı oluşturunuz.

            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                byte saat = Convert.ToByte(saattxt.Text);

                if (saat > 0 && saat < 3)
                    sonuclbl4.Text = "4 TL";
                else if (saat >= 3 && saat < 7)
                    sonuclbl4.Text = "3 TL";
                else if (saat >= 7 && saat < 12)
                    sonuclbl4.Text = "2 TL";
                else
                    sonuclbl4.Text = "1 TL";
            }
            #endregion

            #region Metot
            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                byte saat = Convert.ToByte(saattxt.Text);
                UcretTarifesi(saat);
            }
            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }

        #region Metot - Örnek 4
        public int UcretTarifesi(int saat)
        {
            if (saat > 0 && saat < 3)
                sonuclbl4.Text = "4 TL";
            else if (saat >= 3 && saat < 7)
                sonuclbl4.Text = "3 TL";
            else if (saat >= 7 && saat < 12)
                sonuclbl4.Text = "2 TL";
            else
                sonuclbl4.Text = "1 TL";

            return saat;
        }
        #endregion


        #endregion

        #region ornek5

        /* Belirlenen kullanıcı adı ve şifre doğru girildiğinde “Giriş Başarılı”, yanlış girildiğinde “Girdiğiniz
               kullanıcı adı veya şifre hatalı” mesajı veren. 3 kere yanlış girildiğinde şifrenizi değiştirmek ister
               misiniz? diye sor ve şifreyi değiştir. 
            */

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox6.Visible = true;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }

        byte counter = 1;
        string username = "sevde";
        string password = "123";
        private void girisbtn_Click(object sender, EventArgs e)
        {
            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                if (counter > 2)
                {
                    changelbl.Text = "Do you want to change a password?";
                    yesbtn.Show();
                    nobtn.Show();
                }
                else
                {
                    string username1 = Convert.ToString(usernametxt.Text);
                    string password1 = Convert.ToString(passwordtxt.Text);

                    if (username == username1 && password == password1)
                        MessageBox.Show("Login Successful");
                    else
                    {
                        counter++;
                        MessageBox.Show("Username or Password is Wrong");
                        usernametxt.Clear();
                        passwordtxt.Clear();
                    }
                }
            }
            #endregion

            #region Metot
            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                string username1 = Convert.ToString(usernametxt.Text);
                string password1 = Convert.ToString(passwordtxt.Text);

                Giris(username1, password1);
            }
            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The password changed");
            Environment.Exit(0);
        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            passwordtxt.Clear();
            passwordlbl.Text = "New password enter:";
            string password2 = Convert.ToString(passwordtxt.Text);
            password = password2;
            changebtn.Show();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #region Metot - Örnek 5
        public void Giris(string username1, string password1)
        {
            if (counter > 2)
            {
                changelbl.Text = "Do you want to change a password?";
                yesbtn.Show();
                nobtn.Show();
            }
            else
            {
                if (username == username1 && password == password1)
                    MessageBox.Show("Login Successful");
                else
                {
                    counter++;
                    MessageBox.Show("Username or Password is Wrong");
                    usernametxt.Clear();
                    passwordtxt.Clear();
                }
            }

        }
        #endregion

        #endregion

        #region ornek6
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
            groupBox6.Visible = false;
            groupBox7.Visible = true;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
        }

        #region Metotlar - Örnek 6

        public float deltaHesaplama(float val1, float val2, float val3)
        {
            return (float)(Math.Pow(val2, 2) - (4 * val1 * val3));
        }

        public float deltaSifirdanBuyuk1(float val1, float val2, float val3)
        {
            deltaHesaplama(val1, val2, val3);
            return (float)(((-1) * val2 + Math.Sqrt(deltaHesaplama(val1, val2, val3))) / (2 * val1));
        }

        public float deltaSifirdanBuyuk2(float val1, float val2, float val3)
        {
            return (float)(((-1) * val2 + Math.Sqrt(deltaHesaplama(val1, val2, val3))) / (2 * val1));
        }

        public float deltaSifiraEsit(float val1, float val2)
        {
            return -val2 / (2 * val1);
        }

        #endregion

        private void calcbtn_Click(object sender, EventArgs e)
        {
            /*
            kullanıcı 3 adet sayı girer: a,b,c. bu sayılara göre ikinci dereceden denklemin (ax^{2}+bx+c=0)
            köklerini hesapla. kökleri eşitse eşit. kökler imaginary ise çözümsüz. kökler farklı ise ekrana
            belirt.
             */

            float val1, val2, val3;
            float root1, root2;

            #region Normal

            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                val1 = Convert.ToSingle(number1txt.Text);
                val2 = Convert.ToSingle(number2txt.Text);
                val3 = Convert.ToSingle(number3txt.Text);

                float delta = (val2 * val2) - (4 * val1 * val3);

                if (delta > 0)
                {
                    resultlbl.Show();
                    result2lbl.Show();
                    result2lbl.Text = "The roots are different. There are two different roots";

                    root1 = Convert.ToSingle(((-1) * val2 - Math.Sqrt(delta)) / (2 * val1));
                    root2 = Convert.ToSingle(((-1) * val2 + Math.Sqrt(delta)) / (2 * val1));

                    root11lbl.Show();
                    root12lbl.Show();
                    root12lbl.Text = Convert.ToString(root1);

                    root21lbl.Show();
                    root22lbl.Show();
                    root22lbl.Text = Convert.ToString(root2);
                }
                else if (delta == 0)
                {
                    resultlbl.Show();
                    result2lbl.Show();
                    result2lbl.Text = "The roots are equals. There is one root.";

                    root1 = Convert.ToSingle(-val2 / (2 * val1));

                    root11lbl.Show();
                    root12lbl.Show();
                    root12lbl.Text = Convert.ToString(root1);
                }
                else
                {
                    resultlbl.Show();
                    result2lbl.Show();
                    result2lbl.Text = "There is not root";
                }
            }

            #endregion

            #region Metot

            else if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                val1 = Convert.ToSingle(number1txt.Text);
                val2 = Convert.ToSingle(number2txt.Text);
                val3 = Convert.ToSingle(number3txt.Text);

                float delta = deltaHesaplama(val1, val2, val3);

                if (delta > 0)
                {
                    resultlbl.Show();
                    result2lbl.Show();
                    result2lbl.Text = "The roots are different. There are two different roots";

                    deltaSifirdanBuyuk1(val1, val2, val3);

                    root11lbl.Show();
                    root12lbl.Show();
                    root12lbl.Text = "*";

                    root21lbl.Show();
                    root22lbl.Show();
                    root22lbl.Text = "*";
                }
                else if (delta == 0)
                {
                    resultlbl.Show();
                    result2lbl.Show();
                    result2lbl.Text = "The roots are equals. There is one root.";

                    deltaSifiraEsit(val1, val2);

                    root11lbl.Show();
                    root12lbl.Show();
                    root12lbl.Text = "*";
                }
                else
                {
                    resultlbl.Show();
                    result2lbl.Show();
                    result2lbl.Text = "There is not root";
                }
            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }
        #endregion

        #region ornek7
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = true;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }


        #region Metot - Örnek 7

        public void harfNotu(byte not) //metot1
        {
            sonuclbl7.Text = (not <= 100 && not >= 85) ? "A - Geçtiniz" :
                              (not < 85 && not >= 70) ? "B - Geçtiniz" :
                              (not < 70 && not >= 55) ? "C - Geçtiniz" :
                              (not < 55 && not >= 45) ? "D - Kaldınız" : "F - Kaldınız";

        }


        public string notdonustur(string not)
        {
            string sonuc = "";

            int val;
            if (!Int32.TryParse(not, out val))
                sonuc = "Geçersiz Not";
            else
            {
                int notyeni = int.Parse(not);

                if (notyeni <= 100 && notyeni > 85)
                    sonuclbl7.Text = "A - Geçtiniz";
                else if (notyeni < 86 && notyeni > 69)
                    sonuclbl7.Text = "B - Geçtiniz";
                else if (notyeni < 69 && notyeni > 54)
                    sonuclbl7.Text = "C - Geçtiniz";
                else if (notyeni < 55 && notyeni >= 45)
                    sonuclbl7.Text = "D - Kaldınız";
                else
                    sonuclbl7.Text = "F - Kaldınız";
            }

            return sonuclbl7.Text;
        }

        #endregion

        private void hesaplabtn7_Click(object sender, EventArgs e)
        {
            //sınav notunu giriniz
            //100-85 ise A
            //80-70 ise B
            //70-55 ise C
            //55-45 ise D
            //45< ise F

            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                byte not;
                not = Convert.ToByte(nottxt.Text);
                sonuclbl7.Show();
                sonuclbl7.Text = (not <= 100 && not >= 85) ? "A - Geçtiniz" :
                              (not < 85 && not >= 70) ? "B - Geçtiniz" :
                              (not < 70 && not >= 55) ? "C - Geçtiniz" :
                              (not < 55 && not >= 45) ? "D - Kaldınız" : "F - Kaldınız";
            }
            #endregion

            #region Metot

            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;


                //byte not;
                //not = Convert.ToByte(nottxt.Text);
                //sonuclbl7.Show();
                //harfNotu(not);

                string not;
                not = nottxt.Text;
                sonuclbl7.Show();
                notdonustur(not);
            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }

        #endregion

        #region ornek8
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = true;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }

        byte sayac = 1;
        byte sayi = 7;
        byte tahmin;

        #region Metotlar - Örnek8

        public void VisibleEnabledKisa()
        {
            tahmintxt.Clear();
            tahmintxt.Enabled = false;

            metinlbl.Show();
            evetbtn.Show();
            hayirbtn.Show();

            tahminbtn.Enabled = false;
        }

        public string Dogru()
        {
            sonuclbl8.Show();
            return sonuclbl8.Text = $"Tebrikler bildiniz {sayac} kerede!"; ;
        }

        public void TahminKucuk()
        {
            sayac++;
            sonuclbl8.Show();
            sonuclbl8.Text = "Girdiğiniz sayı tuttuğunuz sayıdan küçüktür. Tekrar sayı giriniz!";
            tahmintxt.Clear();
        }


        public void TahminBuyuk()
        {
            sayac++;
            sonuclbl8.Show();
            sonuclbl8.Text = "Girdiğiniz sayı tuttuğunuz sayıdan büyüktür. Tekrar sayı giriniz!";
            tahmintxt.Clear();
        }

        public int sayiTahmin(byte tahmin)
        {
            if (tahmin >= 1 && tahmin <= 10)
            {
                if (sayac >= 3)
                {
                    sonlbl.Show();
                    if (sayi == tahmin)
                        Dogru();
                    sonlbl.Text = "Tahmin hakkınız bitti!";
                    VisibleEnabledKisa();

                }
                else
                {
                    if (sayi > tahmin)
                        TahminKucuk();
                    if (sayi < tahmin)
                        TahminBuyuk();

                    else if (sayi == tahmin)
                    {
                        Dogru();
                        VisibleEnabledKisa();

                    }
                }
            }

            return tahmin;

        }

        #endregion

        private void tahminbtn_Click(object sender, EventArgs e)
        {
            #region Normal

            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                tahmin = Convert.ToByte(tahmintxt.Text);

                if (tahmin >= 1 && tahmin <= 10)
                {
                    if (sayac >= 3)
                    {
                        sonlbl.Show();
                        if (sayi == tahmin)
                        {
                            sonuclbl8.Show();
                            sonuclbl8.Text = $"Tebrikler bildiniz {sayac} kerede!";
                        }
                        sonlbl.Text = "Tahmin hakkınız bitti!";

                        tahmintxt.Clear();
                        tahmintxt.Enabled = false;

                        metinlbl.Show();
                        evetbtn.Show();
                        hayirbtn.Show();

                        tahminbtn.Enabled = false;

                    }
                    else
                    {
                        if (sayi > tahmin)
                        {
                            sayac++;
                            sonuclbl8.Show();
                            sonuclbl8.Text = "Girdiğiniz sayı tuttuğunuz sayıdan küçüktür. Tekrar sayı giriniz!";
                            tahmintxt.Clear();
                        }
                        if (sayi < tahmin)
                        {
                            sayac++;
                            sonuclbl8.Show();
                            sonuclbl8.Text = "Girdiğiniz sayı tuttuğunuz sayıdan büyüktür. Tekrar sayı giriniz!";
                            tahmintxt.Clear();

                        }
                        else if (sayi == tahmin)
                        {
                            sonuclbl8.Show();
                            sonuclbl8.Text = $"Tebrikler bildiniz {sayac} kerede!";

                            tahmintxt.Clear();
                            tahmintxt.Enabled = false;

                            metinlbl.Show();
                            evetbtn.Show();
                            hayirbtn.Show();

                            tahminbtn.Enabled = false;
                        }
                    }
                }
                else
                {
                    tahmintxt.Clear();
                    MessageBox.Show("Belirlenen aralık dışında sayı giriyorsunuz. Tekrar sayı giriniz!");
                }
            }


            #endregion

            #region Metot

            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                tahmin = Convert.ToByte(tahmintxt.Text);
                sayiTahmin(tahmin);

            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }

        private void evetbtn_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            //Environment.Exit(0);


            // Restart current application, with same arguments/parameters
            Application.Exit();
            System.Diagnostics.Process.Start(Application.ExecutablePath);

            //Application.Restart();
            //Environment.Exit(int errorcode);
        }

        private void hayirbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region ornek9
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = true;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }

        #region Metot - Örnek 9 

        public string ikilikTaban(string sayi)
        {
            string sonuc = "";
            int sayi2 = int.Parse(sayi);

            for (; sayi2 > 0; sayi2 /= 2)
                sonuc = sayi2 % 2 + sonuc; //1010

            sonuclbl9.Text = $"{sonuc}";

            return sonuc;

        }

        #endregion

        private void hesaplabtn9_Click(object sender, EventArgs e)
        {
            //girilen sayıyı ikilik tabana çevirme

            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                string sayi = Convert.ToString(sayitxt9.Text);
                string sonuc = " ";
                int sayi2 = int.Parse(sayi);

                for (; sayi2 > 0; sayi2 /= 2)
                {
                    sonuc = sayi2 % 2 + sonuc; //sonucu başa yazarsan 10 un karşılığı 1010 yerin 0101 yazdırır
                }
                sonuclbl9.Text = $"{sonuc}";
            }
            #endregion

            #region Metot

            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                string sayi = Convert.ToString(sayitxt9.Text);
                ikilikTaban(sayi);

            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }

        #endregion

        #region ornek10
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = true;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }
        #region Metot - Örnek 10
        public void diziGoster(int[] dizi)
        {
            dizi = new int[50];

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    dizi[i] = i;
                    continue;
                }

                listBox1.Items.Add(i);
            }

        }
        #endregion

        private void hesaplabtn10_Click(object sender, EventArgs e)
        {
            //1 den 50 ye kadar olan tek sayılar

            #region Normal 
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                for (int i = 0; i < 50; i++)
                {
                    if (i % 2 == 0)
                        continue;

                    listBox1.Items.Add(i);
                }
            }
            #endregion

            #region Metot

            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                int[] dizi = new int[50];
                diziGoster(dizi);
            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }
        #endregion

        #region ornek11
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = true;

        }

        #region Metot - Örnek11

        void YazdirMukemmel()
        {
            int toplam = 0;

            if (sayi == toplam)
            {
                sonuclbl11.Show();
                sonuclbl11.Text = "Sayı mükemmel sayıdır";
            }
            else
            {
                sonuclbl11.Show();
                sonuclbl11.Text = "Sayı mükemmel sayı değildir";
            }
        }


        int HesaplaMukemmel(int sayi)
        {
            int toplam = 0;

            for (int sayac = 1; sayac < sayi; sayac++)
            {
                if (sayi % sayac == 0)
                {
                    toplam += sayac;
                }
            }

            return toplam;
        }

        #endregion


        private void hesaplabtn11_Click(object sender, EventArgs e)
        {
            //girilen sayının mükemmel sayı olup olmadığı kontrolü

            int sayi = Convert.ToInt32(sayitxt11.Text);

            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;
                int toplam = 0;


                for (int sayac = 1; sayac < sayi; sayac++)
                {
                    if (sayi % sayac == 0)
                    {
                        toplam += sayac;
                    }
                }

                if (sayi == toplam)
                {
                    sonuclbl11.Show();
                    sonuclbl11.Text = "Sayı mükemmel sayıdır";
                }
                else
                {
                    sonuclbl11.Show();
                    sonuclbl11.Text = "Sayı mükemmel sayı değildir";
                }
            }
            #endregion

            #region Metot

            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                HesaplaMukemmel(sayi);
                YazdirMukemmel();
            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = true;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }


        #endregion

        #region ornek12
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = true;
            groupBox14.Visible = false;
            groupBox15.Visible = false;

        }

        #region Metot

        int sesliHarfKontrol(string metin)
        {
            byte sayac2 = 0;

            for (byte i = 0; i < metin.Length; i++)
            {
                string s = metin.Substring(i, 1);
                switch (s)
                {
                    case "a":
                        sayac2++;
                        break;
                    case "e":
                        sayac2++;
                        break;
                    case "ı":
                        sayac2++;
                        break;
                    case "i":
                        sayac2++;
                        break;
                    case "u":
                        sayac2++;
                        break;
                    case "ü":
                        sayac2++;
                        break;
                    case "o":
                        sayac2++;
                        break;
                    case "ö":
                        sayac2++;
                        break;
                    default:
                        break;
                }
            }

            sonuclbl12.Text = $"{sayac2}";

            return sayac2;
        }


        #endregion

        private void hesaplabtn12_Click(object sender, EventArgs e)
        {
            //girilen metinde sesli harf kontrolü
            string metin = Convert.ToString(metintxt.Text);
            byte sayac = 0;

            #region Normal
            if (normalradiobtn.Checked == true)
            {
                metodradiobtn.Checked = false;
                oopradiobtn.Checked = false;

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

                sonuclbl12.Text = $"{sayac}";
            }
            #endregion

            #region Metot

            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                sesliHarfKontrol(metin);
            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

            }
            #endregion
        }
        #endregion

        #region ornek13

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = true;
            groupBox15.Visible = false;
        }

        #region Metot - Örnek 13

        float usd = 0.0f;
        float euro = 0.0f;
        float sterlin = 0.0f;
        float tl = 0.0f;

        public void ParaBirimiSecimi()
        {
            switch (parabirimicmbx.Text)
            {
                case "USD": 
                    euro = 15.3f;
                    sterlin = 15.4f;
                    tl = 11.8f;
                    break;
                case "EURO":
                    usd = 20.2f;
                    sterlin = 13.9f;
                    tl = 14.5f;
                    break;
                case "STERLIN":
                    usd = 15.1f;
                    euro = 16.76f;
                    tl = 15.3f;
                    break;
                case "TL":
                    usd = 12.9f;
                    euro = 16.3f;
                    sterlin = 13.8f;
                    break;
                default:
                    break;
            }
        }

        public void DonusturulecekParaBirimi(float miktar)
        {
            float sonuc = 0;

            switch (dparabirimicmbx.Text)
            {
                case "USD":
                    sonuc = miktar / usd;
                    sonuclbl13.Text = $"{sonuc}";
                    break;
                case "DOLAR":
                    sonuc = miktar / euro;
                    sonuclbl13.Text = $"{sonuc}";
                    break;
                case "STERLIN":
                    sonuc = miktar / sterlin;
                    sonuclbl13.Text = $"{sonuc}";
                    break;
                case "TL":
                    sonuc = miktar / tl;
                    sonuclbl13.Text = $"{sonuc}";
                    break;
                default:
                    break;
            }
        }

        #endregion

        private void hesaplabtn13_Click(object sender, EventArgs e)
        {
            //Para birimi 1.USD, 2. EURO, 3-STERLIN, 4.TL
            //Para miktarı
            //Kur
            //Dönüşecek para birimi
            //Sonuç

            //1 para birimi için 3 farklı kur var

            float miktar = Convert.ToSingle(paratxt.Text);
            float sonuc = 0;

            #region Normal
            if (normalradiobtn.Checked == true)
            {
                switch (parabirimicmbx.Text)
                {
                    case "USD": //USD
                        euro = 15.3f;
                        sterlin = 15.4f;
                        tl = 11.8f;
                        break;
                    case "EURO"://EURO
                        usd = 20.2f;
                        sterlin = 13.9f;
                        tl = 14.5f;
                        break;
                    case "STERLIN"://STERLIN
                        usd = 15.1f;
                        euro = 16.76f;
                        tl = 15.3f;
                        break;
                    case "TL"://TL
                        usd = 12.9f;
                        euro = 16.3f;
                        sterlin = 13.8f;
                        break;
                    default:
                        break;
                }

              
                switch (dparabirimicmbx.Text)
                {
                    case "USD":
                        sonuc = miktar / usd;
                        sonuclbl13.Text = $"{sonuc}";
                        break;
                    case "DOLAR":
                        sonuc = miktar / euro;
                        sonuclbl13.Text = $"{sonuc}";
                        break;
                    case "STERLIN":
                        sonuc = miktar / sterlin;
                        sonuclbl13.Text = $"{sonuc}";
                        break;
                    case "TL":
                        sonuc = miktar / tl;
                        sonuclbl13.Text = $"{sonuc}";
                        break;
                    default:
                        break;
                }
            }

            #endregion


            #region Metot

            if (metodradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;

                ParaBirimiSecimi();
                DonusturulecekParaBirimi(miktar);
            }

            #endregion

            #region OOP
            if (oopradiobtn.Checked == true)
            {
                normalradiobtn.Checked = false;
                oopradiobtn.Checked = false;
            }
            #endregion

        }

        #endregion

        #region ornek14

        private void hesaplabtn14_Click(object sender, EventArgs e)
        {

            //faktöriyel hesabı -- for ve while ile
            int sayi = Convert.ToInt32(sayitxt14.Text);

            sonuclbl14.Visible = true;
            sayitxt14.Clear();
            sonuclbl14.Text = "";


            if (yontemcmbx.Text == "For")
            {
                //sonuclbl14.Text = "";

                sonuclbl14.Text = Convert.ToString(faktoriyelMetot(sayi));
            }
            if (yontemcmbx.Text == "While")
            {
                //sonuclbl14.Text = "";
                //sayitxt14.Clear();

                //sonuclbl14.Visible = true;

                sonuclbl14.Text = Convert.ToString(faktoriyelMetot2(sayi));
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = true;
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metodradiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace football_score_pred
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Player : IDisposable
        {
            //isim, numara, skor, foto

            private string name;

            public string NAME
            {
                get { return name; }
                set { name = value; }
            }

            private string number;

            public string NUMBER
            {
                get { return number; }
                set { number = value; }
            }

            private int score;

            public int SCORE
            {
                get { return score; }
                set { score = value; }
            }

            private string picture;

            public string PICTURE
            {
                get { return picture; }
                set { picture = value; }
            }


            public void Dispose()
            {
                //throw new NotImplementedException();
            }
        }

        class Keepers : Player
        {
            //KALECİLER
            public string[,] keepers = {

                {"Altay Bayındır" , "12", "%60",  @"..\\..\\images\\1-altay.png"},
                {"Ertuğrul Çetin" , "54", "%50", @"..\\..\\images\\2-irfancan.png"},
                {"İrfan Can Eğribayat" , "70", "%80" , @"..\\..\\images\\3-ertugrul.png"},
                {"Fernando Muslera" , "11", "%60",  @"..\\..\\images\\4-muslera.png"},
                {"Uğurcan Çakır" , "1", "%60",  @"..\\..\\images\\5-ugurcan.png"},
                {"Ersin Destanoğlu" , "1", "%60",  @"..\\..\\images\\6-ersin.png"},
                {"Mert Günok" , "34", "%60",  @"..\\..\\images\\7-mert.png"},
            };

            public string name(int randomdeger)
            {
                return NAME = keepers[randomdeger, 0];
            }

            public string number(int randomdeger)
            {
                return NUMBER = keepers[randomdeger, 1];
            }

            public string picture(int randomdeger)
            {
                return PICTURE = keepers[randomdeger, 3];
            }


        }

        class Defense : Player
        {
            //DEFENSE

            #region defenses1

            public string[,] defenses1 = {

                {"Gustavo Henrique" , "70", "%80" , @"..\\..\\images\\1-gustavo.png"},
                {"Serdar Aziz" , "4", "%50", @"..\\..\\images\\2-serdar.png"},
                {"Kazımcan Karataş" , "88", "%50", @"..\\..\\images\\9-kazimcan.png"},
                {"Tayyip Sanuç" , "3", "%50", @"..\\..\\images\\13-tayyip.png"},
                {"Arthur Masuaku" , "25", "%50", @"..\\..\\images\\17-arthur.png"},
                {"Juan Bernat" , "14", "%50", @"..\\..\\images\\14-juan.png"},

            };

            public string name1(int randomdeger)
            {
                return NAME = defenses1[randomdeger, 0];
            }

            public string number1(int randomdeger)
            {
                return NUMBER = defenses1[randomdeger, 1];
            }

            public string picture1(int randomdeger)
            {
                return PICTURE = defenses1[randomdeger, 3];
            }

            #endregion

            #region defenses2

            public string[,] defenses2 = {

                {"Bright Osayi-Samuel" , "21", "%60",  @"..\\..\\images\\4-samuel.png"},
                {"Ezgjan Alioski" , "6", "%60",  @"..\\..\\images\\6-ezgjan.png"},
                {"Abdülkerim Bardakçı" , "42", "%60",  @"..\\..\\images\\10-bardakci.png"},
                {"Valentin Rosier" , "2", "%60",  @"..\\..\\images\\14-valentin.png"},
                {"Welinton" , "23", "%60",  @"..\\..\\images\\18-welinton.png"},
                {"ARchraf Hakimi" , "2", "%60",  @"..\\..\\images\\23-archraf.png"},
            };

            public string name2(int randomdeger)
            {
                return NAME = defenses2[randomdeger, 0];
            }

            public string number2(int randomdeger)
            {
                return NUMBER = defenses2[randomdeger, 1];
            }

            public string picture2(int randomdeger)
            {
                return PICTURE = defenses2[randomdeger, 3];
            }

            #endregion

            #region defenses3

            public string[,] defenses3 = {

                {"Luan Peres" , "28", "%60",  @"..\\..\\images\\3-luan.png"},
                {"Ferdi Kadioglu" , "7", "%60",  @"..\\..\\images\\5-ferdi.png"},
                {"Emin Bayram" , "40", "%60",  @"..\\..\\images\\11-emin.png"},
                {"Tayfur Bingöl" , "88", "%60",  @"..\\..\\images\\15-tayfur.png"},
                {"Necip Uysal" , "20", "%60",  @"..\\..\\images\\19-necip.png"},
                {"Nordi Mukiele" , "26", "%60",  @"..\\..\\images\\24-nordi.png"},
            };

            public string name3(int randomdeger)
            {
                return NAME = defenses3[randomdeger, 0];
            }

            public string number3(int randomdeger)
            {
                return NUMBER = defenses3[randomdeger, 1];
            }

            public string picture3(int randomdeger)
            {
                return PICTURE = defenses3[randomdeger, 3];
            }

            #endregion

            #region defenses4

            public string[,] defenses4 = {

                {"Mauricio Lemos" , "29", "%60",  @"..\\..\\images\\7-mauricio.png"},
                {"Nazim Sangaré" , "30", "%60",  @"..\\..\\images\\8-nazim.png"},
                {"Barış Yılmaz" , "53", "%60",  @"..\\..\\images\\12-baris.png"},
                {"Umut Meras" , "77", "%60",  @"..\\..\\images\\16-umut.png"},
                {"Emrecan Uzunhan" , "14", "%60",  @"..\\..\\images\\20-emre.png"},
                {"Marquinhos" , "5", "%60",  @"..\\..\\images\\24-emre.png"},
            };

            public string name4(int randomdeger)
            {
                return NAME = defenses4[randomdeger, 0];
            }

            public string number4(int randomdeger)
            {
                return NUMBER = defenses4[randomdeger, 1];
            }

            public string picture4(int randomdeger)
            {
                return PICTURE = defenses4[randomdeger, 3];
            }

            #endregion

        }

        class Striker : Player
        {
            #region striker1

            public string[,] striker1 = {

                {"Jamie Vardy" , "9", "%80" , @"..\\..\\images\\1-vardy.png"},
                {"Facundo Pellistri" , "28", "%80" , @"..\\..\\images\\2-facundo.png"},
                {"Anthony" , "99", "%80" , @"..\\..\\images\\3-anthony.png"},
                {"Luas Diaz" , "24", "%80" , @"..\\..\\images\\4-diaz.png"},
                {"Karim Benzema" , "9", "%80" , @"..\\..\\images\\5-benzema.png"},
                {"Lucas Vázquez" , "17", "%80" , @"..\\..\\images\\6-vazquez.png"},

            };

            public string name1(int randomdeger)
            {
                return NAME = striker1[randomdeger, 0];
            }

            public string number1(int randomdeger)
            {
                return NUMBER = striker1[randomdeger, 1];
            }

            public string picture1(int randomdeger)
            {
                return PICTURE = striker1[randomdeger, 3];
            }

            #endregion

            #region striker2

            public string[,] striker2 = {

                {"Marco Asensio" , "11", "%80" , @"..\\..\\images\\7-asensio.png"},
                {"Rodrygo Silva de Goes" , "28", "%80" , @"..\\..\\images\\8-rodrygo.png"},
                {"Eden Michael Hazard" , "7", "%80" , @"..\\..\\images\\9-hazard.png"},
                {"Vinícius José" , "24", "%80" , @"..\\..\\images\\10-vini.png"},
                {"Ansu Fati" , "25", "%80" , @"..\\..\\images\\11-fati.png"},
                {"Ferran Torres" , "11", "%80" , @"..\\..\\images\\12-ferran.png"},

            };

            public string name2(int randomdeger)
            {
                return NAME = striker2[randomdeger, 0];
            }

            public string number2(int randomdeger)
            {
                return NUMBER = striker2[randomdeger, 1];
            }

            public string picture2(int randomdeger)
            {
                return PICTURE = striker2[randomdeger, 3];
            }

            #endregion

            #region striker3

            public string[,] striker3 = {

                {"Ousmane Dembélé" , "7", "%80" , @"..\\..\\images\\13-dembele.png"},
                {"Raphael Dias Belloli" , "28", "%80" , @"..\\..\\images\\14-raphinha.png"},
                {"Robert Lewandowski" , "9", "%80" , @"..\\..\\images\\15-lewandowski.png"},
                {"Memphis Depay" , "24", "%80" , @"..\\..\\images\\16-depay.png"},
                {"Yannick Carrasco" , "11", "%80" , @"..\\..\\images\\17-carrasco.png"},
                {"Joaquín Correa" , "11", "%80" , @"..\\..\\images\\18-correa.png"},

            };

            public string name3(int randomdeger)
            {
                return NAME = striker3[randomdeger, 0];
            }

            public string number3(int randomdeger)
            {
                return NUMBER = striker3[randomdeger, 1];
            }

            public string picture3(int randomdeger)
            {
                return PICTURE = striker3[randomdeger, 3];
            }

            #endregion

            #region striker4

            public string[,] striker4 = {

                {"Feliz" , "7", "%80" , @"..\\..\\images\\19-felix.png"},
                {"Antoine Griezmann" , "8", "%80" , @"..\\..\\images\\20-griezmann.png"},
                {"Álvaro Borja Morata Martín" , "9", "%80" , @"..\\..\\images\\21-morata.png"},
                {"Matheus Cunha" , "9", "%80" , @"..\\..\\images\\22-cunha.png"},
                {"Jack Peter Grealish" , "7", "%80" , @"..\\..\\images\\23-grealish.png"},
                {"Riyad Karim Mahrez," , "7", "%80" , @"..\\..\\images\\24-mahrez.png"},

            };

            public string name4(int randomdeger)
            {
                return NAME = striker4[randomdeger, 0];
            }

            public string number4(int randomdeger)
            {
                return NUMBER = striker1[randomdeger, 1];
            }

            public string picture4(int randomdeger)
            {
                return PICTURE = striker4[randomdeger, 3];
            }

            #endregion
        }

        class Santrafor : Player
        {
            #region striker2

            public string[,] striker1 = {

                {"Armando Broja" , "1", "%80" , @"..\\..\\images\\1-armando.png"},
                {"Pierre-Emerick Aubameyang" , "9", "%80" , @"..\\..\\images\\2-pierre.png"},
                {"Zlatan Ibrahimović" , "96", "%80" , @"..\\..\\images\\9-zlatan.png"},

            };

            public string name1(int randomdeger)
            {
                return NAME = striker1[randomdeger, 0];
            }

            public string number1(int randomdeger)
            {
                return NUMBER = striker1[randomdeger, 1];
            }

            public string picture1(int randomdeger)
            {
                return PICTURE = striker1[randomdeger, 3];
            }

            #endregion

            #region striker2

            public string[,] striker2 = {

                {"Jude Soonsup-Bell" , "88", "%80" , @"..\\..\\images\\3-jude.png"},
                {"Mason Burstow" , "65", "%80" , @"..\\..\\images\\4-mason.png"},
                {"Marko Lazetić" , "19", "%80" , @"..\\..\\images\\10-marko.png"},

            };

            public string name2(int randomdeger)
            {
                return NAME = striker2[randomdeger, 0];
            }

            public string number2(int randomdeger)
            {
                return NUMBER = striker2[randomdeger, 1];
            }

            public string picture2(int randomdeger)
            {
                return PICTURE = striker2[randomdeger, 3];
            }

            #endregion

            #region striker3

            public string[,] striker3 = {

                {"Jude Soonsup-Bell" , "7", "%80" , @"..\\..\\images\\5-jude.png"},
                {"Edin Dzeko" , "69", "%80" , @"..\\..\\images\\6-edin.png"},
                {"Olivier Giroud" , "67", "%80" , @"..\\..\\images\\11-olivier.png"},
            };

            public string name3(int randomdeger)
            {
                return NAME = striker3[randomdeger, 0];
            }

            public string number3(int randomdeger)
            {
                return NUMBER = striker3[randomdeger, 1];
            }

            public string picture3(int randomdeger)
            {
                return PICTURE = striker3[randomdeger, 3];
            }

            #endregion

            #region striker4

            public string[,] striker4 = {

                {"Romelu Lukaku" , "77", "%80" , @"..\\..\\images\\7-romelu.png"},
                {"Lautaro Martínez" , "8", "%80" , @"..\\..\\images\\8-lautaro.png"},
                {"Divock Origi" , "14", "%80" , @"..\\..\\images\\12-divock.png"},
            };

            public string name4(int randomdeger)
            {
                return NAME = striker4[randomdeger, 0];
            }

            public string number4(int randomdeger)
            {
                return NUMBER = striker1[randomdeger, 1];
            }

            public string picture4(int randomdeger)
            {
                return PICTURE = striker4[randomdeger, 3];
            }

            #endregion
        }

        private void teambtn_Click(object sender, EventArgs e)
        {
            /*
                Ekran açılacak
                cmbx ten ülke seç 
                comboboxtan  takım isimleri gelecek
                comboxoxtan 2. takımı seç
                3 tane cmbx oluşturmalısın

                Oluştur dediğimde sağda gs takımını fotoğraflarla oyuncuları oluşturuyor, solda fb takımını oluşturuyor
                Buttonla maç oyna diyorum skor çıkıyor
                Oyuncu havuzundan oyuncu oluştur

                ülkenin içindeki takımları çıkacak 
                A takımı gs, B takımı fb
                Butona bas takım oluştur 
                Oyuncu havuzu yapıyorsunuz
                oyuncu skoruna göre takım oluştur
                image ile gs ve fb takımlarını oluştur
                    SKOR TAHMİNİ :  2 ratinge göre kombinasyonla, permütasyon kazanma yüzdesi

                maçı oyna 
                skor yazdır

           */

            Random rnd = new Random();

            #region Different Photo

            int randomy = rnd.Next(0, 5);
            int randomx = rnd.Next(0, 5);

            while (randomx == randomy)
            {
                randomy = rnd.Next(0, 5);
            }

            #endregion

            #region KEEPER

            #region Keeper Object1
            using (Keepers kp = new Keepers())
            {
                namelbl.Text = kp.name(randomx);
                numberlbl.Text = kp.number(randomx);
                keeperpictureBox.Image = System.Drawing.Image.FromFile(kp.picture(randomx));

            }
            #endregion

            #region Keeper Object2

            using (Keepers kp2 = new Keepers())
            {
                keepernamelbl.Text = kp2.name(randomy);
                keepnumberlbl1.Text = kp2.number(randomy);
                keeper2pictureBox.Image = System.Drawing.Image.FromFile(kp2.picture(randomy));

            }
            #endregion


            #endregion

            #region Defenses

            #region Defenses Object1
            using (Defense df = new Defense())
            {
                dfnumberlbl1.Text = df.name1(randomx);
                dfnamelbl1.Text = df.number1(randomx);
                dfpictureBox1.Image = System.Drawing.Image.FromFile(df.picture1(randomx));

                dfnumberlbl2.Text = df.name2(randomx);
                dfnamelbl2.Text = df.number2(randomx);
                dfpictureBox2.Image = System.Drawing.Image.FromFile(df.picture2(randomx));

                dfnumberlbl3.Text = df.name3(randomx);
                dfnamelbl3.Text = df.number3(randomx);
                dfpictureBox3.Image = System.Drawing.Image.FromFile(df.picture3(randomx));

                dfnumberlbl4.Text = df.name4(randomx);
                dfnamelbl4.Text = df.number4(randomx);
                dfpictureBox4.Image = System.Drawing.Image.FromFile(df.picture4(randomx));
            }
            #endregion

            #region Defenses Object2
            using (Defense df2 = new Defense())
            {
                df2namebl1.Text = df2.name1(randomy);
                df2nolbl1.Text = df2.number1(randomy);
                df2pictureBox1.Image = System.Drawing.Image.FromFile(df2.picture1(randomy));

                df2namelbl2.Text = df2.name2(randomy);
                df2nolbl2.Text = df2.number2(randomy);
                df2pictureBox2.Image = System.Drawing.Image.FromFile(df2.picture2(randomy));

                df2namelbl3.Text = df2.name3(randomy);
                df2nolbl3.Text = df2.number3(randomy);
                df2pictureBox3.Image = System.Drawing.Image.FromFile(df2.picture3(randomy));

                df2namelbl4.Text = df2.name4(randomy);
                df2nolbl4.Text = df2.number4(randomy);
                df2pictureBox4.Image = System.Drawing.Image.FromFile(df2.picture4(randomy));
            }
            #endregion

            #endregion

            #region Striker //Forvet 4lü

            #region Striker Object1
            using (Striker st = new Striker())
            {
                frnolbl1.Text = st.name1(randomx);
                frnamelbl1.Text = st.number1(randomx);
                frpictureBox1.Image = System.Drawing.Image.FromFile(st.picture1(randomx));

                frnolbl2.Text = st.name2(randomx);
                frnamelbl2.Text = st.number2(randomx);
                frpictureBox2.Image = System.Drawing.Image.FromFile(st.picture2(randomx));

                frnolbl3.Text = st.name3(randomx);
                frnamelbl3.Text = st.number3(randomx);
                frpictureBox3.Image = System.Drawing.Image.FromFile(st.picture3(randomx));

                frnolbl4.Text = st.name4(randomx);
                frnamelbl4.Text = st.number4(randomx);
                frpictureBox4.Image = System.Drawing.Image.FromFile(st.picture4(randomx));
            }
            #endregion

            #region Striker Object2

            using (Striker st2 = new Striker())
            {
                fr2namebl1.Text = st2.name1(randomy);
                fr2nolbl1.Text = st2.number1(randomy);
                fr2pictureBox1.Image = System.Drawing.Image.FromFile(st2.picture1(randomy));

                fr2namebl2.Text = st2.name2(randomy);
                fr2nolbl2.Text = st2.number2(randomy);
                fr2pictureBox2.Image = System.Drawing.Image.FromFile(st2.picture2(randomy));

                fr2namebl3.Text = st2.name3(randomy);
                fr2nolbl3.Text = st2.number3(randomy);
                fr2pictureBox3.Image = System.Drawing.Image.FromFile(st2.picture3(randomy));

                label5.Text = st2.name4(randomy);
                label4.Text = st2.number4(randomy);
                fr2pictureBox4.Image = System.Drawing.Image.FromFile(st2.picture4(randomy));
            }

            #endregion

            #endregion

            #region Santrafor //Forvet 2li

            #region Different Photo2
                int random1 = rnd.Next(0, 2);
                int random2 = rnd.Next(0, 2);

                while (random1 == random2)
                {
                    random2 = rnd.Next(0, 2);
                }
            #endregion

            #region Santrafor Object1
            using (Santrafor st = new Santrafor())
                {
                    strnamelbl1.Text = st.name1(random1);
                    strnolbl1.Text = st.number1(random1);
                    strpictureBox1.Image = System.Drawing.Image.FromFile(st.picture1(random1));

                    strnamelbl2.Text = st.name2(random1);
                    strnolbl2.Text = st.number2(random1);
                    strpictureBox2.Image = System.Drawing.Image.FromFile(st.picture2(random1));
                }
            #endregion

            #region Santrafor Object2
                using (Santrafor st2 = new Santrafor())
                {
                    label7.Text = st2.name1(random2);
                    str2nolbl1.Text = st2.number1(random2);
                    str2pictureBox1.Image = System.Drawing.Image.FromFile(st2.picture1(random2));

                    label8.Text = st2.name2(random2);
                    str2nolbl2.Text = st2.number2(random2);
                    str2pictureBox2.Image = System.Drawing.Image.FromFile(st2.picture2(random2));

                }
            #endregion

            #endregion
        }

        #region TeamArray

        string[] TurkeyTeam = { "FB", "GS", "BJK" };
        string[] FranceTeam = { "Paris Saint‑Germain", "Lens", "Rennes" };

        #endregion

        #region Country, Team1 Combobox
        private void team1cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Text = team1cmbx.Text;

            if (comboBox1.SelectedIndex == 0)
            {
                

                for (int i = 0; i < 3; i++)
                {
                    team2cmbx.Items.Add(TurkeyTeam[i]);
                    if (team1cmbx.SelectedItem.ToString() == TurkeyTeam[i].ToString())
                    {
                        team2cmbx.Items.Remove(TurkeyTeam[i]);
                    }
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                team2cmbx.Items.Clear();
                team1cmbx.Items.Clear();

                for (int i = 0; i < 3; i++)
                {
                    team2cmbx.Items.Add(FranceTeam[i]);
                    if (team1cmbx.SelectedItem.ToString() == FranceTeam[i].ToString())
                    {
                        team2cmbx.Items.Remove(FranceTeam[i]);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                for (int i = 0; i < 3; i++)
                    team1cmbx.Items.Add(TurkeyTeam[i]);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                    team1cmbx.Items.Add(FranceTeam[i]);
            }

        }
        private void teamcmbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox3.Text = team2cmbx.Text;

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void teambtn2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int score1 = rnd.Next(0,10);
            int score2 = rnd.Next(0,10);

            scoretxt1.Text = Convert.ToString(score1);
            scoretxt2.Text = Convert.ToString(score2);

            scoretxt1.Visible = true;
            scoretxt2.Visible = true;
            label6.Visible = true;

            #region KEEPER

            //using (Keepers kp = new Keepers())
            //{
            //    int randomx = rnd.Next(0, 5);

            //    keepernamelbl.Text = kp.name(randomx);
            //    keepnumberlbl1.Text = kp.number(randomx);
            //    keeper2pictureBox.Image = System.Drawing.Image.FromFile(kp.picture(randomx));

            //}
            #endregion

            #region Defenses
            //using (Defense df = new Defense())
            //{
            //    int random1 = rnd.Next(0, 5);
            //    df2namebl1.Text = df.name1(random1);
            //    df2nolbl1.Text = df.number1(random1);
            //    df2pictureBox1.Image = System.Drawing.Image.FromFile(df.picture1(random1));

            //    df2namelbl2.Text = df.name2(random1);
            //    df2nolbl2.Text = df.number2(random1);
            //    df2pictureBox2.Image = System.Drawing.Image.FromFile(df.picture2(random1));

            //    df2namelbl3.Text = df.name3(random1);
            //    df2nolbl3.Text = df.number3(random1);
            //    df2pictureBox3.Image = System.Drawing.Image.FromFile(df.picture3(random1));

            //    df2namelbl4.Text = df.name4(random1);
            //    df2nolbl4.Text = df.number4(random1);
            //    df2pictureBox4.Image = System.Drawing.Image.FromFile(df.picture4(random1));
            //}
            #endregion

            #region Striker //Forvet 4lü

            //using (Striker st = new Striker())
            //{
            //    int random1 = rnd.Next(0, 5);
            //    fr2namebl1.Text = st.name1(random1);
            //    fr2nolbl1.Text = st.number1(random1);
            //    fr2pictureBox1.Image = System.Drawing.Image.FromFile(st.picture1(random1));

            //    fr2namebl2.Text = st.name2(random1);
            //    fr2nolbl2.Text = st.number2(random1);
            //    fr2pictureBox2.Image = System.Drawing.Image.FromFile(st.picture2(random1));

            //    fr2namebl3.Text = st.name3(random1);
            //    fr2nolbl3.Text = st.number3(random1);
            //    fr2pictureBox3.Image = System.Drawing.Image.FromFile(st.picture3(random1));

            //    fr2namebl4.Text = st.name4(random1);
            //    fr2nolbl4.Text = st.number4(random1);
            //    fr2pictureBox4.Image = System.Drawing.Image.FromFile(st.picture4(random1));
            //}

            #endregion

            #region Santrafor //Forvet 2li

            //using (Santrafor st2 = new Santrafor())
            //{
            //    int random1 = rnd.Next(0, 2);
            //    str2namelbl1.Text = st2.name1(random1);
            //    str2nolbl1.Text = st2.number1(random1);
            //    str2pictureBox1.Image = System.Drawing.Image.FromFile(st2.picture1(random1));

            //    str2namelbl2.Text = st2.name2(random1);
            //    str2nolbl2.Text = st2.number2(random1);
            //    str2pictureBox2.Image = System.Drawing.Image.FromFile(st2.picture2(random1));

            //}

            #endregion
        }

        private void dfpictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void frnamelbl1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dfpictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dfnumberlbl1_Click(object sender, EventArgs e)
        {

        }

        private void dfnamelbl1_Click(object sender, EventArgs e)
        {

        }
    }
}

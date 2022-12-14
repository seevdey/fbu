using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometriksekilmetot0612
{
    internal class Program
    {
        #region Kare Metot
        static int KareCevre(int kenar)
        {
            return kenar * 4;
        }

        static int KareAlan(int kenar)
        {
            return (int)Math.Pow(kenar, 2);
        }

        #endregion

        #region Daire Metot
        static double DaireAlan(double pi, double yaricap)
        {
            return (int) pi * Math.Pow(yaricap, 2);
        }

        static double DaireCevre(double pi, double yaricap)
        {
            return 2 * pi * yaricap;
        }
        #endregion

        #region Dikdörtgen Metot

        static void DikdortgenAlan(int kisakenar, int uzunkenar)
        {
            Console.WriteLine($"Dikdörtgenin Alanı : {kisakenar * uzunkenar}");
        }
        static void DikdortgenCevre(int kisakenar, int uzunkenar)
        {
            Console.WriteLine($"Dikdörtgenin Çevresi : {(kisakenar * 2) + (uzunkenar * 2)}");
        }

        #endregion

        #region Üçgen Metot

        public void UcgenAlan(string ucgencesiti, int tabanalani, int yukseklik, params int[] kenar)
        {
            if (ucgencesiti == "1")
            {

            }
        }

        static int Cevre(string ucgencesiti, params int[] kenarlar)
        {
            #region İkizkenar
            if (ucgencesiti == "1") //İkizkenar
            {
                int sonuc = 0;
                foreach (int i in kenarlar)
                {
                    sonuc += i;
                }

                return sonuc;

            }
            #endregion

            #region Eşkenar
            else if (ucgencesiti == "2") //Eşkenar
            {
                int sonuc = 0;
                foreach (int i in kenarlar)
                {
                    sonuc = i * 3;
                }
                return sonuc;
            }
            #endregion

            #region Dik Üçgen
            else if (ucgencesiti == "3") //Dik Üçgen
            {
                int sonuc = 0;
                foreach (int i in kenarlar)
                {
                    sonuc += i;
                }
                return sonuc;
            }
            #endregion

            return 0;
        }


        #endregion

        static void Main(string[] args)
        {
            #region Geometrik Şekil Seçimi
            Console.Write("1-Kare\n2-Daire\n3-Dikdörtgen\n4-Üçgen\n");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
            string cevap;
            cevap = Console.ReadLine();
            #endregion

            #region Alan Çevre Seçimi
            Console.Write("\n1-Alan\n2-Çevre\n");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
            string cevap2;
            cevap2 = Console.ReadLine();
            #endregion

            switch (cevap)
            {
                #region Kare
                case "1": 

                    Console.Write("Karenin kenarını giriniz: ");
                    int kenar1 = Convert.ToInt32(Console.ReadLine());
                    if (cevap2 == "1") //Alan
                        Console.WriteLine($"Karenin Alanı : {KareAlan(kenar1)}");
                    else if (cevap2 == "2")//Çevre
                        Console.WriteLine($"Karenin Çevresi : {KareCevre(kenar1)}");
                    break;

                #endregion

                #region Daire
                case "2": //Daire

                    Console.Write("Dairenin yarıçapını giriniz: ");
                    byte yaricap1 = Convert.ToByte(Console.ReadLine());

                    if (cevap2 == "1") //Alan
                        Console.WriteLine($"Dairenin Alanı : {DaireAlan(3.14, yaricap1)}");
                    else if (cevap2 == "2")//Çevre
                        Console.WriteLine($"Dairenin Çevresi : {DaireCevre(3.14, yaricap1)}");
                    break;

                #endregion

                #region Dikdörtgen
                case "3": //Dikdörtgen

                    Console.Write("Dikdörtgenin kısa kenarını giriniz: ");
                    int kisakenar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Dikdörtgenin uzun kenarını giriniz: ");
                    int uzunkenar = Convert.ToInt32(Console.ReadLine());

                    if (cevap2 == "1") //Alan
                        DikdortgenAlan(kisakenar, uzunkenar);
                    else if (cevap2 == "2")//Çevre
                        DikdortgenCevre(kisakenar, uzunkenar);
                    break;

                #endregion

                #region Üçgen
                case "4": //Üçgen

                    Console.Write("1-İkizkenar\n2-Eşkenar\n3-Dik Üçgen\n");
                    Console.Write("Lütfen üçgen çeşidi seçiniz :  ");
                    string cevap3;
                    cevap3 = Console.ReadLine();

                    switch (cevap3)
                    {
                        #region İkizkenar
                        case "1"://İkizkenar

                            Console.Write("İkizkenar üçgenin 1.(aynı) kenarını giriniz: ");
                            int ikizkenar1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("İkizkenar üçgenin 2. kenarını giriniz: ");
                            int ikizkenar2 = Convert.ToInt32(Console.ReadLine());

                            if (cevap2 == "1") //Alan
                            {

                            }
                            else if (cevap2 == "2")//Çevre
                            {
                                Console.WriteLine($"İkizkenar Üçgenin Çevresi : {Cevre(cevap3, ikizkenar1 * 2, ikizkenar2)}");

                            }
                            break;
                        #endregion

                        #region Eşkenar
                        case "2": //Eşkenar
                            Console.Write("Eşkenar üçgenin kenarını giriniz: ");
                            int eskenar = Convert.ToInt32(Console.ReadLine());

                            if (cevap2 == "1") //Alan
                            {
                            }
                            else if (cevap2 == "2")//Çevre
                            {
                                Console.WriteLine($"Eşkenar Üçgenin Çevresi : {Cevre(cevap3, eskenar)}");
                            }
                            break;
                        #endregion

                        #region Dik Üçgen
                        case "3":

                            Console.Write("Dik üçgenin 1. kenarını giriniz: ");
                            int dikucgen1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Dik üçgenin 2. kenarını giriniz: ");
                            int dikucgen2 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Dik üçgenin 3. kenarını giriniz: ");
                            int dikucgen3 = Convert.ToInt32(Console.ReadLine());

                            if (cevap2 == "1") //Alan
                            {

                            }
                            else if (cevap2 == "2")//Çevre
                            {
                                Console.WriteLine($"Dik Üçgenin Çevresi : {Cevre(cevap3, dikucgen1, dikucgen2, dikucgen3)}");
                            }
                            break;
                        #endregion

                        default:
                            break;
                    }
                    break;
                #endregion

                default:
                    break;
            }


            Console.ReadLine();
        }
    }
}

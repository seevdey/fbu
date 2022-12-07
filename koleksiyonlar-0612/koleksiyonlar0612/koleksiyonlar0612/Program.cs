using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace koleksiyonlar0612
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Koleksiyonlar herhangi boyut sınırlaması olmayan ve tip belirtme zorunluluğu olmayan yapılardır
             *İçlerine veri eklendikçe dinamik olarak kendi boyutlarını belirlerler
             *Kütüphaneleri Collections dir
             *En çok kullanılan koleksiyonlar
             *1.ArrayList
             *2.Hashtable
             *3.SortedList
            */

            #region ArrayList1

            //ArrayList te Tip tanımlaması yok
            //Kalıcı hafızada kalıyor. Diziden farkı bu 

            ArrayList urun = new ArrayList(); //sınıf gibi düşün sııfın nesnesini oluşturuyorum
                                              //ArrayListler tek boyutlu dizi şeklinde yapılanır

            //İÇİNE HER BİR ELEMANI NESNE OLARAK EKLİYOR

            //urun.Add("Buzdolabı");
            //urun.Add('F');
            //urun.Add(12);
            //urun.Add(3.5f);
            //urun.Add("ütü");
            //urun.Add("süpürge");

            //Console.WriteLine("---------Ürün Listesi---------");
            //foreach (var i in urun)
            //{
            //    Console.WriteLine(i);
            //}

            //urun.Remove("ütü"); //ütü string değeri içereni çıkar
            //urun.RemoveAt(4); //4. indeksi sil
            //Console.WriteLine("---------Ürün Listesi---------");
            //foreach (var i in urun)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Ürün Adet Sayısı : " + urun.Count);


            #endregion

            #region Hashtable
            //Hastable da sıra yok

            //Hastbale da referans kullanıyoruz
            //Hashtable ogrenciler = new Hashtable();
            //ogrenciler.Add(3, "ahmet");
            //ogrenciler.Add(8, "veli");
            //ogrenciler.Add(2, "hasan");
            //ogrenciler.Add(1, "kerem");
            //ogrenciler.Add("deneme", "xxxx"); // tanımsız değeri en başa alır
            ////sol tarafta referans veriyruz

            //// Value dediğin an sağ taraftakiler("ahmet", "veli", "hasan", "kerem") value, sol taraftakiler(3, 8,2,1) key olur   //Küçükten büyüğe doğru dizer
            //foreach (string deger in ogrenciler.Values) 
            //{
            //    Console.WriteLine(deger);
            //}

            //Console.WriteLine("-------------------");

            //foreach (var key in ogrenciler.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            #endregion

            #region Hashtable1
            //arama modunda ArrayList kullanabilirim
            //referans için Hastable kullanıyoruz
            //istersem Hashtable in key ini arraylist e atabilirim

            //Hashtable aranan = new Hashtable();
            //bool durum = true;
            //aranan.Add("B", "B ile başlayanlar"); 
            //aranan.Add("BC", "BC ile başlayanlar");
            //aranan.Add("BA", "BA ile başlayanlar");

            //foreach (string key in aranan.Values) //key leri ekrana yazdır
            //{
            //    Console.WriteLine(key);
            //}

            //Console.Write("Aranan Değeri giriniz : ");
            //string deger = Console.ReadLine();
            //ArrayList arrayList = new ArrayList(aranan.Keys); //Girilen değerleri ArrayList e attım

            //foreach (string key in arrayList)
            //{
            //    if (key == deger.ToUpper())
            //    {
            //        Console.WriteLine("Aranan değer {0}", key); //arraylist in içinde varsa ekrana getir
            //        durum = false;
            //    }
            //}
            //if (durum)
            //    Console.WriteLine("Aranan değer bulunamadı");
            //else
            //    Console.WriteLine("Aranan değer bulundu");

            #endregion

            #region Microsoft Örneği

            //Hashtable openwith = new Hashtable();
            //openwith.Add("txt", "notepad.exe");
            //openwith.Add("bmp", "paint.exe");
            //openwith.Add("jpg", "paint.exe");
            //openwith.Add("rtf", "wordpad.exe");

            ////key olarak olan kaydı tekrar eklemedi. Zaten bu kayıt mevcut dedi
            //try
            //{
            //    openwith.Add("doc", "winword");
            //    openwith.Add("txt", "winword");
            //}
            //catch (Exception) 
            //{
            //    //Var olanı tekrar ekleyemezsin
            //    Console.WriteLine("Anahtar kelime olarak \"txt\" bulunmaktadır");
            //}

            //Console.WriteLine("Anahtar rtf nin değeri : " + openwith["rtf"]);

            ////rtf key değeri olan kaydın değerini word.exe yaptım
            //openwith["rtf"] = "word.exe"; //rtf nin yerine word.exe yazdım //var olanı güncelledim

            ////xls anahtarı değeri excel olarak atadım
            ///*openwith["xls"] = "excel.exe";*/ //atadım olmadığını görünce içeri ekledi //olmayana göre yaptım

            //if (!openwith.ContainsKey("xls")) //xls içeriyor mu kontrol et, yoksa ekle
            //    openwith["xls"] = "excel.exe";


            ////Console.WriteLine("\nKey Değerleri ");
            ////foreach (string key in openwith.Keys)
            ////    Console.WriteLine(key);

            ////Console.WriteLine("\nValue Değerleri ");
            ////foreach (string value in openwith.Values)
            ////    Console.WriteLine(value);

            ////Value ve Key değerlerinin ikisini de aynı anda getiriyoruz
            ////DictionaryEntry kullandığım anda Hastable ın hem key ini hem value sini görüntüleyebiliyorum
            //Console.WriteLine("\nKEY \t\t VALUE");
            //foreach (DictionaryEntry de in openwith)
            //    Console.WriteLine($"Key : {de.Key} \t Value : {de.Value}");

            #endregion

            #region SortedList

            //SortedListList --> /Hastable ın sıralanmış hali

            //SortedList sehirler = new SortedList();
            //sehirler.Add("D", "Denizli");
            //sehirler.Add("A", "Adana");
            //sehirler.Add("B", "Bursa");
            //Console.WriteLine("Tüm elemanlar");
            //Console.WriteLine("-------------------------");

            ////ICollection interface i kullanarak değişkene key ya da value ları atabilirim
            ////ICollection tipindeki değişkenlere key ve value değerlerini atabilirim
            //ICollection Keys = sehirler.Keys;
            //foreach (string key in Keys)
            //    Console.WriteLine($"{key} ile başlayan şehir : {sehirler[key]}");

            #endregion

            #region SortedList

            //SortedListte sıra var

            //SortedList islem = new SortedList();
            //islem.Add(4, "toplama");
            //islem.Add(3, "çıkarma ");
            //islem.Add(2, "çarpma");
            //islem.Add(1, "bölme");
            //islem.Add(0, "-");

            ////IDictionaryEnumerator --> bu arayüzde tanımladığın zaman MoveNext metodunu kullanarak soldan sağa gezinmemizi sağlıyor
            ////IDictionaryEnumerator ara yüzünü kullanarak koleksiyonda soldan sağa doğru move metoduyla ilerlememizi sağlar.
            //// Sadece ileri hareket sağlıyor. Geriye hareket yok

            //for la sadece key değerlerini alabiliyoruz. Bu yüzden DictionaryEntry kullanmıştık yukarıdaki örnekte
            //foreach te sadece key ya da sadece value değerlerini atayabiliyoruz

            //IDictionaryEnumerator ara = islem.GetEnumerator();
            //string goster = string.Empty; //bu şekilde string e boş değer verebiliyoruz
            //while (ara.MoveNext())
            //{
            //    goster = ara.Value.ToString();
            //    Console.WriteLine($"islem değerleri : {ara.Key} {goster}");
            //}

            #endregion

            Console.ReadLine();
        }
    }
}

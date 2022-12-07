using System;

namespace nongenerics0712
{
    internal class otomobil
    {
        object model;
        //object tüm tipleri içerir
        //object değişkendir içinde veri tutar, var değşiken değil dönüşüm sağlıyor yani takma isim
        //var hafızada yer tutmuyor
        //using hafızadan temizliyor

        public otomobil(object obj) //constructor da başlangıç değeri var //Verinin tipini öğrenmek için içinde parametre istedim
        {
            this.model = obj;
        }   

        public object GetObj()
        {
            return model;
        }

        public void TipGoster()
        {
            //gelen modelin tipini yazdırıyorum
            Console.WriteLine("obj ' nin veri türü : " + model.GetType());
        }
    }
}

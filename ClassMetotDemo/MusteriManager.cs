using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Müşterini Kaydı Eklenmiştir.");
        }
        public void MusteriSil(Musteri musteri) 
        {
            Console.WriteLine(musteri.Ad + " " +musteri.Soyad + " Müşterini Kaydı Silinmiştir.");
            
        }
    }
}

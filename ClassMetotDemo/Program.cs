using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "ali";
            musteri1.Soyad = "kemal";
            Musteri musteri2 = new Musteri();
            musteri2.Ad = "veli";
            musteri2.Soyad = "can";
            Musteri musteri3 = new Musteri();
            musteri3.Ad = "şaban";
            musteri3.Soyad = "mati";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var mus in musteriler)
            {
                Console.WriteLine(mus.Ad+" "+ mus.Soyad);
            }
            Console.WriteLine("*************************************************");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriSil(musteri2);
        }
    }
}

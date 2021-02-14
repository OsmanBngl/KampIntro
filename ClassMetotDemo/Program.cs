using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Osman";
            musteri1.Soyad = "Bingul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad= "Emre";
            musteri2.Soyad = "Şirinyurt";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Enes";
            musteri3.Soyad = "Akyüz";


            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(musteri1);
            musterimanager.Add(musteri2);
            musterimanager.Delete(musteri2);
            musterimanager.List(musteri3);
        }
    }
}

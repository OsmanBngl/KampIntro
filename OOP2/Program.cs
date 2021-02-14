using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "osman";
            musteri1.Soyadi = "bingül";
            musteri1.TcNo = "32131231";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 3;
            musteri2.MusteriNo = "32131231";
            musteri2.SirketAdi = "Bingul Yazılım";
            musteri2.VergiNo = "321321312312";



            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}

using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 5;
            urun1.ÜretimYeri = "Amasya";
            urun1.Kilo = 5000;


            Product urun2 = new Product();
            urun2.Adi = "Kiraz";
            urun2.Fiyati = 40;
            urun2.ÜretimYeri = "Düzce";
            urun2.Kilo = 10;


            Product urun3 = new Product();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 20;
            urun3.ÜretimYeri = "Diyarbakır";
            urun3.Kilo = 10000;
               




            Product[] urun = new Product[] { urun1, urun2, urun3 };

            for (int i = 0; i < urun.Length; i++)
            {

                Console.WriteLine(urun[i].Adi);
                Console.WriteLine(urun[i].Fiyati);
                Console.WriteLine(urun[i].ÜretimYeri);
                Console.WriteLine(urun[i].Kilo);
            }


            foreach (Product urunler in urun)
            {
                Console.WriteLine(urunler.Adi);
                Console.WriteLine(urunler.Fiyati+ " " +"TL");
                Console.WriteLine(urunler.ÜretimYeri);
                Console.WriteLine(urunler.Kilo);

            }

            Console.WriteLine("-------------Metotlar--------------");

            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            sepetManager.Ekle2("Armut",12,"amasya",4,2);
            sepetManager.Ekle2("Elma", 12, "amasya", 4,34);
            sepetManager.Ekle2("Karpuz", 12, "amasya", 4,6);
            sepetManager.Ekle2("Kiraz", 12, "amasya", 4,9);



        }




    }
}
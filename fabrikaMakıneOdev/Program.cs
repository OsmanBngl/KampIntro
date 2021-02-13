using System;

namespace fabrikaMakıneOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADI---MARKA-SATIN ALMA TARİHİ-ÇALIŞMA SAATİ---ÜRETİM KAPASİTESİ--ÇALIŞIYORMU");
            Makine makine1 = new Makine();
            makine1.Adi = "Winner1";
            makine1.Marka = "Winner";
            makine1.SatinAlmaTarihi = "07.05.2010";
            makine1.MaksimumCalismaSaati = 5;
            makine1.UretimKapasitesi = "24 saat'te 1000 adet üretim kapasitesi var ";
            makine1.Calisiyormu = "Evet";
            makine1.HurdayaVerilecekmi = "Winner1 Verilecek";
            
            Makine makine2 = new Makine();
            makine2.Adi = "Winner2";
            makine2.Marka = "Winner";
            makine2.SatinAlmaTarihi = "07.04.2011";
            makine2.MaksimumCalismaSaati = 6;
            makine2.UretimKapasitesi = "24 saat'te 500 adet üretim kapasitesi var ";
            makine2.Calisiyormu = "Evet";
            makine2.HurdayaVerilecekmi = "Winner2 Verilmeyecek";

            Makine makine3 = new Makine();
            makine3.Adi = "Winner3";
            makine3.Marka = "Winner";
            makine3.SatinAlmaTarihi = "07.07.2012";
            makine3.MaksimumCalismaSaati = 12;
            makine3.UretimKapasitesi = "24 saat'te 200 adet üretim kapasitesi var ";
            makine3.Calisiyormu = "Hayır";
            makine3.HurdayaVerilecekmi = "Winner3 Verilecek";

            Makine makine4 = new Makine();
            makine4.Adi = "Winner4";
            makine4.Marka = "Winner";
            makine4.SatinAlmaTarihi = "07.09.2013";
            makine4.MaksimumCalismaSaati = 8;
            makine4.UretimKapasitesi = "24 saat'te 300 adet üretim kapasitesi var ";
            makine4.Calisiyormu = "Hayır";
            makine4.HurdayaVerilecekmi = "Winner4 Verilecek";

            Makine makine5 = new Makine();
            makine5.Adi = "Winner5";
            makine5.Marka = "Winner";
            makine5.SatinAlmaTarihi = "07.11.2014";
            makine5.MaksimumCalismaSaati = 3;
            makine5.UretimKapasitesi = "24 saat'te 500 adet üretim kapasitesi var ";
            makine5.Calisiyormu = "Evet";
            makine5.HurdayaVerilecekmi = "Winner5 Verilmeyecek";

            Makine makine6 = new Makine();
            makine6.Adi = "Winner6";
            makine6.Marka = "Winner";
            makine6.SatinAlmaTarihi = "07.12.2015";
            makine6.MaksimumCalismaSaati = 24;
            makine6.UretimKapasitesi = "24 saat'te 700 adet üretim kapasitesi var ";
            makine6.Calisiyormu = "Hayır";
            makine6.HurdayaVerilecekmi = "Winner6 Verilecek";


            Makine makine7 = new Makine();
            makine7.Adi = "Winner7";
            makine7.Marka = "Winner";
            makine7.SatinAlmaTarihi = "07.03.2016";
            makine7.MaksimumCalismaSaati = 7;
            makine7.UretimKapasitesi = "24 saat'te 250 adet üretim kapasitesi var ";
            makine7.Calisiyormu = "Evet";
            makine7.HurdayaVerilecekmi = "Winner7 Verilmeyecek";
            

            Makine makine8 = new Makine();
            makine8.Adi = "Winner8";
            makine8.Marka = "Winner";
            makine8.SatinAlmaTarihi = "07.04.2017";
            makine8.MaksimumCalismaSaati = 14;
            makine8.UretimKapasitesi = "24 saat'te 1200 adet üretim kapasitesi var ";
            makine8.Calisiyormu = "Hayır";
            makine8.HurdayaVerilecekmi = "Winner8 Verilecek";

            Makine makine9 = new Makine();
            makine9.Adi = "Winner9";
            makine9.Marka = "Winner";
            makine9.SatinAlmaTarihi = "07.09.2018";
            makine9.MaksimumCalismaSaati = 13;
            makine9.UretimKapasitesi = "24 saat'te 600 adet üretim kapasitesi var ";
            makine9.Calisiyormu = "Evet";
            makine9.HurdayaVerilecekmi = "Winner9 Verilmeyecek";

            Makine makine10 = new Makine();
            makine10.Adi = "Winner10";
            makine10.Marka = "Winner";
            makine10.SatinAlmaTarihi = "07.02.2020";
            makine10.MaksimumCalismaSaati = 30;
            makine10.UretimKapasitesi = "24 saat'te 2000 adet üretim kapasitesi var ";
            makine10.Calisiyormu = "Evet";
            makine10.HurdayaVerilecekmi = "Winner10 Verilmeyecek";

            Makine[] makineler = new Makine[] { makine1, makine2, makine3, makine4, makine5, makine6, makine7, makine8, makine9};

            foreach (var makine in makineler)
            {
                Console.WriteLine(makine.Adi+ " " +makine.Marka+ " " +makine.SatinAlmaTarihi + " " + makine.MaksimumCalismaSaati + " " + makine.UretimKapasitesi + " " + makine.Calisiyormu);
            }
            
            Console.WriteLine("#--Hurdaya Verilcek Makineler--#");
           
            Makine[] HurdaMakineler = new Makine[] { makine1, makine2, makine3, makine4, makine5, makine6, makine7, makine8, makine9, makine10 };

            foreach (var makine in HurdaMakineler)
            {
                Console.WriteLine(makine.HurdayaVerilecekmi);
            }

        }
    }

    class Makine
    {
        public string Adi { get; set; }
        public string Marka { get; set; }
        public string SatinAlmaTarihi { get; set; }
        public int MaksimumCalismaSaati { get; set; }
        public string UretimKapasitesi { get; set; }
        public string Calisiyormu { get; set; }

        public string HurdayaVerilecekmi { get; set; }
    }
}

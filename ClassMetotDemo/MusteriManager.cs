using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Id+ " " + musteri.Ad+ " " + musteri.Soyad   );

        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad );
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi :");
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi:" + urun.Adi);
        }
        public void Ekle2(string Adi,int Fiyati, string ÜretimYeri,int Kilo,int StokAdedi) 
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi:" + Adi);
        }
    }
}

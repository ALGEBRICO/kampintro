using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //convention isimlendirme kuralı
        public void Ekle(Urun urun)           //normal bir parantez ise orada bir metod çalışıyordur.
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunAdi, string urunAciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi : " + urunAdi);
        }


    }
}

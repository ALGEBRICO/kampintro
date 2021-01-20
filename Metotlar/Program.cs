using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati =15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };


            foreach (Urun urun in urunler)
            {
                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------");
            }

            Console.WriteLine("-----------------Metotlar-------------------");
            //instance - örnek
            // encapsulation düzensiz bir yapıyı düzenli hale getirmek demek


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", "yeşil armut", 12,11);
            sepetManager.Ekle2("eellma", "yeşil elma", 12,1231);
            sepetManager.Ekle2("akarpuz", "karpıuzul armut", 12,8);


        }
    }
}


// do not repeat yourself -dry - clean code - best practice
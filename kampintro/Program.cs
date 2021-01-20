using System;

namespace kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //do not repeat yourself
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            int x = 10;
            int y = 20;

            int max = 0;

            max = x > y ? x : y;
            Console.WriteLine("Hello World");
            Console.WriteLine(max);

            //int gun = (int)DateTime.Now.DayOfWeek;
            //switch (gun)
            //{
            //   case 1:
            //       Console.Write("Bugün Pazartesi");
            //       break;
            //   case 2:
            //        Console.Write("Bugün Salı");
            //        break;
            //   case 3:
            //       Console.Write("Bugün Çarşamba");
            //       break;
            //   case 4:
            //       Console.Write("Bugün Perşembe");
            //       break;
            //   case 5:
            //       Console.Write("Bugün Cuma");
            //        break;
            //   case 6:
            //        Console.Write("Bugün Cumartesi");
            //       break;
            //   case 7:
            //         Console.Write("Bugün Pazar");
            //         break;
            //}
            //Console.Write("Bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //while (sayi >= 0)
            //{
            //Console.WriteLine(sayi);
            //System.Threading.Thread.Sleep(1000);
            //sayi--;
            //}
            //Console.ReadKey();
            //int i = 1;
            //while (i <= 10)
            //{
            //Console.WriteLine("Merhaba Dünya");
            //i++;
            //}
            //Console.ReadKey();
            int i = 1;
            for (int i = 0; i <100 ; i--)
            {
                Console.WriteLine(i);
            }
            

        }
        
    }
}

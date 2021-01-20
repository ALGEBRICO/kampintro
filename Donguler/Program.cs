using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kampı";
            string kurs2 = "Temel kurs";
            string kurs3 = "jhava kursu";
            string kurs4 = "paython";

            //array - dizi liste listeleme birden fazla herşeyi tanımlayabileceğimiz listeler

            string[] kurslar = new string[] { "Yazılım geliştirici kampı", "Temel kurs", "jhava kursu","payhgton","ahnet","metmhmet" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");



            foreach (string burasitakmaisim in kurslar) // foreach de forla aynı sadece tek farkı farklı yoğurt yiyiştir
            {
                Console.WriteLine(burasitakmaisim);
            }
            Console.WriteLine("sayfasonu - footer");

            //for (int i = 1; i < 10; i+=2)//1 den başlıyıcaz   i<10 ise şartımız bu döngü bu şart geçerli olduğu sürece çalışır i++ i'yi 1 1 arttır demek
            //{
            //                Console.WriteLine(i);
            //          }
        }
    }
}
